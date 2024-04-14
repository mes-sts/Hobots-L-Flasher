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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tpControllers = new MetroFramework.Controls.MetroTabControl();
            this.tabControllers = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnDownloadBootloaderStandart = new MetroFramework.Controls.MetroButton();
            this.cbProgrammersStandart = new MetroFramework.Controls.MetroComboBox();
            this.lblProgrammersDisc = new MetroFramework.Controls.MetroLabel();
            this.pComPortStandart = new MetroFramework.Controls.MetroPanel();
            this.lblFirmwarePathDisc = new MetroFramework.Controls.MetroLabel();
            this.btnDownloadFirmwareStandart = new MetroFramework.Controls.MetroButton();
            this.lblFirmwareDisc = new MetroFramework.Controls.MetroLabel();
            this.tbFirmwarePath = new MetroFramework.Controls.MetroTextBox();
            this.lblComPortDisc = new MetroFramework.Controls.MetroLabel();
            this.cbFirmware = new MetroFramework.Controls.MetroComboBox();
            this.cbComPort = new MetroFramework.Controls.MetroComboBox();
            this.tabSettings = new MetroFramework.Controls.MetroTabPage();
            this.tabExtended = new MetroFramework.Controls.MetroTabPage();
            this.lblCopyrightAndVersionVlalue = new MetroFramework.Controls.MetroLabel();
            this.lblDownloadStatusDisc = new MetroFramework.Controls.MetroLabel();
            this.lblDownloadStatus = new MetroFramework.Controls.MetroLabel();
            this.lblContollerTypeDisc = new MetroFramework.Controls.MetroLabel();
            this.cbContollerType = new MetroFramework.Controls.MetroComboBox();
            this.clHelp = new MetroFramework.Controls.MetroLink();
            this.btnInstallDriver = new MetroFramework.Controls.MetroButton();
            this.lblDriverTypeDisc = new MetroFramework.Controls.MetroLabel();
            this.cbDriverType = new MetroFramework.Controls.MetroComboBox();
            this.tpControllers.SuspendLayout();
            this.tabControllers.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.pComPortStandart.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.tabExtended.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpControllers
            // 
            this.tpControllers.Controls.Add(this.tabControllers);
            this.tpControllers.Controls.Add(this.tabSettings);
            this.tpControllers.Controls.Add(this.tabExtended);
            this.tpControllers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpControllers.Location = new System.Drawing.Point(20, 60);
            this.tpControllers.Name = "tpControllers";
            this.tpControllers.SelectedIndex = 0;
            this.tpControllers.Size = new System.Drawing.Size(346, 318);
            this.tpControllers.TabIndex = 0;
            this.tpControllers.UseSelectable = true;
            // 
            // tabControllers
            // 
            this.tabControllers.Controls.Add(this.metroPanel1);
            this.tabControllers.Controls.Add(this.pComPortStandart);
            this.tabControllers.HorizontalScrollbarBarColor = true;
            this.tabControllers.HorizontalScrollbarHighlightOnWheel = false;
            this.tabControllers.HorizontalScrollbarSize = 10;
            this.tabControllers.Location = new System.Drawing.Point(4, 38);
            this.tabControllers.Name = "tabControllers";
            this.tabControllers.Size = new System.Drawing.Size(338, 276);
            this.tabControllers.TabIndex = 0;
            this.tabControllers.Text = "Котроллеры";
            this.tabControllers.VerticalScrollbarBarColor = true;
            this.tabControllers.VerticalScrollbarHighlightOnWheel = false;
            this.tabControllers.VerticalScrollbarSize = 10;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnDownloadBootloaderStandart);
            this.metroPanel1.Controls.Add(this.cbProgrammersStandart);
            this.metroPanel1.Controls.Add(this.lblProgrammersDisc);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 193);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(338, 80);
            this.metroPanel1.TabIndex = 66;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnDownloadBootloaderStandart
            // 
            this.btnDownloadBootloaderStandart.AutoSize = true;
            this.btnDownloadBootloaderStandart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDownloadBootloaderStandart.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnDownloadBootloaderStandart.Location = new System.Drawing.Point(0, 51);
            this.btnDownloadBootloaderStandart.Margin = new System.Windows.Forms.Padding(5);
            this.btnDownloadBootloaderStandart.Name = "btnDownloadBootloaderStandart";
            this.btnDownloadBootloaderStandart.Size = new System.Drawing.Size(338, 29);
            this.btnDownloadBootloaderStandart.TabIndex = 68;
            this.btnDownloadBootloaderStandart.Text = "Записать загрузчик через программатор";
            this.btnDownloadBootloaderStandart.UseSelectable = true;
            // 
            // cbProgrammersStandart
            // 
            this.cbProgrammersStandart.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
            this.cbProgrammersStandart.FormattingEnabled = true;
            this.cbProgrammersStandart.ItemHeight = 23;
            this.cbProgrammersStandart.Location = new System.Drawing.Point(206, 10);
            this.cbProgrammersStandart.Margin = new System.Windows.Forms.Padding(5);
            this.cbProgrammersStandart.Name = "cbProgrammersStandart";
            this.cbProgrammersStandart.PromptText = "Программатор";
            this.cbProgrammersStandart.Size = new System.Drawing.Size(121, 29);
            this.cbProgrammersStandart.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbProgrammersStandart.TabIndex = 67;
            this.cbProgrammersStandart.UseSelectable = true;
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
            // pComPortStandart
            // 
            this.pComPortStandart.Controls.Add(this.lblContollerTypeDisc);
            this.pComPortStandart.Controls.Add(this.cbContollerType);
            this.pComPortStandart.Controls.Add(this.lblFirmwarePathDisc);
            this.pComPortStandart.Controls.Add(this.btnDownloadFirmwareStandart);
            this.pComPortStandart.Controls.Add(this.lblFirmwareDisc);
            this.pComPortStandart.Controls.Add(this.tbFirmwarePath);
            this.pComPortStandart.Controls.Add(this.lblComPortDisc);
            this.pComPortStandart.Controls.Add(this.cbFirmware);
            this.pComPortStandart.Controls.Add(this.cbComPort);
            this.pComPortStandart.Dock = System.Windows.Forms.DockStyle.Top;
            this.pComPortStandart.HorizontalScrollbarBarColor = true;
            this.pComPortStandart.HorizontalScrollbarHighlightOnWheel = false;
            this.pComPortStandart.HorizontalScrollbarSize = 10;
            this.pComPortStandart.Location = new System.Drawing.Point(0, 0);
            this.pComPortStandart.Name = "pComPortStandart";
            this.pComPortStandart.Size = new System.Drawing.Size(338, 193);
            this.pComPortStandart.TabIndex = 65;
            this.pComPortStandart.VerticalScrollbarBarColor = true;
            this.pComPortStandart.VerticalScrollbarHighlightOnWheel = false;
            this.pComPortStandart.VerticalScrollbarSize = 10;
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
            // btnDownloadFirmwareStandart
            // 
            this.btnDownloadFirmwareStandart.AutoSize = true;
            this.btnDownloadFirmwareStandart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDownloadFirmwareStandart.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnDownloadFirmwareStandart.Location = new System.Drawing.Point(0, 164);
            this.btnDownloadFirmwareStandart.Margin = new System.Windows.Forms.Padding(5);
            this.btnDownloadFirmwareStandart.Name = "btnDownloadFirmwareStandart";
            this.btnDownloadFirmwareStandart.Size = new System.Drawing.Size(338, 29);
            this.btnDownloadFirmwareStandart.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnDownloadFirmwareStandart.TabIndex = 60;
            this.btnDownloadFirmwareStandart.Text = "Записать прошивку через порт";
            this.btnDownloadFirmwareStandart.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnDownloadFirmwareStandart.UseSelectable = true;
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
            this.tbFirmwarePath.ReadOnly = true;
            this.tbFirmwarePath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbFirmwarePath.SelectedText = "";
            this.tbFirmwarePath.SelectionLength = 0;
            this.tbFirmwarePath.SelectionStart = 0;
            this.tbFirmwarePath.ShortcutsEnabled = true;
            this.tbFirmwarePath.ShowButton = true;
            this.tbFirmwarePath.Size = new System.Drawing.Size(121, 29);
            this.tbFirmwarePath.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbFirmwarePath.TabIndex = 59;
            this.tbFirmwarePath.UseSelectable = true;
            this.tbFirmwarePath.WaterMark = "Путь";
            this.tbFirmwarePath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbFirmwarePath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.cbFirmware.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
            this.cbFirmware.FormattingEnabled = true;
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
            // cbComPort
            // 
            this.cbComPort.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
            this.cbComPort.FormattingEnabled = true;
            this.cbComPort.ItemHeight = 23;
            this.cbComPort.Location = new System.Drawing.Point(206, 44);
            this.cbComPort.Margin = new System.Windows.Forms.Padding(5);
            this.cbComPort.Name = "cbComPort";
            this.cbComPort.PromptText = "Порт";
            this.cbComPort.Size = new System.Drawing.Size(121, 29);
            this.cbComPort.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbComPort.TabIndex = 54;
            this.cbComPort.UseSelectable = true;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.lblDriverTypeDisc);
            this.tabSettings.Controls.Add(this.cbDriverType);
            this.tabSettings.Controls.Add(this.btnInstallDriver);
            this.tabSettings.HorizontalScrollbarBarColor = true;
            this.tabSettings.HorizontalScrollbarHighlightOnWheel = false;
            this.tabSettings.HorizontalScrollbarSize = 10;
            this.tabSettings.Location = new System.Drawing.Point(4, 38);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(338, 276);
            this.tabSettings.TabIndex = 1;
            this.tabSettings.Text = "Настройки";
            this.tabSettings.VerticalScrollbarBarColor = true;
            this.tabSettings.VerticalScrollbarHighlightOnWheel = false;
            this.tabSettings.VerticalScrollbarSize = 10;
            // 
            // tabExtended
            // 
            this.tabExtended.Controls.Add(this.clHelp);
            this.tabExtended.HorizontalScrollbarBarColor = true;
            this.tabExtended.HorizontalScrollbarHighlightOnWheel = false;
            this.tabExtended.HorizontalScrollbarSize = 10;
            this.tabExtended.Location = new System.Drawing.Point(4, 38);
            this.tabExtended.Name = "tabExtended";
            this.tabExtended.Size = new System.Drawing.Size(338, 276);
            this.tabExtended.TabIndex = 2;
            this.tabExtended.Text = "Дополнительно";
            this.tabExtended.VerticalScrollbarBarColor = true;
            this.tabExtended.VerticalScrollbarHighlightOnWheel = false;
            this.tabExtended.VerticalScrollbarSize = 10;
            // 
            // lblCopyrightAndVersionVlalue
            // 
            this.lblCopyrightAndVersionVlalue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCopyrightAndVersionVlalue.AutoSize = true;
            this.lblCopyrightAndVersionVlalue.Location = new System.Drawing.Point(3, 377);
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
            this.lblDownloadStatusDisc.Location = new System.Drawing.Point(218, 377);
            this.lblDownloadStatusDisc.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.lblDownloadStatusDisc.Name = "lblDownloadStatusDisc";
            this.lblDownloadStatusDisc.Size = new System.Drawing.Size(106, 19);
            this.lblDownloadStatusDisc.TabIndex = 13;
            this.lblDownloadStatusDisc.Text = "Статус загрузки:";
            this.lblDownloadStatusDisc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDownloadStatus
            // 
            this.lblDownloadStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDownloadStatus.AutoSize = true;
            this.lblDownloadStatus.Location = new System.Drawing.Point(324, 377);
            this.lblDownloadStatus.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.lblDownloadStatus.Name = "lblDownloadStatus";
            this.lblDownloadStatus.Size = new System.Drawing.Size(38, 19);
            this.lblDownloadStatus.TabIndex = 14;
            this.lblDownloadStatus.Text = "--/--";
            this.lblDownloadStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // cbContollerType
            // 
            this.cbContollerType.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
            this.cbContollerType.FormattingEnabled = true;
            this.cbContollerType.ItemHeight = 23;
            this.cbContollerType.Items.AddRange(new object[] {
            "Стандартный",
            "Классический",
            "Мини",
            "Гипер"});
            this.cbContollerType.Location = new System.Drawing.Point(206, 5);
            this.cbContollerType.Margin = new System.Windows.Forms.Padding(5);
            this.cbContollerType.Name = "cbContollerType";
            this.cbContollerType.PromptText = "Контроллер";
            this.cbContollerType.Size = new System.Drawing.Size(121, 29);
            this.cbContollerType.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbContollerType.TabIndex = 68;
            this.cbContollerType.UseSelectable = true;
            // 
            // clHelp
            // 
            this.clHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clHelp.Location = new System.Drawing.Point(26, 42);
            this.clHelp.Name = "clHelp";
            this.clHelp.Size = new System.Drawing.Size(60, 19);
            this.clHelp.TabIndex = 12;
            this.clHelp.Text = "Справка";
            this.clHelp.UseSelectable = true;
            // 
            // btnInstallDriver
            // 
            this.btnInstallDriver.AutoSize = true;
            this.btnInstallDriver.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnInstallDriver.Location = new System.Drawing.Point(65, 164);
            this.btnInstallDriver.Margin = new System.Windows.Forms.Padding(5);
            this.btnInstallDriver.Name = "btnInstallDriver";
            this.btnInstallDriver.Size = new System.Drawing.Size(206, 29);
            this.btnInstallDriver.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnInstallDriver.TabIndex = 61;
            this.btnInstallDriver.Text = "Установить драйвер";
            this.btnInstallDriver.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnInstallDriver.UseSelectable = true;
            // 
            // lblDriverTypeDisc
            // 
            this.lblDriverTypeDisc.Location = new System.Drawing.Point(5, 22);
            this.lblDriverTypeDisc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDriverTypeDisc.Name = "lblDriverTypeDisc";
            this.lblDriverTypeDisc.Size = new System.Drawing.Size(191, 29);
            this.lblDriverTypeDisc.TabIndex = 71;
            this.lblDriverTypeDisc.Text = "Варинты типов драйверов";
            this.lblDriverTypeDisc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbDriverType
            // 
            this.cbDriverType.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
            this.cbDriverType.FormattingEnabled = true;
            this.cbDriverType.ItemHeight = 23;
            this.cbDriverType.Items.AddRange(new object[] {
            "Стандартный",
            "Классический",
            "Мини",
            "Гипер"});
            this.cbDriverType.Location = new System.Drawing.Point(206, 22);
            this.cbDriverType.Margin = new System.Windows.Forms.Padding(5);
            this.cbDriverType.Name = "cbDriverType";
            this.cbDriverType.PromptText = "Драйвер";
            this.cbDriverType.Size = new System.Drawing.Size(121, 29);
            this.cbDriverType.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbDriverType.TabIndex = 70;
            this.cbDriverType.UseSelectable = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 398);
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
            this.tpControllers.ResumeLayout(false);
            this.tabControllers.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.pComPortStandart.ResumeLayout(false);
            this.pComPortStandart.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.tabExtended.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tpControllers;
        private MetroFramework.Controls.MetroTabPage tabControllers;
        private MetroFramework.Controls.MetroTabPage tabSettings;
        private MetroFramework.Controls.MetroLabel lblCopyrightAndVersionVlalue;
        private MetroFramework.Controls.MetroTabPage tabExtended;
        private MetroFramework.Controls.MetroButton btnDownloadFirmwareStandart;
        private MetroFramework.Controls.MetroTextBox tbFirmwarePath;
        private MetroFramework.Controls.MetroComboBox cbFirmware;
        private MetroFramework.Controls.MetroComboBox cbComPort;
        private MetroFramework.Controls.MetroPanel pComPortStandart;
        private MetroFramework.Controls.MetroLabel lblFirmwarePathDisc;
        private MetroFramework.Controls.MetroLabel lblFirmwareDisc;
        private MetroFramework.Controls.MetroLabel lblComPortDisc;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel lblProgrammersDisc;
        private MetroFramework.Controls.MetroButton btnDownloadBootloaderStandart;
        private MetroFramework.Controls.MetroComboBox cbProgrammersStandart;
        private MetroFramework.Controls.MetroLabel lblDownloadStatusDisc;
        private MetroFramework.Controls.MetroLabel lblDownloadStatus;
        private MetroFramework.Controls.MetroLabel lblContollerTypeDisc;
        private MetroFramework.Controls.MetroComboBox cbContollerType;
        private MetroFramework.Controls.MetroLink clHelp;
        private MetroFramework.Controls.MetroButton btnInstallDriver;
        private MetroFramework.Controls.MetroLabel lblDriverTypeDisc;
        private MetroFramework.Controls.MetroComboBox cbDriverType;
    }
}

