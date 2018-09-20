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
    public partial class UpdateDeletePunetoret : UserControl
    {
        private Punetori punetori;
        public UpdateEvent updateEvent;

        public UpdateDeletePunetoret(Punetori punetori, UpdateEvent updateEvent)
        {
            InitializeComponent();
            this.punetori = punetori;
            this.updateEvent = updateEvent;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Map();
            this.punetori.Save();
            CloseForm();
        }

        private void Map()
        {
            this.punetori.Emri = textBox1.Text.ToString();
            this.punetori.Mbiemri = textBox2.Text.ToString();
        }

        private void MapToDisplay()
        {
            if (punetori == null) return;
            textBox1.Text = this.punetori.Emri;
            textBox2.Text = this.punetori.Mbiemri;
        }

        private void Fshi_Click(object sender, EventArgs e)
        {
            this.punetori.Delete();
            CloseForm();
        }

        private void CloseForm()
        {
            Form tmp = this.FindForm();
            tmp.Close();
            tmp.Dispose();
            updateEvent.Invoke();
        }

        private void UpdateDeletePunetoret_Load(object sender, EventArgs e)
        {
            MapToDisplay();
        }
    }
}
