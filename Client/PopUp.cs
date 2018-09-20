using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Interface
{
    public partial class PopUp : Form
    {
        UserControl control;

        public PopUp(UserControl control)
        {
            InitializeComponent();
            this.Controls.Add(control);
            this.control = control;
            AdatptScreen();
        }

        private void AdatptScreen()
        {
            this.Width = control.Width;
            this.Height = control.Height;
            this.Text = control.Name;
        }
    }
}
