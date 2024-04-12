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
            this.tabControllerClassic = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tabControllerHyper = new MetroFramework.Controls.MetroTabPage();
            this.tabControllerMini = new MetroFramework.Controls.MetroTabPage();
            this.tabControllers.SuspendLayout();
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
            this.tabControllers.Size = new System.Drawing.Size(760, 366);
            this.tabControllers.TabIndex = 0;
            this.tabControllers.UseSelectable = true;
            // 
            // tabControllerStandart
            // 
            this.tabControllerStandart.HorizontalScrollbarBarColor = true;
            this.tabControllerStandart.HorizontalScrollbarHighlightOnWheel = false;
            this.tabControllerStandart.HorizontalScrollbarSize = 10;
            this.tabControllerStandart.Location = new System.Drawing.Point(4, 38);
            this.tabControllerStandart.Name = "tabControllerStandart";
            this.tabControllerStandart.Size = new System.Drawing.Size(752, 324);
            this.tabControllerStandart.TabIndex = 0;
            this.tabControllerStandart.Text = "Стандартный";
            this.tabControllerStandart.VerticalScrollbarBarColor = true;
            this.tabControllerStandart.VerticalScrollbarHighlightOnWheel = false;
            this.tabControllerStandart.VerticalScrollbarSize = 10;
            // 
            // tabControllerClassic
            // 
            this.tabControllerClassic.HorizontalScrollbarBarColor = true;
            this.tabControllerClassic.HorizontalScrollbarHighlightOnWheel = false;
            this.tabControllerClassic.HorizontalScrollbarSize = 10;
            this.tabControllerClassic.Location = new System.Drawing.Point(4, 38);
            this.tabControllerClassic.Name = "tabControllerClassic";
            this.tabControllerClassic.Size = new System.Drawing.Size(752, 324);
            this.tabControllerClassic.TabIndex = 1;
            this.tabControllerClassic.Text = "Классический";
            this.tabControllerClassic.VerticalScrollbarBarColor = true;
            this.tabControllerClassic.VerticalScrollbarHighlightOnWheel = false;
            this.tabControllerClassic.VerticalScrollbarSize = 10;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 425);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(84, 19);
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "MES GROUP";
            // 
            // tabControllerHyper
            // 
            this.tabControllerHyper.HorizontalScrollbarBarColor = true;
            this.tabControllerHyper.HorizontalScrollbarHighlightOnWheel = false;
            this.tabControllerHyper.HorizontalScrollbarSize = 10;
            this.tabControllerHyper.Location = new System.Drawing.Point(4, 38);
            this.tabControllerHyper.Name = "tabControllerHyper";
            this.tabControllerHyper.Size = new System.Drawing.Size(752, 324);
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
            this.tabControllerMini.Size = new System.Drawing.Size(752, 324);
            this.tabControllerMini.TabIndex = 3;
            this.tabControllerMini.Text = "Мини";
            this.tabControllerMini.VerticalScrollbarBarColor = true;
            this.tabControllerMini.VerticalScrollbarHighlightOnWheel = false;
            this.tabControllerMini.VerticalScrollbarSize = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 446);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.tabControllers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "Прошивальщик  Хоботс Л";
            this.tabControllers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabControllers;
        private MetroFramework.Controls.MetroTabPage tabControllerStandart;
        private MetroFramework.Controls.MetroTabPage tabControllerClassic;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTabPage tabControllerHyper;
        private MetroFramework.Controls.MetroTabPage tabControllerMini;
    }
}

