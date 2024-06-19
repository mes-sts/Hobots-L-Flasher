using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Hobots_L_Flasher.Properties;
using MetroFramework;
using MetroFramework.Forms;

namespace Hobots_L_Flasher
{
    public partial class MainForm : MetroForm
    {
        // Для WndProc
        private const int WM_DEVICECHANGE = 0x0219; //Сообщение об аппаратных изменениях
        private const int DBT_DEVICEARRIVAL = 0x8000; //Подключен USB-COM
        private const int DBT_DEVICEREMOVECOMPLETE = 0x8004; //Отключен USB-COM

        // Делегат приема данных от прошивок
        private delegate void ReceivedEvent(string data);

        public MainForm()
        {
            InitializeComponent();
            PortsPreparation();
            lblCopyrightAndVersionVlalue.Text += Assembly.GetExecutingAssembly().GetName().Version.ToString();
            cbContollers.SelectedIndex = 0;
            cbProgrammers.SelectedIndex = 0;
            cbDriverType.SelectedIndex = 0;
            cbComPortBaudrate.SelectedIndex = 0;
        }

        #region ВСПОМОГАТЕЛЬНЫЕ ДЛЯ ОБРАБОТКИ ВНУТРЯНКИ
        // Подготовка и автовыбор порта в списке
        private void PortsPreparation()
        {
            // Заполнение массива найденными портами
            string[] ports = SerialPort.GetPortNames();
            cbComPorts.Items.Clear();
            cbComPortsTerminal.Items.Clear();
            cbComPorts.Items.AddRange(ports);
            cbComPortsTerminal.Items.AddRange(ports);

            if (!serialPort.IsOpen)
            {
                serialPort.Close();
            }

            // Если есть хоть один порт - выбрать его, иначе пустое поле
            cbComPorts.SelectedIndex = (ports.Length != 0) ? 0 : -1;
            cbComPortsTerminal.SelectedIndex = (ports.Length != 0) ? 0 : -1;

            // Активность кнопки в зависимости от наличия портов
            if (cbComPorts.Text == string.Empty ||
                cbComPortsTerminal.Text == string.Empty)
            {
                btnDownloadFirmwarePort.Enabled = false;
                cbComPorts.Enabled = false;

                btnStartStopTerminal.Enabled = false;
                cbComPortsTerminal.Enabled = false;
            }
            else
            {
                btnDownloadFirmwarePort.Enabled = true;
                cbComPorts.Enabled = true;

                btnStartStopTerminal.Enabled = true;
                cbComPortsTerminal.Enabled = true;
            }
        }

