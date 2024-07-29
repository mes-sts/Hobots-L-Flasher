namespace Hobots_L_Flasher
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tpControllers = new MetroFramework.Controls.MetroTabControl();
            this.tabControllers = new MetroFramework.Controls.MetroTabPage();
            this.pBootloader = new MetroFramework.Controls.MetroPanel();
            this.chbUseATmega328pb = new MetroFramework.Controls.MetroCheckBox();
            this.btnDownloadBootloaderProgrammer = new MetroFramework.Controls.MetroButton();
            this.cbProgrammers = new MetroFramework.Controls.MetroComboBox();
            this.lblProgrammersDisc = new MetroFramework.Controls.MetroLabel();
            this.pFirmware = new MetroFramework.Controls.MetroPanel();
            this.lblContollerTypeDisc = new MetroFramework.Controls.MetroLabel();
            this.cbContollers = new MetroFramework.Controls.MetroComboBox();
            this.lblFirmwarePathDisc = new MetroFramework.Controls.MetroLabel();
            this.btnDownloadFirmwarePort = new MetroFramework.Controls.MetroButton();
            this.lblFirmwareDisc = new MetroFramework.Controls.MetroLabel();
            this.tbFirmwarePath = new MetroFramework.Controls.MetroTextBox();
            this.lblComPortDisc = new MetroFramework.Controls.MetroLabel();
            this.cbFirmware = new MetroFramework.Controls.MetroComboBox();
            this.cbComPorts = new MetroFramework.Controls.MetroComboBox();
            this.tabTerminal = new MetroFramework.Controls.MetroTabPage();
            this.cbComPortBaudrate = new MetroFramework.Controls.MetroComboBox();
            this.tbTerminal = new MetroFramework.Controls.MetroTextBox();
            this.btnCleanTerminal = new MetroFramework.Controls.MetroButton();
            this.btnStartStopTerminal = new MetroFramework.Controls.MetroButton();
            this.cbComPortsTerminal = new MetroFramework.Controls.MetroComboBox();
            this.tabSettings = new MetroFramework.Controls.MetroTabPage();
            this.pOther = new MetroFramework.Controls.MetroPanel();
            this.chbDebugInfoOn = new MetroFramework.Controls.MetroCheckBox();
            this.clHelp = new MetroFramework.Controls.MetroLink();
            this.pDriver = new MetroFramework.Controls.MetroPanel();
            this.lblDriverTypeDisc = new MetroFramework.Controls.MetroLabel();
            this.btnInstallDriver = new MetroFramework.Controls.MetroButton();
            this.cbDriverType = new MetroFramework.Controls.MetroComboBox();
            this.lblCopyrightAndVersionVlalue = new MetroFramework.Controls.MetroLabel();
            this.lblDownloadStatusDisc = new MetroFramework.Controls.MetroLabel();
            this.lblDownloadStatus = new MetroFramework.Controls.MetroLabel();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.timerResetStatus = new System.Windows.Forms.Timer(this.components);
            this.tpControllers.SuspendLayout();
            this.tabControllers.SuspendLayout();
            this.pBootloader.SuspendLayout();
            this.pFirmware.SuspendLayout();
            this.tabTerminal.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.pOther.SuspendLayout();
            this.pDriver.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpControllers
            // 
            this.tpControllers.Controls.Add(this.tabControllers);
            this.tpControllers.Controls.Add(this.tabTerminal);
            this.tpControllers.Controls.Add(this.tabSettings);
            this.tpControllers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpControllers.Location = new System.Drawing.Point(20, 60);
            this.tpControllers.Name = "tpControllers";
            this.tpControllers.SelectedIndex = 0;
            this.tpControllers.Size = new System.Drawing.Size(346, 348);
            this.tpControllers.TabIndex = 0;
            this.tpControllers.UseSelectable = true;
            this.tpControllers.SelectedIndexChanged += new System.EventHandler(this.tpControllers_SelectedIndexChanged);
            // 
            // tabControllers
            // 
            this.tabControllers.Controls.Add(this.pBootloader);
            this.tabControllers.Controls.Add(this.pFirmware);
            this.tabControllers.HorizontalScrollbarBarColor = true;
            this.tabControllers.HorizontalScrollbarHighlightOnWheel = false;
            this.tabControllers.HorizontalScrollbarSize = 10;
            this.tabControllers.Location = new System.Drawing.Point(4, 38);
            this.tabControllers.Name = "tabControllers";
            this.tabControllers.Size = new System.Drawing.Size(338, 306);
            this.tabControllers.TabIndex = 0;
            this.tabControllers.Text = "Котроллеры";
            this.tabControllers.VerticalScrollbarBarColor = true;
            this.tabControllers.VerticalScrollbarHighlightOnWheel = false;
            this.tabControllers.VerticalScrollbarSize = 10;
            // 
            // pBootloader
            // 
            this.pBootloader.Controls.Add(this.chbUseATmega328pb);
            this.pBootloader.Controls.Add(this.btnDownloadBootloaderProgrammer);
            this.pBootloader.Controls.Add(this.cbProgrammers);
            this.pBootloader.Controls.Add(this.lblProgrammersDisc);
            this.pBootloader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pBootloader.HorizontalScrollbarBarColor = true;
            this.pBootloader.HorizontalScrollbarHighlightOnWheel = false;
            this.pBootloader.HorizontalScrollbarSize = 10;
            this.pBootloader.Location = new System.Drawing.Point(0, 193);
            this.pBootloader.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.pBootloader.Name = "pBootloader";
            this.pBootloader.Size = new System.Drawing.Size(338, 110);
            this.pBootloader.TabIndex = 66;
            this.pBootloader.VerticalScrollbarBarColor = true;
            this.pBootloader.VerticalScrollbarHighlightOnWheel = false;
            this.pBootloader.VerticalScrollbarSize = 10;
            // 
            // chbUseATmega328pb
            // 
            this.chbUseATmega328pb.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbUseATmega328pb.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chbUseATmega328pb.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.chbUseATmega328pb.Location = new System.Drawing.Point(5, 47);
            this.chbUseATmega328pb.Name = "chbUseATmega328pb";
            this.chbUseATmega328pb.Size = new System.Drawing.Size(251, 24);
            this.chbUseATmega328pb.TabIndex = 69;
            this.chbUseATmega328pb.Text = "Используется ATmega328PB";
            this.chbUseATmega328pb.UseSelectable = true;
            // 
            // btnDownloadBootloaderProgrammer
            // 
            this.btnDownloadBootloaderProgrammer.AutoSize = true;
            this.btnDownloadBootloaderProgrammer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDownloadBootloaderProgrammer.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnDownloadBootloaderProgrammer.Location = new System.Drawing.Point(0, 81);
            this.btnDownloadBootloaderProgrammer.Margin = new System.Windows.Forms.Padding(5);
            this.btnDownloadBootloaderProgrammer.Name = "btnDownloadBootloaderProgrammer";
            this.btnDownloadBootloaderProgrammer.Size = new System.Drawing.Size(338, 29);
            this.btnDownloadBootloaderProgrammer.TabIndex = 68;
            this.btnDownloadBootloaderProgrammer.Text = "Записать загрузчик через программатор";
            this.btnDownloadBootloaderProgrammer.UseSelectable = true;
            this.btnDownloadBootloaderProgrammer.Click += new System.EventHandler(this.btnDownloadBootloaderProgrammer_Click);
            // 
            // cbProgrammers
            // 
            this.cbProgrammers.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
            this.cbProgrammers.FormattingEnabled = true;
            this.cbProgrammers.ItemHeight = 23;
            this.cbProgrammers.Location = new System.Drawing.Point(206, 10);
            this.cbProgrammers.Margin = new System.Windows.Forms.Padding(5);
            this.cbProgrammers.Name = "cbProgrammers";
            this.cbProgrammers.PromptText = "Программатор";
            this.cbProgrammers.Size = new System.Drawing.Size(121, 29);
            this.cbProgrammers.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbProgrammers.TabIndex = 67;
            this.cbProgrammers.UseSelectable = true;
            // 
            // lblProgrammersDisc
            // 
            this.lblProgrammersDisc.Location = new System.Drawing.Point(5, 10);
            this.lblProgrammersDisc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblProgrammersDisc.Name = "lblProgrammersDisc";
            this.lblProgrammersDisc.Size = new System.Drawing.Size(191, 29);
            this.lblProgrammersDisc.TabIndex = 66;
            this.lblProgrammersDisc.Text = "Тип программатора";
            this.lblProgrammersDisc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pFirmware
            // 
            this.pFirmware.Controls.Add(this.lblContollerTypeDisc);
            this.pFirmware.Controls.Add(this.cbContollers);
            this.pFirmware.Controls.Add(this.lblFirmwarePathDisc);
            this.pFirmware.Controls.Add(this.btnDownloadFirmwarePort);
            this.pFirmware.Controls.Add(this.lblFirmwareDisc);
            this.pFirmware.Controls.Add(this.tbFirmwarePath);
            this.pFirmware.Controls.Add(this.lblComPortDisc);
            this.pFirmware.Controls.Add(this.cbFirmware);
            this.pFirmware.Controls.Add(this.cbComPorts);
            this.pFirmware.Dock = System.Windows.Forms.DockStyle.Top;
            this.pFirmware.HorizontalScrollbarBarColor = true;
            this.pFirmware.HorizontalScrollbarHighlightOnWheel = false;
            this.pFirmware.HorizontalScrollbarSize = 10;
            this.pFirmware.Location = new System.Drawing.Point(0, 0);
            this.pFirmware.Name = "pFirmware";
            this.pFirmware.Size = new System.Drawing.Size(338, 193);
            this.pFirmware.TabIndex = 65;
            this.pFirmware.VerticalScrollbarBarColor = true;
            this.pFirmware.VerticalScrollbarHighlightOnWheel = false;
            this.pFirmware.VerticalScrollbarSize = 10;
            // 
            // lblContollerTypeDisc
            // 
            this.lblContollerTypeDisc.Location = new System.Drawing.Point(5, 5);
            this.lblContollerTypeDisc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblContollerTypeDisc.Name = "lblContollerTypeDisc";
            this.lblContollerTypeDisc.Size = new System.Drawing.Size(191, 29);
            this.lblContollerTypeDisc.TabIndex = 69;
            this.lblContollerTypeDisc.Text = "Варинты типов котроллеров";
            this.lblContollerTypeDisc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbContollers
            // 
            this.cbContollers.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
            this.cbContollers.FormattingEnabled = true;
            this.cbContollers.ItemHeight = 23;
            this.cbContollers.Items.AddRange(new object[] {
            "Стандартный",
            "Классический",
            "Мини",
            "Гипер",
            "Ультра",
            "Мечта"});
            this.cbContollers.Location = new System.Drawing.Point(206, 5);
            this.cbContollers.Margin = new System.Windows.Forms.Padding(5);
            this.cbContollers.Name = "cbContollers";
            this.cbContollers.PromptText = "Контроллер";
            this.cbContollers.Size = new System.Drawing.Size(121, 29);
            this.cbContollers.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbContollers.TabIndex = 68;
            this.cbContollers.Tag = "";
            this.cbContollers.UseSelectable = true;
            this.cbContollers.SelectedIndexChanged += new System.EventHandler(this.cbContollers_SelectedIndexChanged);
            // 
            // lblFirmwarePathDisc
            // 
            this.lblFirmwarePathDisc.Location = new System.Drawing.Point(5, 122);
            this.lblFirmwarePathDisc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFirmwarePathDisc.Name = "lblFirmwarePathDisc";
            this.lblFirmwarePathDisc.Size = new System.Drawing.Size(191, 29);
            this.lblFirmwarePathDisc.TabIndex = 66;
            this.lblFirmwarePathDisc.Text = "Выбор прошивки из файла";
            this.lblFirmwarePathDisc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDownloadFirmwarePort
            // 
            this.btnDownloadFirmwarePort.AutoSize = true;
            this.btnDownloadFirmwarePort.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDownloadFirmwarePort.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnDownloadFirmwarePort.Location = new System.Drawing.Point(0, 164);
            this.btnDownloadFirmwarePort.Margin = new System.Windows.Forms.Padding(5);
            this.btnDownloadFirmwarePort.Name = "btnDownloadFirmwarePort";
            this.btnDownloadFirmwarePort.Size = new System.Drawing.Size(338, 29);
            this.btnDownloadFirmwarePort.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnDownloadFirmwarePort.TabIndex = 60;
            this.btnDownloadFirmwarePort.Text = "Записать прошивку через последовательный порт";
            this.btnDownloadFirmwarePort.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnDownloadFirmwarePort.UseSelectable = true;
            this.btnDownloadFirmwarePort.Click += new System.EventHandler(this.btnDownloadFirmwarePort_Click);
            // 
            // lblFirmwareDisc
            // 
            this.lblFirmwareDisc.Location = new System.Drawing.Point(5, 83);
            this.lblFirmwareDisc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFirmwareDisc.Name = "lblFirmwareDisc";
            this.lblFirmwareDisc.Size = new System.Drawing.Size(191, 29);
            this.lblFirmwareDisc.TabIndex = 67;
            this.lblFirmwareDisc.Text = "Варианты готовых прошивок";
            this.lblFirmwareDisc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbFirmwarePath
            // 
            // 
            // 
            // 
            this.tbFirmwarePath.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.tbFirmwarePath.CustomButton.Location = new System.Drawing.Point(93, 1);
            this.tbFirmwarePath.CustomButton.Name = "";
            this.tbFirmwarePath.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tbFirmwarePath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbFirmwarePath.CustomButton.TabIndex = 1;
            this.tbFirmwarePath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbFirmwarePath.CustomButton.UseSelectable = true;
            this.tbFirmwarePath.DisplayIcon = true;
            this.tbFirmwarePath.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.tbFirmwarePath.Lines = new string[0];
            this.tbFirmwarePath.Location = new System.Drawing.Point(206, 122);
            this.tbFirmwarePath.Margin = new System.Windows.Forms.Padding(5);
            this.tbFirmwarePath.MaxLength = 32767;
            this.tbFirmwarePath.Name = "tbFirmwarePath";
            this.tbFirmwarePath.PasswordChar = '\0';
            this.tbFirmwarePath.PromptText = "Путь";
            this.tbFirmwarePath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbFirmwarePath.SelectedText = "";
            this.tbFirmwarePath.SelectionLength = 0;
            this.tbFirmwarePath.SelectionStart = 0;
            this.tbFirmwarePath.ShortcutsEnabled = true;
            this.tbFirmwarePath.ShowButton = true;
            this.tbFirmwarePath.ShowClearButton = true;
            this.tbFirmwarePath.Size = new System.Drawing.Size(121, 29);
            this.tbFirmwarePath.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbFirmwarePath.TabIndex = 59;
            this.tbFirmwarePath.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbFirmwarePath.UseSelectable = true;
            this.tbFirmwarePath.WaterMark = "Путь";
            this.tbFirmwarePath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbFirmwarePath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbFirmwarePath.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.tbFirmwarePath_ButtonClick);
            // 
            // lblComPortDisc
            // 
            this.lblComPortDisc.Location = new System.Drawing.Point(5, 44);
            this.lblComPortDisc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblComPortDisc.Name = "lblComPortDisc";
            this.lblComPortDisc.Size = new System.Drawing.Size(191, 29);
            this.lblComPortDisc.TabIndex = 65;
            this.lblComPortDisc.Text = "Порт для записи прошивки";
            this.lblComPortDisc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbFirmware
            // 
            this.cbFirmware.DropDownHeight = 150;
            this.cbFirmware.DropDownWidth = 121;
            this.cbFirmware.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
            this.cbFirmware.FormattingEnabled = true;
            this.cbFirmware.IntegralHeight = false;
            this.cbFirmware.ItemHeight = 23;
            this.cbFirmware.Location = new System.Drawing.Point(206, 83);
            this.cbFirmware.Margin = new System.Windows.Forms.Padding(5);
            this.cbFirmware.Name = "cbFirmware";
            this.cbFirmware.PromptText = "Прошивка";
            this.cbFirmware.Size = new System.Drawing.Size(121, 29);
            this.cbFirmware.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbFirmware.TabIndex = 56;
            this.cbFirmware.UseSelectable = true;
            // 
            // cbComPorts
            // 
            this.cbComPorts.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
            this.cbComPorts.FormattingEnabled = true;
            this.cbComPorts.ItemHeight = 23;
            this.cbComPorts.Location = new System.Drawing.Point(206, 44);
            this.cbComPorts.Margin = new System.Windows.Forms.Padding(5);
            this.cbComPorts.Name = "cbComPorts";
            this.cbComPorts.PromptText = "Порт";
            this.cbComPorts.Size = new System.Drawing.Size(121, 29);
            this.cbComPorts.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbComPorts.TabIndex = 54;
            this.cbComPorts.UseSelectable = true;
            // 
            // tabTerminal
            // 
            this.tabTerminal.Controls.Add(this.cbComPortBaudrate);
            this.tabTerminal.Controls.Add(this.tbTerminal);
            this.tabTerminal.Controls.Add(this.btnCleanTerminal);
            this.tabTerminal.Controls.Add(this.btnStartStopTerminal);
            this.tabTerminal.Controls.Add(this.cbComPortsTerminal);
            this.tabTerminal.HorizontalScrollbarBarColor = true;
            this.tabTerminal.HorizontalScrollbarHighlightOnWheel = false;
            this.tabTerminal.HorizontalScrollbarSize = 10;
            this.tabTerminal.Location = new System.Drawing.Point(4, 38);
            this.tabTerminal.Name = "tabTerminal";
            this.tabTerminal.Size = new System.Drawing.Size(338, 306);
            this.tabTerminal.TabIndex = 3;
            this.tabTerminal.Text = "Терминал";
            this.tabTerminal.VerticalScrollbarBarColor = true;
            this.tabTerminal.VerticalScrollbarHighlightOnWheel = false;
            this.tabTerminal.VerticalScrollbarSize = 10;
            // 
            // cbComPortBaudrate
            // 
            this.cbComPortBaudrate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbComPortBaudrate.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
            this.cbComPortBaudrate.FormattingEnabled = true;
            this.cbComPortBaudrate.ItemHeight = 23;
            this.cbComPortBaudrate.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.cbComPortBaudrate.Location = new System.Drawing.Point(100, 276);
            this.cbComPortBaudrate.Margin = new System.Windows.Forms.Padding(5);
            this.cbComPortBaudrate.Name = "cbComPortBaudrate";
            this.cbComPortBaudrate.PromptText = "Скорость";
            this.cbComPortBaudrate.Size = new System.Drawing.Size(80, 29);
            this.cbComPortBaudrate.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbComPortBaudrate.TabIndex = 64;
            this.cbComPortBaudrate.UseSelectable = true;
            this.cbComPortBaudrate.SelectedIndexChanged += new System.EventHandler(this.cbComPortBaudrate_SelectedIndexChanged);
            // 
            // tbTerminal
            // 
            // 
            // 
            // 
            this.tbTerminal.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.tbTerminal.CustomButton.Location = new System.Drawing.Point(74, 2);
            this.tbTerminal.CustomButton.Name = "";
            this.tbTerminal.CustomButton.Size = new System.Drawing.Size(261, 261);
            this.tbTerminal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbTerminal.CustomButton.TabIndex = 1;
            this.tbTerminal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbTerminal.CustomButton.UseSelectable = true;
            this.tbTerminal.CustomButton.Visible = false;
            this.tbTerminal.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbTerminal.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.tbTerminal.Lines = new string[0];
            this.tbTerminal.Location = new System.Drawing.Point(0, 0);
            this.tbTerminal.Margin = new System.Windows.Forms.Padding(5);
            this.tbTerminal.MaxLength = 32767;
            this.tbTerminal.Multiline = true;
            this.tbTerminal.Name = "tbTerminal";
            this.tbTerminal.PasswordChar = '\0';
            this.tbTerminal.ReadOnly = true;
            this.tbTerminal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbTerminal.SelectedText = "";
            this.tbTerminal.SelectionLength = 0;
            this.tbTerminal.SelectionStart = 0;
            this.tbTerminal.ShortcutsEnabled = true;
            this.tbTerminal.Size = new System.Drawing.Size(338, 266);
            this.tbTerminal.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbTerminal.TabIndex = 63;
            this.tbTerminal.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbTerminal.UseSelectable = true;
            this.tbTerminal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbTerminal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnCleanTerminal
            // 
            this.btnCleanTerminal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCleanTerminal.AutoSize = true;
            this.btnCleanTerminal.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnCleanTerminal.Location = new System.Drawing.Point(268, 276);
            this.btnCleanTerminal.Margin = new System.Windows.Forms.Padding(5);
            this.btnCleanTerminal.Name = "btnCleanTerminal";
            this.btnCleanTerminal.Size = new System.Drawing.Size(70, 29);
            this.btnCleanTerminal.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnCleanTerminal.TabIndex = 62;
            this.btnCleanTerminal.Text = "Очистить";
            this.btnCleanTerminal.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnCleanTerminal.UseSelectable = true;
            this.btnCleanTerminal.Click += new System.EventHandler(this.btnCleanTerminal_Click);
            // 
            // btnStartStopTerminal
            // 
            this.btnStartStopTerminal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStartStopTerminal.AutoSize = true;
            this.btnStartStopTerminal.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnStartStopTerminal.Location = new System.Drawing.Point(190, 276);
            this.btnStartStopTerminal.Margin = new System.Windows.Forms.Padding(5);
            this.btnStartStopTerminal.Name = "btnStartStopTerminal";
            this.btnStartStopTerminal.Size = new System.Drawing.Size(65, 29);
            this.btnStartStopTerminal.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnStartStopTerminal.TabIndex = 61;
            this.btnStartStopTerminal.Text = "Открыть";
            this.btnStartStopTerminal.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnStartStopTerminal.UseSelectable = true;
            this.btnStartStopTerminal.Click += new System.EventHandler(this.btnStartStopTerminal_Click);
            // 
            // cbComPortsTerminal
            // 
            this.cbComPortsTerminal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbComPortsTerminal.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
            this.cbComPortsTerminal.FormattingEnabled = true;
            this.cbComPortsTerminal.ItemHeight = 23;
            this.cbComPortsTerminal.Location = new System.Drawing.Point(0, 276);
            this.cbComPortsTerminal.Margin = new System.Windows.Forms.Padding(5);
            this.cbComPortsTerminal.Name = "cbComPortsTerminal";
            this.cbComPortsTerminal.PromptText = "Порт";
            this.cbComPortsTerminal.Size = new System.Drawing.Size(90, 29);
            this.cbComPortsTerminal.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbComPortsTerminal.TabIndex = 55;
            this.cbComPortsTerminal.UseSelectable = true;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.pOther);
            this.tabSettings.Controls.Add(this.pDriver);
            this.tabSettings.HorizontalScrollbarBarColor = true;
            this.tabSettings.HorizontalScrollbarHighlightOnWheel = false;
            this.tabSettings.HorizontalScrollbarSize = 10;
            this.tabSettings.Location = new System.Drawing.Point(4, 38);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(338, 306);
            this.tabSettings.TabIndex = 1;
            this.tabSettings.Text = "Настройки";
            this.tabSettings.VerticalScrollbarBarColor = true;
            this.tabSettings.VerticalScrollbarHighlightOnWheel = false;
            this.tabSettings.VerticalScrollbarSize = 10;
            // 
            // pOther
            // 
            this.pOther.Controls.Add(this.chbDebugInfoOn);
            this.pOther.Controls.Add(this.clHelp);
            this.pOther.Dock = System.Windows.Forms.DockStyle.Top;
            this.pOther.HorizontalScrollbarBarColor = true;
            this.pOther.HorizontalScrollbarHighlightOnWheel = false;
            this.pOther.HorizontalScrollbarSize = 10;
            this.pOther.Location = new System.Drawing.Point(0, 75);
            this.pOther.Name = "pOther";
            this.pOther.Padding = new System.Windows.Forms.Padding(3);
            this.pOther.Size = new System.Drawing.Size(338, 57);
            this.pOther.TabIndex = 75;
            this.pOther.VerticalScrollbarBarColor = true;
            this.pOther.VerticalScrollbarHighlightOnWheel = false;
            this.pOther.VerticalScrollbarSize = 10;
            // 
            // chbDebugInfoOn
            // 
            this.chbDebugInfoOn.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbDebugInfoOn.Dock = System.Windows.Forms.DockStyle.Top;
            this.chbDebugInfoOn.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chbDebugInfoOn.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.chbDebugInfoOn.Location = new System.Drawing.Point(3, 3);
            this.chbDebugInfoOn.Name = "chbDebugInfoOn";
            this.chbDebugInfoOn.Size = new System.Drawing.Size(332, 24);
            this.chbDebugInfoOn.TabIndex = 74;
            this.chbDebugInfoOn.Text = "Включить вывод отладочной информации";
            this.chbDebugInfoOn.UseSelectable = true;
            // 
            // clHelp
            // 
            this.clHelp.Location = new System.Drawing.Point(3, 32);
            this.clHelp.Name = "clHelp";
            this.clHelp.Size = new System.Drawing.Size(60, 19);
            this.clHelp.TabIndex = 72;
            this.clHelp.Text = "Справка";
            this.clHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clHelp.UseSelectable = true;
            this.clHelp.Click += new System.EventHandler(this.clHelp_Click);
            // 
            // pDriver
            // 
            this.pDriver.Controls.Add(this.lblDriverTypeDisc);
            this.pDriver.Controls.Add(this.btnInstallDriver);
            this.pDriver.Controls.Add(this.cbDriverType);
            this.pDriver.Dock = System.Windows.Forms.DockStyle.Top;
            this.pDriver.HorizontalScrollbarBarColor = true;
            this.pDriver.HorizontalScrollbarHighlightOnWheel = false;
            this.pDriver.HorizontalScrollbarSize = 10;
            this.pDriver.Location = new System.Drawing.Point(0, 0);
            this.pDriver.Name = "pDriver";
            this.pDriver.Size = new System.Drawing.Size(338, 75);
            this.pDriver.TabIndex = 73;
            this.pDriver.VerticalScrollbarBarColor = true;
            this.pDriver.VerticalScrollbarHighlightOnWheel = false;
            this.pDriver.VerticalScrollbarSize = 10;
            // 
            // lblDriverTypeDisc
            // 
            this.lblDriverTypeDisc.Location = new System.Drawing.Point(3, 5);
            this.lblDriverTypeDisc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDriverTypeDisc.Name = "lblDriverTypeDisc";
            this.lblDriverTypeDisc.Size = new System.Drawing.Size(191, 29);
            this.lblDriverTypeDisc.TabIndex = 71;
            this.lblDriverTypeDisc.Text = "Варинты типов драйверов";
            this.lblDriverTypeDisc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnInstallDriver
            // 
            this.btnInstallDriver.AutoSize = true;
            this.btnInstallDriver.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnInstallDriver.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnInstallDriver.Location = new System.Drawing.Point(0, 46);
            this.btnInstallDriver.Margin = new System.Windows.Forms.Padding(5);
            this.btnInstallDriver.Name = "btnInstallDriver";
            this.btnInstallDriver.Size = new System.Drawing.Size(338, 29);
            this.btnInstallDriver.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnInstallDriver.TabIndex = 61;
            this.btnInstallDriver.Text = "Установить драйвер";
            this.btnInstallDriver.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnInstallDriver.UseSelectable = true;
            this.btnInstallDriver.Click += new System.EventHandler(this.btnInstallDriver_Click);
            // 
            // cbDriverType
            // 
            this.cbDriverType.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
            this.cbDriverType.FormattingEnabled = true;
            this.cbDriverType.ItemHeight = 23;
            this.cbDriverType.Items.AddRange(new object[] {
            "USBASP",
            "STLINK",
            "CH340",
            "FT232",
            "CP2102"});
            this.cbDriverType.Location = new System.Drawing.Point(206, 5);
            this.cbDriverType.Margin = new System.Windows.Forms.Padding(5);
            this.cbDriverType.Name = "cbDriverType";
            this.cbDriverType.PromptText = "Драйвер";
            this.cbDriverType.Size = new System.Drawing.Size(121, 29);
            this.cbDriverType.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbDriverType.TabIndex = 70;
            this.cbDriverType.UseSelectable = true;
            // 
            // lblCopyrightAndVersionVlalue
            // 
            this.lblCopyrightAndVersionVlalue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCopyrightAndVersionVlalue.AutoSize = true;
            this.lblCopyrightAndVersionVlalue.Location = new System.Drawing.Point(3, 407);
            this.lblCopyrightAndVersionVlalue.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblCopyrightAndVersionVlalue.Name = "lblCopyrightAndVersionVlalue";
            this.lblCopyrightAndVersionVlalue.Size = new System.Drawing.Size(162, 19);
            this.lblCopyrightAndVersionVlalue.TabIndex = 11;
            this.lblCopyrightAndVersionVlalue.Text = "MES GROUP. версия ПО: ";
            this.lblCopyrightAndVersionVlalue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDownloadStatusDisc
            // 
            this.lblDownloadStatusDisc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDownloadStatusDisc.AutoSize = true;
            this.lblDownloadStatusDisc.Location = new System.Drawing.Point(230, 407);
            this.lblDownloadStatusDisc.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.lblDownloadStatusDisc.Name = "lblDownloadStatusDisc";
            this.lblDownloadStatusDisc.Size = new System.Drawing.Size(50, 19);
            this.lblDownloadStatusDisc.TabIndex = 13;
            this.lblDownloadStatusDisc.Text = "Статус:";
            this.lblDownloadStatusDisc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDownloadStatus
            // 
            this.lblDownloadStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDownloadStatus.AutoSize = true;
            this.lblDownloadStatus.Location = new System.Drawing.Point(280, 407);
            this.lblDownloadStatus.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.lblDownloadStatus.Name = "lblDownloadStatus";
            this.lblDownloadStatus.Size = new System.Drawing.Size(38, 19);
            this.lblDownloadStatus.TabIndex = 14;
            this.lblDownloadStatus.Text = "--/--";
            this.lblDownloadStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDownloadStatus.UseCustomBackColor = true;
            // 
            // serialPort
            // 
            this.serialPort.DtrEnable = true;
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // timerResetStatus
            // 
            this.timerResetStatus.Interval = 2000;
            this.timerResetStatus.Tick += new System.EventHandler(this.timerResetStatus_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 428);
            this.Controls.Add(this.lblDownloadStatus);
            this.Controls.Add(this.lblDownloadStatusDisc);
            this.Controls.Add(this.lblCopyrightAndVersionVlalue);
            this.Controls.Add(this.tpControllers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "Прошивальщик Hobots L";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tpControllers.ResumeLayout(false);
            this.tabControllers.ResumeLayout(false);
            this.pBootloader.ResumeLayout(false);
            this.pBootloader.PerformLayout();
            this.pFirmware.ResumeLayout(false);
            this.pFirmware.PerformLayout();
            this.tabTerminal.ResumeLayout(false);
            this.tabTerminal.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.pOther.ResumeLayout(false);
            this.pDriver.ResumeLayout(false);
            this.pDriver.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tpControllers;
        private MetroFramework.Controls.MetroTabPage tabControllers;
        private MetroFramework.Controls.MetroTabPage tabSettings;
        private MetroFramework.Controls.MetroLabel lblCopyrightAndVersionVlalue;
        private MetroFramework.Controls.MetroButton btnDownloadFirmwarePort;
        private MetroFramework.Controls.MetroTextBox tbFirmwarePath;
        private MetroFramework.Controls.MetroComboBox cbFirmware;
        private MetroFramework.Controls.MetroComboBox cbComPorts;
        private MetroFramework.Controls.MetroPanel pFirmware;
        private MetroFramework.Controls.MetroLabel lblFirmwarePathDisc;
        private MetroFramework.Controls.MetroLabel lblFirmwareDisc;
        private MetroFramework.Controls.MetroLabel lblComPortDisc;
        private MetroFramework.Controls.MetroPanel pBootloader;
        private MetroFramework.Controls.MetroLabel lblProgrammersDisc;
        private MetroFramework.Controls.MetroButton btnDownloadBootloaderProgrammer;
        private MetroFramework.Controls.MetroComboBox cbProgrammers;
        private MetroFramework.Controls.MetroLabel lblDownloadStatusDisc;
        private MetroFramework.Controls.MetroLabel lblDownloadStatus;
        private MetroFramework.Controls.MetroLabel lblContollerTypeDisc;
        private MetroFramework.Controls.MetroComboBox cbContollers;
        private MetroFramework.Controls.MetroButton btnInstallDriver;
        private MetroFramework.Controls.MetroLabel lblDriverTypeDisc;
        private MetroFramework.Controls.MetroComboBox cbDriverType;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Timer timerResetStatus;
        private MetroFramework.Controls.MetroTabPage tabTerminal;
        private MetroFramework.Controls.MetroLink clHelp;
        private MetroFramework.Controls.MetroPanel pDriver;
        private MetroFramework.Controls.MetroButton btnStartStopTerminal;
        private MetroFramework.Controls.MetroComboBox cbComPortsTerminal;
        private MetroFramework.Controls.MetroButton btnCleanTerminal;
        private MetroFramework.Controls.MetroTextBox tbTerminal;
        private MetroFramework.Controls.MetroComboBox cbComPortBaudrate;
        private MetroFramework.Controls.MetroCheckBox chbUseATmega328pb;
        private MetroFramework.Controls.MetroCheckBox chbDebugInfoOn;
        private MetroFramework.Controls.MetroPanel pOther;
    }
}

