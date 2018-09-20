using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace Client.Interface
{
    public partial class Klientet : UserControl
    {
        private Klienti klienti;
        private UpdateEvent updateEvent;

        public Klientet(UpdateEvent updateEvent)
        {
            InitializeComponent();
            this.updateEvent = updateEvent;
            Load();
        }

        private void Load()
        {
            artikujList.DataSource = GetAll.GetKlientet();
            artikujList.DisplayMember = "Emri";
            artikujList.ValueMember = "ID";
        }

        private void Save_Event(object sender, EventArgs e)
        {
            string txt = textBox1.Text.ToString();
            if (txt == "") MessageBox.Show("Vendos Emrin!");
            klienti = new Klienti()
            {
                Emri = txt
            };
            klienti.Save();
            Load();
            updateEvent.Invoke();
        }
    }
}
