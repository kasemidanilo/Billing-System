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
    public partial class ShtoNjesi : UserControl
    {
        private Njesia njesia;
        private UpdateEvent updateEvent;

        public ShtoNjesi(UpdateEvent updateEvent)
        {
            InitializeComponent();
            this.updateEvent = updateEvent;
            Load();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string txt = textBox1.Text.ToString();
            if (txt == "") MessageBox.Show("Vendos Njesine");
            njesia = new Njesia() {
                Njesi = txt
            };
            njesia.Save();
            Load();
            updateEvent.Invoke();
        }

        private void Load()
        {
            artikujList.DataSource = GetAll.GetNjesite();
            artikujList.DisplayMember = "Njesi";
            artikujList.ValueMember = "ID";
        }
    }
}
