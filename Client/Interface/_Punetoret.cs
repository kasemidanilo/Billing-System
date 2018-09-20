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
    public partial class _Punetoret : UserControl
    {
        private static _Punetoret instance = null;
        private static readonly object padlock = new object();
        private Punetori punetori;
        private List<Punetori> punetoret;
        private UpdateEvent updateEvent;

        _Punetoret()
        {
            InitializeComponent();
            Load();
        }

        public _Punetoret(UpdateEvent updateEvent)
        {
            InitializeComponent();
            Load();
            this.updateEvent = updateEvent;
        }

        public static _Punetoret Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new _Punetoret();
                    }
                    return instance;
                }
            }
        }

        private void Load()
        {
            PopulateList();
            if (updateEvent != null)
            {
                updateEvent.Invoke();
            }
        }

        private void PopulateList()
        {
            punetoretList.DataSource = GetAll.GetPunetoret();
            punetoretList.DisplayMember = "Emri";
            punetoretList.ValueMember = "ID";
        }

        private void Map()
        {
            this.punetori = new Punetori()
            {
                Emri = textBox1.Text.ToString(),
                Mbiemri = textBox2.Text.ToString()
            };
        }

        private void Clear()
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void Update()
        {
            if (updateEvent != null) updateEvent.Invoke();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Map();
            if (punetori.Emri == "" || punetori.Mbiemri == "")
            {
                MessageBox.Show("Ploteso Emrin ose Mbiemrin!");
                return;
            }
            this.punetori.Save();
            Load();
            Clear();
            Update();
        }

        private void artikujList_Click(object sender, EventArgs e)
        {
            Punetori punetori = (Punetori)punetoretList.SelectedItem;
            if (punetori == null) return;
            new PopUp(new UpdateDeletePunetoret(punetori, new UpdateEvent(Load))).Show();
        }
    }
}
