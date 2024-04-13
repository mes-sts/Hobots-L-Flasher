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
            this.tabControllers = new MetroFramework.Controls.MetroTabControl();
            this.tabControllerStandart = new MetroFramework.Controls.MetroTabPage();
            this.btnDownloadFirmwareStandart = new MetroFramework.Controls.MetroButton();
            this.tbFirmwarePathStandart = new MetroFramework.Controls.MetroTextBox();
            this.cbFirmwareStandart = new MetroFramework.Controls.MetroComboBox();
            this.cbComPortStandart = new MetroFramework.Controls.MetroComboBox();
            this.tabControllerClassic = new MetroFramework.Controls.MetroTabPage();
            this.tabControllerHyper = new MetroFramework.Controls.MetroTabPage();
            this.tabControllerMini = new MetroFramework.Controls.MetroTabPage();
            this.lblCopyrightAndVersionVlalue = new MetroFramework.Controls.MetroLabel();
            this.pComPortStandart = new MetroFramework.Controls.MetroPanel();
            this.lblFirmwarePathDisc = new MetroFramework.Controls.MetroLabel();
            this.lblFirmwareDisc = new MetroFramework.Controls.MetroLabel();
            this.lblComPortDisc = new MetroFramework.Controls.MetroLabel();
            this.clHelp = new MetroFramework.Controls.MetroLink();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lblProgrammersDisc = new MetroFramework.Controls.MetroLabel();
            this.cbProgrammersStandart = new MetroFramework.Controls.MetroComboBox();
            this.btnDownloadBootloaderStandart = new MetroFramework.Controls.MetroButton();
            this.tabControllers.SuspendLayout();
            this.tabControllerStandart.SuspendLayout();
            this.pComPortStandart.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControllers
            // 
            this.tabControllers.Controls.Add(this.tabControllerStandart);
            this.tabControllers.Controls.Add(this.tabControllerClassic);
            this.tabControllers.Controls.Add(this.tabControllerHyper);
            this.tabControllers.Controls.Add(this.tabControllerMini);
            this.tabControllers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControllers.Location = new System.Drawing.Point(20, 60);
            this.tabControllers.Name = "tabControllers";
            this.tabControllers.SelectedIndex = 0;
            this.tabControllers.Size = new System.Drawing.Size(568, 290);
            this.tabControllers.TabIndex = 0;
            this.tabControllers.UseSelectable = true;
            // 
            // tabControllerStandart
            // 
            this.tabControllerStandart.Controls.Add(this.metroPanel1);
            this.tabControllerStandart.Controls.Add(this.pComPortStandart);
            this.tabControllerStandart.HorizontalScrollbarBarColor = true;
            this.tabControllerStandart.HorizontalScrollbarHighlightOnWheel = false;
            this.tabControllerStandart.HorizontalScrollbarSize = 10;
            this.tabControllerStandart.Location = new System.Drawing.Point(4, 38);
            this.tabControllerStandart.Name = "tabControllerStandart";
            this.tabControllerStandart.Size = new System.Drawing.Size(560, 248);
            this.tabControllerStandart.TabIndex = 0;
            this.tabControllerStandart.Text = "Стандартный";
            this.tabControllerStandart.VerticalScrollbarBarColor = true;
            this.tabControllerStandart.VerticalScrollbarHighlightOnWheel = false;
            this.tabControllerStandart.VerticalScrollbarSize = 10;
            // 
            // btnDownloadFirmwareStandart
            // 
            this.btnDownloadFirmwareStandart.AutoSize = true;
            this.btnDownloadFirmwareStandart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDownloadFirmwareStandart.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnDownloadFirmwareStandart.Location = new System.Drawing.Point(0, 126);
            this.btnDownloadFirmwareStandart.Margin = new System.Windows.Forms.Padding(5);
            this.btnDownloadFirmwareStandart.Name = "btnDownloadFirmwareStandart";
            this.btnDownloadFirmwareStandart.Size = new System.Drawing.Size(560, 29);
            this.btnDownloadFirmwareStandart.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnDownloadFirmwareStandart.TabIndex = 60;
            this.btnDownloadFirmwareStandart.Text = "Записать выбранную прошивку в контроллер через порт";
            this.btnDownloadFirmwareStandart.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnDownloadFirmwareStandart.UseSelectable = true;
            // 
            // tbFirmwarePathStandart
            // 
            // 
            // 
            // 
            this.tbFirmwarePathStandart.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.tbFirmwarePathStandart.CustomButton.Location = new System.Drawing.Point(173, 1);
            this.tbFirmwarePathStandart.CustomButton.Name = "";
            this.tbFirmwarePathStandart.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tbFirmwarePathStandart.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbFirmwarePathStandart.CustomButton.TabIndex = 1;
            this.tbFirmwarePathStandart.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbFirmwarePathStandart.CustomButton.UseSelectable = true;
            this.tbFirmwarePathStandart.DisplayIcon = true;
            this.tbFirmwarePathStandart.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.tbFirmwarePathStandart.Lines = new string[0];
            this.tbFirmwarePathStandart.Location = new System.Drawing.Point(346, 88);
            this.tbFirmwarePathStandart.Margin = new System.Windows.Forms.Padding(5);
            this.tbFirmwarePathStandart.MaxLength = 32767;
            this.tbFirmwarePathStandart.Name = "tbFirmwarePathStandart";
            this.tbFirmwarePathStandart.PasswordChar = '\0';
            this.tbFirmwarePathStandart.PromptText = "Путь к файлу прошивки";
            this.tbFirmwarePathStandart.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbFirmwarePathStandart.SelectedText = "";
            this.tbFirmwarePathStandart.SelectionLength = 0;
            this.tbFirmwarePathStandart.SelectionStart = 0;
            this.tbFirmwarePathStandart.ShortcutsEnabled = true;
            this.tbFirmwarePathStandart.ShowButton = true;
            this.tbFirmwarePathStandart.ShowClearButton = true;
            this.tbFirmwarePathStandart.Size = new System.Drawing.Size(201, 29);
            this.tbFirmwarePathStandart.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbFirmwarePathStandart.TabIndex = 59;
            this.tbFirmwarePathStandart.UseSelectable = true;
            this.tbFirmwarePathStandart.WaterMark = "Путь к файлу прошивки";
            this.tbFirmwarePathStandart.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbFirmwarePathStandart.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbFirmwareStandart
            // 
            this.cbFirmwareStandart.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
            this.cbFirmwareStandart.FormattingEnabled = true;
            this.cbFirmwareStandart.ItemHeight = 23;
            this.cbFirmwareStandart.Location = new System.Drawing.Point(346, 49);
            this.cbFirmwareStandart.Margin = new System.Windows.Forms.Padding(5);
            this.cbFirmwareStandart.Name = "cbFirmwareStandart";
            this.cbFirmwareStandart.PromptText = "Прошивка";
            this.cbFirmwareStandart.Size = new System.Drawing.Size(121, 29);
            this.cbFirmwareStandart.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbFirmwareStandart.TabIndex = 56;
            this.cbFirmwareStandart.UseSelectable = true;
            // 
            // cbComPortStandart
            // 
            this.cbComPortStandart.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
            this.cbComPortStandart.FormattingEnabled = true;
            this.cbComPortStandart.ItemHeight = 23;
            this.cbComPortStandart.Location = new System.Drawing.Point(346, 10);
            this.cbComPortStandart.Margin = new System.Windows.Forms.Padding(5);
            this.cbComPortStandart.Name = "cbComPortStandart";
            this.cbComPortStandart.PromptText = "Порт";
            this.cbComPortStandart.Size = new System.Drawing.Size(80, 29);
            this.cbComPortStandart.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbComPortStandart.TabIndex = 54;
            this.cbComPortStandart.UseSelectable = true;
            // 
            // tabControllerClassic
            // 
            this.tabControllerClassic.HorizontalScrollbarBarColor = true;
            this.tabControllerClassic.HorizontalScrollbarHighlightOnWheel = false;
            this.tabControllerClassic.HorizontalScrollbarSize = 10;
            this.tabControllerClassic.Location = new System.Drawing.Point(4, 38);
            this.tabControllerClassic.Name = "tabControllerClassic";
            this.tabControllerClassic.Size = new System.Drawing.Size(560, 248);
            this.tabControllerClassic.TabIndex = 1;
            this.tabControllerClassic.Text = "Классический";
            this.tabControllerClassic.VerticalScrollbarBarColor = true;
            this.tabControllerClassic.VerticalScrollbarHighlightOnWheel = false;
            this.tabControllerClassic.VerticalScrollbarSize = 10;
            // 
            // tabControllerHyper
            // 
            this.tabControllerHyper.HorizontalScrollbarBarColor = true;
            this.tabControllerHyper.HorizontalScrollbarHighlightOnWheel = false;
            this.tabControllerHyper.HorizontalScrollbarSize = 10;
            this.tabControllerHyper.Location = new System.Drawing.Point(4, 38);
            this.tabControllerHyper.Name = "tabControllerHyper";
            this.tabControllerHyper.Size = new System.Drawing.Size(560, 248);
            this.tabControllerHyper.TabIndex = 2;
            this.tabControllerHyper.Text = "Гипер";
            this.tabControllerHyper.VerticalScrollbarBarColor = true;
            this.tabControllerHyper.VerticalScrollbarHighlightOnWheel = false;
            this.tabControllerHyper.VerticalScrollbarSize = 10;
            // 
            // tabControllerMini
            // 
            this.tabControllerMini.HorizontalScrollbarBarColor = true;
            this.tabControllerMini.HorizontalScrollbarHighlightOnWheel = false;
            this.tabControllerMini.HorizontalScrollbarSize = 10;
            this.tabControllerMini.Location = new System.Drawing.Point(4, 38);
            this.tabControllerMini.Name = "tabControllerMini";
            this.tabControllerMini.Size = new System.Drawing.Size(560, 248);
            this.tabControllerMini.TabIndex = 3;
            this.tabControllerMini.Text = "Мини";
            this.tabControllerMini.VerticalScrollbarBarColor = true;
            this.tabControllerMini.VerticalScrollbarHighlightOnWheel = false;
            this.tabControllerMini.VerticalScrollbarSize = 10;
            // 
            // lblCopyrightAndVersionVlalue
            // 
            this.lblCopyrightAndVersionVlalue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCopyrightAndVersionVlalue.AutoSize = true;
            this.lblCopyrightAndVersionVlalue.Location = new System.Drawing.Point(3, 349);
            this.lblCopyrightAndVersionVlalue.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblCopyrightAndVersionVlalue.Name = "lblCopyrightAndVersionVlalue";
            this.lblCopyrightAndVersionVlalue.Size = new System.Drawing.Size(162, 19);
            this.lblCopyrightAndVersionVlalue.TabIndex = 11;
            this.lblCopyrightAndVersionVlalue.Text = "MES GROUP. версия ПО: ";
            this.lblCopyrightAndVersionVlalue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pComPortStandart
            // 
            this.pComPortStandart.Controls.Add(this.lblFirmwarePathDisc);
            this.pComPortStandart.Controls.Add(this.btnDownloadFirmwareStandart);
            this.pComPortStandart.Controls.Add(this.lblFirmwareDisc);
            this.pComPortStandart.Controls.Add(this.tbFirmwarePathStandart);
            this.pComPortStandart.Controls.Add(this.lblComPortDisc);
            this.pComPortStandart.Controls.Add(this.cbFirmwareStandart);
            this.pComPortStandart.Controls.Add(this.cbComPortStandart);
            this.pComPortStandart.Dock = System.Windows.Forms.DockStyle.Top;
            this.pComPortStandart.HorizontalScrollbarBarColor = true;
            this.pComPortStandart.HorizontalScrollbarHighlightOnWheel = false;
            this.pComPortStandart.HorizontalScrollbarSize = 10;
            this.pComPortStandart.Location = new System.Drawing.Point(0, 0);
            this.pComPortStandart.Name = "pComPortStandart";
            this.pComPortStandart.Size = new System.Drawing.Size(560, 155);
            this.pComPortStandart.TabIndex = 65;
            this.pComPortStandart.VerticalScrollbarBarColor = true;
            this.pComPortStandart.VerticalScrollbarHighlightOnWheel = false;
            this.pComPortStandart.VerticalScrollbarSize = 10;
            // 
            // lblFirmwarePathDisc
            // 
            this.lblFirmwarePathDisc.Location = new System.Drawing.Point(5, 88);
            this.lblFirmwarePathDisc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFirmwarePathDisc.Name = "lblFirmwarePathDisc";
            this.lblFirmwarePathDisc.Size = new System.Drawing.Size(331, 29);
            this.lblFirmwarePathDisc.TabIndex = 66;
            this.lblFirmwarePathDisc.Text = "Вариант выбора прошивки из файла";
            this.lblFirmwarePathDisc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFirmwareDisc
            // 
            this.lblFirmwareDisc.Location = new System.Drawing.Point(5, 49);
            this.lblFirmwareDisc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFirmwareDisc.Name = "lblFirmwareDisc";
            this.lblFirmwareDisc.Size = new System.Drawing.Size(331, 29);
            this.lblFirmwareDisc.TabIndex = 67;
            this.lblFirmwareDisc.Text = "Варианты прошивки для записи через порт";
            this.lblFirmwareDisc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblComPortDisc
            // 
            this.lblComPortDisc.Location = new System.Drawing.Point(5, 10);
            this.lblComPortDisc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblComPortDisc.Name = "lblComPortDisc";
            this.lblComPortDisc.Size = new System.Drawing.Size(331, 29);
            this.lblComPortDisc.TabIndex = 65;
            this.lblComPortDisc.Text = "Порт для записи прошивки стандарным способом";
            this.lblComPortDisc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // clHelp
            // 
            this.clHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clHelp.Location = new System.Drawing.Point(528, 349);
            this.clHelp.Name = "clHelp";
            this.clHelp.Size = new System.Drawing.Size(60, 19);
            this.clHelp.TabIndex = 12;
            this.clHelp.Text = "ПОМОГИ";
            this.clHelp.UseSelectable = true;
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
            this.metroPanel1.Location = new System.Drawing.Point(0, 155);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(560, 76);
            this.metroPanel1.TabIndex = 66;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // lblProgrammersDisc
            // 
            this.lblProgrammersDisc.Location = new System.Drawing.Point(5, 10);
            this.lblProgrammersDisc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblProgrammersDisc.Name = "lblProgrammersDisc";
            this.lblProgrammersDisc.Size = new System.Drawing.Size(331, 29);
            this.lblProgrammersDisc.TabIndex = 66;
            this.lblProgrammersDisc.Text = "Варианты программатора для записи загрузчика";
            this.lblProgrammersDisc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbProgrammersStandart
            // 
            this.cbProgrammersStandart.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
            this.cbProgrammersStandart.FormattingEnabled = true;
            this.cbProgrammersStandart.ItemHeight = 23;
            this.cbProgrammersStandart.Location = new System.Drawing.Point(346, 10);
            this.cbProgrammersStandart.Margin = new System.Windows.Forms.Padding(5);
            this.cbProgrammersStandart.Name = "cbProgrammersStandart";
            this.cbProgrammersStandart.PromptText = "Программатор";
            this.cbProgrammersStandart.Size = new System.Drawing.Size(121, 29);
            this.cbProgrammersStandart.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbProgrammersStandart.TabIndex = 67;
            this.cbProgrammersStandart.UseSelectable = true;
            // 
            // btnDownloadBootloaderStandart
            // 
            this.btnDownloadBootloaderStandart.AutoSize = true;
            this.btnDownloadBootloaderStandart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDownloadBootloaderStandart.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnDownloadBootloaderStandart.Location = new System.Drawing.Point(0, 47);
            this.btnDownloadBootloaderStandart.Margin = new System.Windows.Forms.Padding(5);
            this.btnDownloadBootloaderStandart.Name = "btnDownloadBootloaderStandart";
            this.btnDownloadBootloaderStandart.Size = new System.Drawing.Size(560, 29);
            this.btnDownloadBootloaderStandart.TabIndex = 68;
            this.btnDownloadBootloaderStandart.Text = "Записать загрузчик в контроллер через программатор";
            this.btnDownloadBootloaderStandart.UseSelectable = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 370);
            this.Controls.Add(this.clHelp);
            this.Controls.Add(this.lblCopyrightAndVersionVlalue);
            this.Controls.Add(this.tabControllers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "Прошивальщик Hobots L";
            this.tabControllers.ResumeLayout(false);
            this.tabControllerStandart.ResumeLayout(false);
            this.pComPortStandart.ResumeLayout(false);
            this.pComPortStandart.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabControllers;
        private MetroFramework.Controls.MetroTabPage tabControllerStandart;
        private MetroFramework.Controls.MetroTabPage tabControllerClassic;
        private MetroFramework.Controls.MetroLabel lblCopyrightAndVersionVlalue;
        private MetroFramework.Controls.MetroTabPage tabControllerHyper;
        private MetroFramework.Controls.MetroTabPage tabControllerMini;
        private MetroFramework.Controls.MetroButton btnDownloadFirmwareStandart;
        private MetroFramework.Controls.MetroTextBox tbFirmwarePathStandart;
        private MetroFramework.Controls.MetroComboBox cbFirmwareStandart;
        private MetroFramework.Controls.MetroComboBox cbComPortStandart;
        private MetroFramework.Controls.MetroPanel pComPortStandart;
        private MetroFramework.Controls.MetroLabel lblFirmwarePathDisc;
        private MetroFramework.Controls.MetroLabel lblFirmwareDisc;
        private MetroFramework.Controls.MetroLabel lblComPortDisc;
        private MetroFramework.Controls.MetroLink clHelp;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel lblProgrammersDisc;
        private MetroFramework.Controls.MetroButton btnDownloadBootloaderStandart;
        private MetroFramework.Controls.MetroComboBox cbProgrammersStandart;
    }
}

