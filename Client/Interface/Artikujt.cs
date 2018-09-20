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
    public partial class Artikujt : UserControl
    {
        private static Artikujt instance = null;
        private static readonly object padlock = new object();
        private NArtikujt artikulli;
        private List<NArtikujt> artikujt;
        private UpdateEvent updateEvent;

        Artikujt()
        {
            InitializeComponent();
            Load();
        }

        public Artikujt(UpdateEvent updateEvent)
        {
            InitializeComponent();
            Load();
            this.updateEvent = updateEvent;
        }

        public static Artikujt Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Artikujt();
                    }
                    return instance;
                }
            }
        }

        private void PopulateList()
        {
            artikujList.DataSource = GetAll.GetNArtikujt();
            artikujList.DisplayMember = "Emri";
            artikujList.ValueMember = "ID";

        }

        private void PopulateCombo()
        {
            njesiaCmb.DataSource = GetAll.GetNjesite();
            njesiaCmb.DisplayMember = "Njesi";
            njesiaCmb.ValueMember = "ID";
        }

        private void artikujList_Click(object sender, EventArgs e)
        {
            NArtikujt artikujt = (NArtikujt)artikujList.SelectedItem;
            if (artikujt == null) return;
            new PopUp(new UpdateDeleteArtikull(artikujt, new UpdateEvent(Load))).Show();
        }

        private void Load()
        {
            PopulateList();
            PopulateCombo();
            if (updateEvent != null)
            {
                updateEvent.Invoke();
            }
        }

        private void Map()
        {
            this.artikulli = new NArtikujt()
            {
                Emri = textBox1.Text.ToString(),
                Njesi = (Njesia)njesiaCmb.SelectedItem
            };
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Map();
            if (artikulli.Emri == "")
            {
                MessageBox.Show("Ploteso Emrin e Artikullit");
                return;
            }
            this.artikulli.Save();
            Load();
            Clear();
            Update();
        }

        private void Clear()
        {
            textBox1.Clear();
        }

        private void Update()
        {
            if (updateEvent != null)
            {
                updateEvent.Invoke();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new PopUp(new ShtoNjesi(new UpdateEvent (Load))).Show();
        }

        private void Emri_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
