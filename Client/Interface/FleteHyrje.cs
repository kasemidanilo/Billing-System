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

namespace Client.Interface
{
    public delegate void Reload();

    public partial class FleteHyrje : UserControl
    {
        private static FleteHyrje instance = null;
        private static readonly object padlock = new object();
        private FaturaShpenzime fatura;
        private double sasiaCurrente;
        private bool onLoad = true;
        private BindingList<FaturHyrje> faturaHyrje;

        FleteHyrje()
        {
            InitializeComponent();
        }

        public static FleteHyrje Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new FleteHyrje();
                    }
                    return instance;
                }
            }
        }

        private void _Load()
        {
            PopulateArtikujt();
            PopulatePunetoret();
            FillArtikujt();
        }

        private void PopulateArtikujt()
        {
            this.artikujtCmb.DataSource = GetAll.GetNArtikujt();
            this.artikujtCmb.DisplayMember = "Emri";
            this.artikujtCmb.ValueMember = "ID";
        }

        private void PopulatePunetoret()
        {
            this.cmbPunetori.DataSource = GetAll.GetPunetoret();
            this.cmbPunetori.DisplayMember = "Emri";
            this.cmbPunetori.ValueMember = "ID";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new PopUp(new Artikujt(new UpdateEvent(_Load))).Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new PopUp(new _Punetoret(new UpdateEvent(_Load))).Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new PopUp(new ShtoNjesi(new UpdateEvent(_Load))).Show();
        }

        private void FleteHyrje_Load(object sender, EventArgs e)
        {
            _Load();
            faturaHyrje = new BindingList<FaturHyrje>();
            gridFature.DataSource = faturaHyrje;
            ModelGrid();
            onLoad = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _Load();
        }

        private void artikujtCmb_SelectedValueChanged(object sender, EventArgs e)
        {
            if (onLoad) return;
            var art = (NArtikujt)artikujtCmb.SelectedItem;
            var mgz = Magazina.GetMagazina(art.ID);
            sasiaCurrente = mgz.Sasia;
            SasiaMagazine.Text = sasiaCurrente.ToString() + " " + mgz.Njesi.Njesi;
            SasiaMagazine.Visible = true;
        }

        private void ModelGrid()
        {
            gridFature.Columns["shpenzimeID"].Visible = false;
            gridFature.Columns["FatureID"].Visible = false;
            gridFature.Columns["artikulli"].HeaderText = "Artikulli";
            gridFature.Columns["artikulli"].Width = 139;
            gridFature.Columns["Vlera"].Width = 109;
            Total();
            txtTotal.Text = Total().ToString();
        }

        private double Total()
        {
            double totali = 0;
            foreach (DataGridViewRow row in gridFature.Rows)
            {
                var shpenzimi = (FaturHyrje)row.DataBoundItem;
                totali += shpenzimi.Vlera;
            }
            return totali;
        }

        private void NewFature()
        {
            fatura = new FaturaShpenzime();
            fatura.shpenzime = new Shpenzime()
            {
                Data = DateTime.Now,
                punetori = (Punetori)cmbPunetori.SelectedItem
            };
            fatura.faturaHyrje = faturaHyrje.ToList<FaturHyrje>();
        }

        private void SaveFature(object o, EventArgs e)
        {
            NewFature();

            if (!IsValidFatura())
            {
                XtraMessageBox.Show("Ploteso Fushat bosh !!!");
            }
            else
            {
                DialogResult res = XtraMessageBox.Show("Gjenero Faturen !!!", "Je e sigurte qe do te gjenerosh nje fature te re ??", MessageBoxButtons.OKCancel);
                if (res == DialogResult.Cancel) return;
                if (fatura.Save())
                {
                    XtraMessageBox.Show("Fatura u gjenerua !!!");
                    PopulateArtikujt();
                    ClearAll();
                }
                else
                {
                    XtraMessageBox.Show("Fatura nuk gjenerua, KA NJE PROBLEM !!!");
                }
            }
        }

        private bool IsValidFatura()
        {
            bool check = true;

            if (txtSasia.Text == "")
            {
                check = false;
            }
            if (fatura.faturaHyrje.Count == 0)
            {
                check = false;
            }
            return check;
        }

        private void ClearAll()
        {
            fatura = null;
            cmbPunetori.Enabled = true;
            txtSasia.EditValue = 0;
            txtCmimi.EditValue = 0;
            faturaHyrje = new BindingList<FaturHyrje>();
            gridFature.DataSource = faturaHyrje;
            txtTotal.Text = "0";
            txtArtikulli.Text = string.Empty;
            SasiaMagazine.Visible = false;
        }

        private void validateSasia(object sender, EventArgs e)
        {
            //validate();
        }

       
        private void Clear(object o, EventArgs e)
        {
            ClearAll();
        }

        //private void ControlShtoBtn()
        //{
        //    if (isArtikulliValid && isSasiaValid) btnShto.Enabled = true;
        //    else btnShto.Enabled = false;
        //}

        private bool CheckUnique(FaturHyrje afature)
        {
            bool check = true;
            foreach (DataGridViewRow row in gridFature.Rows)
            {
                var artikulli = (FaturHyrje)row.DataBoundItem;
                if (afature.artikulli.ID == artikulli.artikulli.ID)
                {
                    check = false;
                    XtraMessageBox.Show("Artikulli eshte ne fature");
                    break;
                }
            }
            return check;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _Load();
        }

        private void btnShto_Click(object sender, EventArgs e)
        {
            if (!isArtikulliValid() || !isSasiaValid())
            {
                return;
            }
            else
            {
                FaturHyrje fature = toFatureHyrje();
                if (!CheckUnique(fature)) return;
                faturaHyrje.Add(fature);
                FillGrid();
                Deactivate();
            }
        }

        private void FillGrid()
        {
            gridFature.DataSource = null;
            gridFature.DataSource = faturaHyrje;
            ModelGrid();
        }

        private void Deactivate()
        {
            cmbPunetori.Enabled = false;
            txtSasia.EditValue = 0;
            txtCmimi.EditValue = 0;
        }

        private FaturHyrje toFatureHyrje()
        {
            double _cmimi = Helper.SantitizeDouble(txtCmimi.Text.ToString());
            double _sasia = Helper.SantitizeDouble(txtSasia.Text.ToString());
            NArtikujt art = new NArtikujt(txtArtikulli.Text.ToString());
            return new FaturHyrje()
            {
                artikulli = art,
                Cmimi = _cmimi,
                Sasia = _sasia,                
                Vlera = (_sasia * _cmimi)
            };
        }

        private void gridFature_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtArtikulli_Validating(object sender, CancelEventArgs e)
        {
        }

        private void FillArtikujt()
        {
            var arts = GetAll.GetNArtikujt();
            txtArtikulli.AutoCompleteSource = AutoCompleteSource.CustomSource;
            foreach (var art in arts)
            {
                txtArtikulli.AutoCompleteCustomSource.Add(art.Emri);
            }
        }
        private void validateAll()
        {
        }

        private void validateSasia(object sender, CancelEventArgs e)
        {
        }

        private void txtArtikulli_TextChanged(object sender, EventArgs e)
        {
            var art = new NArtikujt(txtArtikulli.Text.ToString());
            if (art.ID != 0)
            {
                var mgz = Magazina.GetMagazina(art.ID);
                sasiaCurrente = mgz.Sasia;
                SasiaMagazine.Text = sasiaCurrente.ToString() + " " + mgz.Njesi.Njesi;
                SasiaMagazine.Visible = true;
            }
            else
            {
                SasiaMagazine.Visible = false;
            }
        }

        private bool isArtikulliValid()
        {
            if (onLoad) return false;
            var art = new NArtikujt(txtArtikulli.Text.ToString());
            if (art.ID != 0)
            {
                var mgz = Magazina.GetMagazina(art.ID);
                sasiaCurrente = mgz.Sasia;
                SasiaMagazine.Text = sasiaCurrente.ToString() + " " + mgz.Njesi.Njesi;
                SasiaMagazine.Visible = true;
                return true;
            }
            else
            {
                SasiaMagazine.Visible = false;
                XtraMessageBox.Show("Artikulli mungon ose eshte gabim !!!");
                return false;
            }
        }

        private bool isSasiaValid()
        {
            bool check = true;
            if (onLoad) check = false;
            var sasia = Helper.SantitizeDouble(txtSasia.Text.ToString());if (sasia <= 0)
            {
                SasiaMagazine.ForeColor = Color.Red;
                txtSasia.ForeColor = Color.Red;
                XtraMessageBox.Show("Kujdes sasine e kerkuar !!!!");
                check = false;
            }
            return check;
        }
    }
}