        // Обновление списка портов при подключении/отключении USB-COM устройств 
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_DEVICECHANGE)
            {
                if (m.WParam.ToInt32() == DBT_DEVICEARRIVAL ||
                    m.WParam.ToInt32() == DBT_DEVICEREMOVECOMPLETE)
                    PortsPreparation();
            }
            base.WndProc(ref m);
        }

        /// <summary>
        /// Обработка внешних приложений-прошивальщиков
        /// </summary>
        /// <param name="path">Путь к прошивальщику</param>
        /// <param name="args">Аргумент командной строки</param>
        /// <returns>Ответ командной строки с ошибками</returns>
        private string StartProcessAndGetOutput(string path, string args)
        {
            using (Process process = new Process())
            {
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.Verb = "runas";
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.FileName = path;
                process.StartInfo.Arguments = args;
                process.Start();
                process.WaitForExit();

                return process.StandardOutput.ReadToEnd() + process.StandardError.ReadToEnd();
            }
        }

        // Получение пути к файлу пользовательской прошивки
        private void tbFirmwarePath_ButtonClick(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Выбор файла прошивки";
            ofd.AddExtension = true;

            /* AVR .hex */
            if (cbContollers.SelectedIndex == 0 || // Стандартный
                cbContollers.SelectedIndex == 1 || // Классический
                cbContollers.SelectedIndex == 2 || // Мини
                cbContollers.SelectedIndex == 3) // Гипер
            {
                ofd.Filter = "Файлы Intel HEX|*.hex";
            }
            /* STM32, ESP32 .bin */
            else if (cbContollers.SelectedIndex == 4) // rsvd
            {
                ofd.Filter = "Файлы BIN|*.bin";
            }

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tbFirmwarePath.Text = ofd.FileName;
            }
        }

        // Таймер сброса поля статус в значение по умолчанию
        private void timerResetStatus_Tick(object sender, EventArgs e)
        {
            lblDownloadStatus.Text = "--/--";
            lblDownloadStatus.BackColor = Color.White;
            timerResetStatus.Stop();
            timerResetStatus.Enabled = false;
        }

        // Очистка содержимого терминала
        private void btnCleanTerminal_Click(object sender, EventArgs e)
        {
            tbTerminal.Clear();
        }

        // Закрытие последовательного порта если он открыт
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }

        // Событие приема данных из порта
        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                BeginInvoke(new ReceivedEvent(DataProcessing), serialPort.ReadLine());
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

        }

        // Обработка принятых из порта данных
        private void DataProcessing(string dataReceived)
        {
            tbTerminal.AppendText(dataReceived + Environment.NewLine);
        }
        #endregion

        // ЗАгрузка прощивко через порт
        private void btnDownloadFirmwarePort_Click(object sender, EventArgs e)
        {
            string cli_arguments = null;

            /* AVR ATmega328 .hex */
            if (cbContollers.SelectedIndex == 0 || // Стандартный
                cbContollers.SelectedIndex == 1 || // Классический
                cbContollers.SelectedIndex == 2)   // Мини
            {
                if (tbFirmwarePath.Text != string.Empty)
                {
                    cli_arguments = "-C " + Resources.AVRDUDE_CONF_PATH + " -p m328p -P " + cbComPorts.Text + " -c arduino  -b 115200 -U flash:w:" + tbFirmwarePath.Text + ":i -D";
                }
                else
                {
                    if (cbContollers.SelectedIndex == 0) // Стандартный
                    {
                        if (cbFirmware.SelectedIndex == 0) // Демо
                        {
                            cli_arguments = "-C " + Resources.AVRDUDE_CONF_PATH + " -p m328p -P " + cbComPorts.Text + " -c arduino  -b 115200 -U flash:w:" + Resources.FIRMWARE_DEMO_STANDART + ":i -D";
                        }
                        else if (cbFirmware.SelectedIndex == 1) // Звук
                        {
                            cli_arguments = "-C " + Resources.AVRDUDE_CONF_PATH + " -p m328p -P " + cbComPorts.Text + " -c arduino  -b 115200 -U flash:w:" + Resources.FIRMWARE_BEEPER_STANDART + ":i -D";
                        }
                        else if (cbFirmware.SelectedIndex == 2) // Моторы
                        {
                            cli_arguments = "-C " + Resources.AVRDUDE_CONF_PATH + " -p m328p -P " + cbComPorts.Text + " -c arduino  -b 115200 -U flash:w:" + Resources.FIRMWARE_MOTORS_STANDART + ":i -D";
                        }
                        else if (cbFirmware.SelectedIndex == 3) // Сервопривод
                        {
                            cli_arguments = "-C " + Resources.AVRDUDE_CONF_PATH + " -p m328p -P " + cbComPorts.Text + " -c arduino  -b 115200 -U flash:w:" + Resources.FIRMWARE_SERVO_STANDART + ":i -D";
                        }
                        else if (cbFirmware.SelectedIndex == 4) // Сонар
                        {
                            cli_arguments = "-C " + Resources.AVRDUDE_CONF_PATH + " -p m328p -P " + cbComPorts.Text + " -c arduino  -b 115200 -U flash:w:" + Resources.FIRMWARE_SONAR_STANDART + ":i -D";
                        }
                        else if (cbFirmware.SelectedIndex == 5) // Кнопка
                        {
                            cli_arguments = "-C " + Resources.AVRDUDE_CONF_PATH + " -p m328p -P " + cbComPorts.Text + " -c arduino  -b 115200 -U flash:w:" + Resources.FIRMWARE_BUTTON_STANDART + ":i -D";
                        }
                        else if (cbFirmware.SelectedIndex == 6) // ИК приёмник
                        {
                            cli_arguments = "-C " + Resources.AVRDUDE_CONF_PATH + " -p m328p -P " + cbComPorts.Text + " -c arduino  -b 115200 -U flash:w:" + Resources.FIRMWARE_IR_RECEIVER_STANDART + ":i -D";
                        }
                        else if (cbFirmware.SelectedIndex == 7) // Датчик линии
                        {
                            cli_arguments = "-C " + Resources.AVRDUDE_CONF_PATH + " -p m328p -P " + cbComPorts.Text + " -c arduino  -b 115200 -U flash:w:" + Resources.FIRMWARE_LINE_STANDART + ":i -D";
                        }
                        else if (cbFirmware.SelectedIndex == 8) // Датчик цвета
                        {
                            cli_arguments = "-C " + Resources.AVRDUDE_CONF_PATH + " -p m328p -P " + cbComPorts.Text + " -c arduino  -b 115200 -U flash:w:" + Resources.FIRMWARE_COLOR_STANDART + ":i -D";
                        }
                        else if (cbFirmware.SelectedIndex == 9) // Bluetooth
                        {
                            cli_arguments = "-C " + Resources.AVRDUDE_CONF_PATH + " -p m328p -P " + cbComPorts.Text + " -c arduino  -b 115200 -U flash:w:" + Resources.FIRMWARE_BLUETOOTH_STANDART + ":i -D";
                        }
                    }
                    else if (cbContollers.SelectedIndex == 1) // Классический
                    {
                        if (cbFirmware.SelectedIndex == 0) // Демо
                        {
                            cli_arguments = "-C " + Resources.AVRDUDE_CONF_PATH + " -p m328p -P " + cbComPorts.Text + " -c arduino  -b 115200 -U flash:w:" + Resources.FIRMWARE_DEMO_CLASSIC + ":i -D";
                        }
                        else if (cbFirmware.SelectedIndex == 1) // Звук
                        {
                            cli_arguments = "-C " + Resources.AVRDUDE_CONF_PATH + " -p m328p -P " + cbComPorts.Text + " -c arduino  -b 115200 -U flash:w:" + Resources.FIRMWARE_BEEPER_CLASSIC + ":i -D";
                        }
                        else if (cbFirmware.SelectedIndex == 2) // Моторы
                        {
                            cli_arguments = "-C " + Resources.AVRDUDE_CONF_PATH + " -p m328p -P " + cbComPorts.Text + " -c arduino  -b 115200 -U flash:w:" + Resources.FIRMWARE_MOTORS_CLASSIC + ":i -D";
                        }
                        else if (cbFirmware.SelectedIndex == 3) // Сервопривод
                        {
                            cli_arguments = "-C " + Resources.AVRDUDE_CONF_PATH + " -p m328p -P " + cbComPorts.Text + " -c arduino  -b 115200 -U flash:w:" + Resources.FIRMWARE_SERVO_CLASSIC + ":i -D";
                        }
                        //todo
                    }
                    else if (cbContollers.SelectedIndex == 2) // Мини
                    {
                        if (cbFirmware.SelectedIndex == 0) // Демо
                        {
                            cli_arguments = "-C " + Resources.AVRDUDE_CONF_PATH + " -p m328p -P " + cbComPorts.Text + " -c arduino  -b 115200 -U flash:w:" + Resources.FIRMWARE_DEMO_MINI + ":i -D";
                        }
                        else if (cbFirmware.SelectedIndex == 1) // Звук
                        {
                            cli_arguments = "-C " + Resources.AVRDUDE_CONF_PATH + " -p m328p -P " + cbComPorts.Text + " -c arduino  -b 115200 -U flash:w:" + Resources.FIRMWARE_BEEPER_MINI + ":i -D";
                        }
                        else if (cbFirmware.SelectedIndex == 2) // Моторы
                        {
                            cli_arguments = "-C " + Resources.AVRDUDE_CONF_PATH + " -p m328p -P " + cbComPorts.Text + " -c arduino  -b 115200 -U flash:w:" + Resources.FIRMWARE_MOTORS_MINI + ":i -D";
                        }
                        else if (cbFirmware.SelectedIndex == 3) // Сервопривод
                        {
                            cli_arguments = "-C " + Resources.AVRDUDE_CONF_PATH + " -p m328p -P " + cbComPorts.Text + " -c arduino  -b 115200 -U flash:w:" + Resources.FIRMWARE_SERVO_MINI + ":i -D";
                        }
                        else if (cbFirmware.SelectedIndex == 4) // RGB
                        {
                            cli_arguments = "-C " + Resources.AVRDUDE_CONF_PATH + " -p m328p -P " + cbComPorts.Text + " -c arduino  -b 115200 -U flash:w:" + Resources.FIRMWARE_RGB_MINI + ":i -D";
                        }
                        else if (cbFirmware.SelectedIndex == 5) // Кнопка
                        {
                            cli_arguments = "-C " + Resources.AVRDUDE_CONF_PATH + " -p m328p -P " + cbComPorts.Text + " -c arduino  -b 115200 -U flash:w:" + Resources.FIRMWARE_BUTTON_MINI + ":i -D";
                        }
                        else if (cbFirmware.SelectedIndex == 6) // Освещение
                        {
                            cli_arguments = "-C " + Resources.AVRDUDE_CONF_PATH + " -p m328p -P " + cbComPorts.Text + " -c arduino  -b 115200 -U flash:w:" + Resources.FIRMWARE_LIGHT_MINI + ":i -D";
                        }
                        else if (cbFirmware.SelectedIndex == 7) // ИК приёмник
                        {
                            cli_arguments = "-C " + Resources.AVRDUDE_CONF_PATH + " -p m328p -P " + cbComPorts.Text + " -c arduino  -b 115200 -U flash:w:" + Resources.FIRMWARE_IR_RECEIVER_MINI + ":i -D";
                        }
                        else if (cbFirmware.SelectedIndex == 8) // ИК передатчик
                        {
                            cli_arguments = "-C " + Resources.AVRDUDE_CONF_PATH + " -p m328p -P " + cbComPorts.Text + " -c arduino  -b 115200 -U flash:w:" + Resources.FIRMWARE_IR_TRANSMITTER_MINI + ":i -D";
                        }
                        else if (cbFirmware.SelectedIndex == 9) // Сонар
                        {
                            cli_arguments = "-C " + Resources.AVRDUDE_CONF_PATH + " -p m328p -P " + cbComPorts.Text + " -c arduino  -b 115200 -U flash:w:" + Resources.FIRMWARE_SONAR_MINI + ":i -D";
                        }
                        else if (cbFirmware.SelectedIndex == 10) // Датчик линии
                        {
                            cli_arguments = "-C " + Resources.AVRDUDE_CONF_PATH + " -p m328p -P " + cbComPorts.Text + " -c arduino  -b 115200 -U flash:w:" + Resources.FIRMWARE_LINE_MINI + ":i -D";
                        }
                        else if (cbFirmware.SelectedIndex == 11) // Концевик
                        {
                            cli_arguments = "-C " + Resources.AVRDUDE_CONF_PATH + " -p m328p -P " + cbComPorts.Text + " -c arduino  -b 115200 -U flash:w:" + Resources.FIRMWARE_LIM_BUTTON_MINI + ":i -D";
                        }
                        else if (cbFirmware.SelectedIndex == 12) // Концевой прерыватель
                        {
                            cli_arguments = "-C " + Resources.AVRDUDE_CONF_PATH + " -p m328p -P " + cbComPorts.Text + " -c arduino  -b 115200 -U flash:w:" + Resources.FIRMWARE_RGB_LED_MINI + ":i -D";
                        }
                        else if (cbFirmware.SelectedIndex == 13) // Гироскоп
                        {
                            cli_arguments = "-C " + Resources.AVRDUDE_CONF_PATH + " -p m328p -P " + cbComPorts.Text + " -c arduino  -b 115200 -U flash:w:" + Resources.FIRMWARE_GYRO_MINI + ":i -D";
                        }
                    }
                }

                string cli_response = StartProcessAndGetOutput(Resources.AVRDUDE_EXE_PATH, cli_arguments);

                if (cli_response.Contains("of flash verified") &&
                    cli_response.Contains("Fuses OK")) // OK
                {
                    lblDownloadStatus.Text = "Готово!";
                    lblDownloadStatus.BackColor = Color.MediumAquamarine;
                }
                else // exception
                {
                    lblDownloadStatus.Text = "Ошибка!";
                    lblDownloadStatus.BackColor = Color.Tomato;
                }

                if (chbDebugInfoOn.Checked)
                {
                    MessageBox.Show(cli_response);
                }
            }
            /* AVR ATmega2560 .hex */
            else if (cbContollers.SelectedIndex == 3) // Гипер
            {
                if (tbFirmwarePath.Text != string.Empty)
                {
                    cli_arguments = "-C " + Resources.AVRDUDE_CONF_PATH + " -p m2560 -P " + cbComPorts.Text + " -c wiring  -b 115200 -U flash:w:" + tbFirmwarePath.Text + ":i -D";
                }
                else
                {
                    if (cbContollers.SelectedIndex == 3) // Гипер
                    {
                        if (cbFirmware.SelectedIndex == 0) // Демо
                        {
                            cli_arguments = "-C " + Resources.AVRDUDE_CONF_PATH + " -p m2560 -P " + cbComPorts.Text + " -c wiring  -b 115200 -U flash:w:" + Resources.FIRMWARE_DEMO_HYPER + ":i -D";
                        }
                        else if (cbFirmware.SelectedIndex == 1) // Звук
                        {
                            cli_arguments = "-C " + Resources.AVRDUDE_CONF_PATH + " -p m2560 -P " + cbComPorts.Text + " -c wiring  -b 115200 -U flash:w:" + Resources.FIRMWARE_BEEPER_HYPER + ":i -D";
                        }
                        else if (cbFirmware.SelectedIndex == 2) // Моторы
                        {
                            cli_arguments = "-C " + Resources.AVRDUDE_CONF_PATH + " -p m2560 -P " + cbComPorts.Text + " -c wiring  -b 115200 -U flash:w:" + Resources.FIRMWARE_MOTORS_HYPER + ":i -D";
                        }
                        else if (cbFirmware.SelectedIndex == 3) // Сервопривод
                        {
                            cli_arguments = "-C " + Resources.AVRDUDE_CONF_PATH + " -p m2560 -P " + cbComPorts.Text + " -c wiring  -b 115200 -U flash:w:" + Resources.FIRMWARE_SERVO_HYPER + ":i -D";
                        }
                        else if (cbFirmware.SelectedIndex == 4) // Мигалка
                        {
                            cli_arguments = "-C " + Resources.AVRDUDE_CONF_PATH + " -p m2560 -P " + cbComPorts.Text + " -c wiring  -b 115200 -U flash:w:" + Resources.FIRMWARE_LEDS_HYPER + ":i -D";
                        }
                        else if (cbFirmware.SelectedIndex == 5) // Кнопки
                        {
                            cli_arguments = "-C " + Resources.AVRDUDE_CONF_PATH + " -p m2560 -P " + cbComPorts.Text + " -c wiring  -b 115200 -U flash:w:" + Resources.FIRMWARE_BUTTONS_HYPER + ":i -D";
                        }
                    }
                    /*else if () // todo
                    {

                    }*/
                }

                string cli_response = StartProcessAndGetOutput(Resources.AVRDUDE_EXE_PATH, cli_arguments);

                if (cli_response.Contains("of flash verified") &&
                    cli_response.Contains("Fuses OK")) // OK
                {
                    lblDownloadStatus.Text = "Готово!";
                    lblDownloadStatus.BackColor = Color.MediumAquamarine;
                }
                else // exception
                {
                    lblDownloadStatus.Text = "Ошибка!";
                    lblDownloadStatus.BackColor = Color.Tomato;
                }

                if (chbDebugInfoOn.Checked)
                {
                    MessageBox.Show(cli_response);
                }
            }
            /* STM32, ESP32 .bin */
            // ST-LINK_CLI -c SWD -ME -P firm.bin 0x8000000 -Rst -Run -NoPrompt -Q
            else if (cbContollers.SelectedIndex == 4) // rsvd
            {
                /*if (tbFirmwarePath.Text != string.Empty)
                {
                    //textbox
                }
                else
                {
                    //list
                }*/

                lblDownloadStatus.Text = "Ошибка!";
                lblDownloadStatus.BackColor = Color.Tomato;
            }

            timerResetStatus.Enabled = true;
            timerResetStatus.Start();
        }

        private void btnDownloadBootloaderProgrammer_Click(object sender, EventArgs e)
        {
            string cli_arguments = null;

            if (cbProgrammers.SelectedIndex == 0) // USBASP
            {
                if (cbContollers.SelectedIndex == 0 ||
                    cbContollers.SelectedIndex == 1 ||
                    cbContollers.SelectedIndex == 2) // atmega328
                {
                    if (chbUseATmega328pb.Checked)
                    {
                        cli_arguments = "-C " + Resources.AVRDUDE_CONF_PATH + " -c usbasp -p m328pb -b 14400 -U flash:w:" + Resources.BOOTLOADER_ATMEGA328_PATH + ":a " + "-U hfuse:w:0xDE:m -U lfuse:w:0xFF:m -U lock:w:0x3F:m -U efuse:w:0xFD:m -q";
                    }
                    else
                    {
                        cli_arguments = "-C " + Resources.AVRDUDE_CONF_PATH + " -c usbasp -p m328p -b 14400 -U flash:w:" + Resources.BOOTLOADER_ATMEGA328_PATH + ":a " + "-U hfuse:w:0xDE:m -U lfuse:w:0xFF:m -U lock:w:0x3F:m -U efuse:w:0xFD:m -q";
                    }
                }
                else if (cbContollers.SelectedIndex == 3) // atmega2560
                {
                    cli_arguments = "-C " + Resources.AVRDUDE_CONF_PATH + " -c usbasp -p m2560 -b 14400 -U flash:w:" + Resources.BOOTLOADER_ATMEGA2560_PATH + ":a " + "-U hfuse:w:0xD8:m -U lfuse:w:0xFF:m -U lock:w:0x3F:m -U efuse:w:0xFD:m -q";
                }
                else // exception
                {
                    lblDownloadStatus.Text = "Ошибка!";
                    lblDownloadStatus.BackColor = Color.Tomato;
                }

                string cli_response = StartProcessAndGetOutput(Resources.AVRDUDE_EXE_PATH, cli_arguments);

                if (cli_response.Contains("of flash verified") &&
                    cli_response.Contains("Fuses OK")) // OK
                {
                    lblDownloadStatus.Text = "Готово!";
                    lblDownloadStatus.BackColor = Color.MediumAquamarine;
                }
                else // exception
                {
                    lblDownloadStatus.Text = "Ошибка!";
                    lblDownloadStatus.BackColor = Color.Tomato;
                }

                if (chbDebugInfoOn.Checked)
                {
                    MessageBox.Show(cli_response);
                }
            }
            else if (cbProgrammers.SelectedIndex == 1) // STLINK
            {
                lblDownloadStatus.Text = "Ошибка!";
                lblDownloadStatus.BackColor = Color.Tomato;
            }
            else if (cbProgrammers.SelectedIndex == 2) // ESPTOOL
            {
                lblDownloadStatus.Text = "Ошибка!";
                lblDownloadStatus.BackColor = Color.Tomato;
            }
            else // exception
            {
                lblDownloadStatus.Text = "Ошибка!";
                lblDownloadStatus.BackColor = Color.Tomato;
            }

            timerResetStatus.Enabled = true;
            timerResetStatus.Start();

            
        }

        // Установка драйверов
        private void btnInstallDriver_Click(object sender, EventArgs e)
        {
            if (cbDriverType.SelectedIndex == 0) // USBASP
            {
                try
                {
                    using (Process installUSBASP = new Process())
                    {
                        installUSBASP.StartInfo.FileName = Resources.DRIVER_USBASP_PATH;
                        installUSBASP.Start();
                    }
                }
                catch (Exception ex)
                {
                    if (chbDebugInfoOn.Checked)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else if (cbDriverType.SelectedIndex == 1) // STLINK
            {
                try
                {
                    using (Process installSTLINK = new Process())
                    {
                        if (Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE", EnvironmentVariableTarget.Machine) == "AMD64" ||
                            Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE6432", EnvironmentVariableTarget.Machine) == "AMD64")
                        {
                            installSTLINK.StartInfo.FileName = Resources.DRIVER_STLINK_x64_PATH;
                        }
                        else
                        {
                            installSTLINK.StartInfo.FileName = Resources.DRIVER_STLINK_x86_PATH;
                        }

                        installSTLINK.Start();
                    }
                }
                catch (Exception ex)
                {
                    if (chbDebugInfoOn.Checked)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else if (cbDriverType.SelectedIndex == 2) // CH340
            {
                try
                {
                    using (Process installCH340 = new Process())
                    {
                        installCH340.StartInfo.FileName = Resources.DRIVER_CH340_PATH;
                        installCH340.Start();
                    }
                }
                catch (Exception ex)
                {
                    if (chbDebugInfoOn.Checked)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else if (cbDriverType.SelectedIndex == 3) // FT232
            {
                try
                {
                    using (Process installFT23 = new Process())
                    {
                        installFT23.StartInfo.FileName = Resources.DRIVER_FT232_PATH;
                        installFT23.Start();
                    }
                }
                catch (Exception ex)
                {
                    if (chbDebugInfoOn.Checked)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else if (cbDriverType.SelectedIndex == 4) // CP2102
            {
                try
                {
                    using (Process installCP2102 = new Process())
                    {
                        if (Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE", EnvironmentVariableTarget.Machine) == "AMD64" ||
                            Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE6432", EnvironmentVariableTarget.Machine) == "AMD64")
                        {
                            installCP2102.StartInfo.FileName = Resources.DRIVER_CP2102_x64_PATH;
                        }
                        else
                        {
                            installCP2102.StartInfo.FileName = Resources.DRIVER_CP2102_x86_PATH;
                        }

                        installCP2102.Start();
                    }
                }
                catch (Exception ex)
                {
                    if (chbDebugInfoOn.Checked)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        // Замена списка прошивок при изменении типа контроллера
        private void cbContollers_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] firmware_standart = { "Демо", "Звук", "Моторы", "Сервопривод", "Сонар", "Кнопка", "ИК приёмник", "Датчик линии", "Датчик цвета", "Bluetooth" };
            string[] firmware_classic = { "Демо", "Звук", "Моторы", "Сервопривод" }; //  todo
            string[] firmware_mini = { "Демо", "Звук", "Моторы", "Сервопривод", "RGB", "Кнопка", "Освещение", "ИК приёмник", "ИК передатчик", "Сонар", "Датчик линии", "Концевик", "RGB модуль", "Гироскоп" };
            string[] firmware_hyper = { "Демо", "Звук", "Моторы", "Сервопривод", "Мигалка", "Кнопки" };

            cbFirmware.Items.Clear();

            if (cbContollers.SelectedIndex == 0) // Стандартный
            {
                cbFirmware.Items.AddRange(firmware_standart);
                cbComPortBaudrate.SelectedIndex = 0; // 9600
            }
            else if (cbContollers.SelectedIndex == 1) // Классический
            {
                cbFirmware.Items.AddRange(firmware_classic);
                cbComPortBaudrate.SelectedIndex = 0; // 9600
            }
            else if (cbContollers.SelectedIndex == 2) // Мини
            {
                cbFirmware.Items.AddRange(firmware_mini);
                cbComPortBaudrate.SelectedIndex = 0; // 9600
            }
            else if (cbContollers.SelectedIndex == 3) // Гипер
            {
                cbFirmware.Items.AddRange(firmware_hyper);
                cbComPortBaudrate.SelectedIndex = 1; // 115200
            }

            cbFirmware.SelectedIndex = 0;
        }

        // Запуск / закрытие порта кнопкой терминала
        private void btnStartStopTerminal_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();

                if (!serialPort.IsOpen)
                {
                    btnStartStopTerminal.Text = "Открыть";
                }
            }
            else
            {
                try
                {
                    serialPort.PortName = cbComPortsTerminal.Text;
                    serialPort.BaudRate = Convert.ToInt32(cbComPortBaudrate.Text);
                    serialPort.Open();

                    if (serialPort.IsOpen)
                    {
                        btnStartStopTerminal.Text = "Закрыть";
                    }
                }
                catch
                {
                    if (serialPort.IsOpen)
                    {
                        serialPort.Close();

                        if (!serialPort.IsOpen)
                        {
                            btnStartStopTerminal.Text = "Открыть";
                        }
                    }
                    else
                    {
                        btnStartStopTerminal.Text = "Закрыть";
                    }
                }
            }
        }

        // Закрытие порта при смене вкладки
        private void tpControllers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();

                if (!serialPort.IsOpen)
                {
                    btnStartStopTerminal.Text = "Открыть";
                }
            }
        }

        private void cbComPortBaudrate_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnStartStopTerminal.PerformClick();
        }

        private void cbProgrammers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProgrammers.SelectedIndex != 0)
            {
                chbUseATmega328pb.Enabled = false;
            }
            else
            {
                chbUseATmega328pb.Enabled = true;
            }
        }
    }
}
