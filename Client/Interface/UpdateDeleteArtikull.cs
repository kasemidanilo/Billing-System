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
    public delegate void UpdateEvent();

    public partial class UpdateDeleteArtikull : UserControl
    {
        private NArtikujt artikulli;
        public UpdateEvent updateEvent;

        public UpdateDeleteArtikull(NArtikujt artikulli, UpdateEvent updateEvent)
        {
            InitializeComponent();
            this.artikulli = artikulli;
            this.updateEvent = updateEvent;
        }

        private void UpdateDeleteArtikull_Load(object sender, EventArgs e)
        {
            PopulateCombo();
            MapToDisplay();
        }

        private void PopulateCombo()
        {
            njesiaCmb.DataSource = GetAll.GetNjesite();
            njesiaCmb.DisplayMember = "Njesi";
            njesiaCmb.ValueMember = "ID";
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Map();
            this.artikulli.Save();
            CloseForm();
        }

        private void CloseForm()
        {
            Form tmp = this.FindForm();
            tmp.Close();
            tmp.Dispose();
            updateEvent.Invoke();
        }

        private void Map()
        {
            this.artikulli.Emri = textBox1.Text.ToString();
            this.artikulli.Njesi = (Njesia)njesiaCmb.SelectedItem;
        }

        private void MapToDisplay()
        {
            if (artikulli == null) return;
            textBox1.Text = this.artikulli.Emri;
            njesiaCmb.SelectedItem = this.artikulli.Njesi;
        }

        private void Fshi_Click(object sender, EventArgs e)
        {
            this.artikulli.Delete();
            CloseForm();
        }
    }
}
