using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace Hobots_L_Flasher
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
            lblCopyrightAndVersionVlalue.Text += Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }
    }
}
