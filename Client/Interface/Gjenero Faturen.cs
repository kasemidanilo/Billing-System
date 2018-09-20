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
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace Client.Interface
{
    public partial class Gjenero_Faturen : UserControl
    {
        private static Gjenero_Faturen instance = null;
        private static readonly object padlock = new object();

        Gjenero_Faturen()
        {
            InitializeComponent();
        }

        public static Gjenero_Faturen Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Gjenero_Faturen();
                    }
                    return instance;
                }
            }
        }

        private void FillArtikujt()
        {
            var arts = GetAll.GetAllFaturat();
            txtArtikulli.AutoCompleteSource = AutoCompleteSource.CustomSource;
            foreach (var art in arts)
            {
                txtArtikulli.AutoCompleteCustomSource.Add(art.NoFature.ToString());
            }
        }

        private void FillKlientet()
        {
            var arts = GetAll.GetKlientet();
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            foreach (var art in arts)
            {
                textBox1.AutoCompleteCustomSource.Add(art.Emri);
            }
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Reporting.Reporting.GetSales(dateEdit1.DateTime, dateEdit2.DateTime.AddDays(1));
        }

        private void dateEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Reporting.Reporting.GetShpenzimet(dateEdit6.DateTime, dateEdit5.DateTime.AddDays(1));
        }

        private void Gjenero_Faturen_Load(object sender, EventArgs e)
        {
            Fature.reload += _Load;
            _Load();
        }

        private void _Load()
        {
            FillArtikujt();
            FillKlientet();
            FillGrid();
        }
        private void FillGrid()
        {
            gridView1.OptionsView.ShowAutoFilterRow = true;
            gridView1.OptionsBehavior.Editable = false;
            this.gridControl1.DataSource = GetAll.GetAllFaturat();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            long fatureNo = Helper.SantitizeLong(txtArtikulli.Text.ToString());
            if (fatureNo == 0)
            {
                XtraMessageBox.Show("Kujdes!!! Fatura nuk ekziston !!!");
                return;
            } 
            Reporting.Reporting.GetFaturaByNo(fatureNo);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Klienti klienti = null;
            try
            {
                klienti = new Klienti(textBox1.Text.ToString());
            }
            catch
            {
                XtraMessageBox.Show("Kujdes!!! Klienti nuk ekziston !!!");
                return;
            }
            Reporting.Reporting.GetSales(dateEdit4.DateTime, dateEdit3.DateTime.AddDays(1), klienti);
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            FatureDalje fature = (FatureDalje)gridView1.GetFocusedRow();
            Reporting.Reporting.GetFaturaByNo(fature.NoFature);
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
