using System;
using System.Windows.Forms;
using Client.Interface;
using Client.Reporting;


namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelControl3.Controls.Clear();
            panelControl3.Controls.Add(Artikujt.Instance);
        }

        private void Punetoret_Click(object sender, EventArgs e)
        {
            panelControl3.Controls.Clear();
            panelControl3.Controls.Add(_Punetoret.Instance);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelControl3.Controls.Clear();
            panelControl3.Controls.Add(Fature.Instance);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelControl3.Controls.Clear();
            panelControl3.Controls.Add(FleteHyrje.Instance);
        }

        private void _ShpenzimeExtra_Click(object sender, EventArgs e)
        {
            panelControl3.Controls.Clear();
            panelControl3.Controls.Add(_ShpenzimeExtra.Instance);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panelControl3.Controls.Clear();
            panelControl3.Controls.Add(Gjenero_Faturen.Instance);
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
