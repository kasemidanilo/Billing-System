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
using DevExpress.XtraGrid.Views.Layout;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors;

namespace Client.Interface
{
    public partial class Fature : UserControl
    {
        private static Fature instance = null;
        private static readonly object padlock = new object();
        private Fatura fatura;
        private double sasiaCurrente;
        private bool onLoad = true;
        private BindingList<ArtikullFature> artikujt;
        DataTable table;
        public static Reload reload;

        Fature()
        {
            InitializeComponent();
        }

        public static Fature Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Fature();
                    }
                    return instance;
                }
            }
        }

        private void _Load()
        {
            PopulateArtikujt();
            PopulateKlientet();
            PopulatePunetoret();
            FillArtikujt();
        }

        private void PopulateArtikujt()
        {
            this.artikujtCmb.DataSource = GetAll.GetNArtikujt();
            this.artikujtCmb.DisplayMember = "Emri";
            this.artikujtCmb.ValueMember = "ID";
        }

        private void PopulateKlientet()
        {
            this.cmbKlienti.DataSource = GetAll.GetKlientet();
            this.cmbKlienti.DisplayMember = "Emri";
            this.cmbKlienti.ValueMember = "ID";
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
            new PopUp(new Klientet(new UpdateEvent(_Load))).Show();
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

        private void validateSasia(object sender, EventArgs e)
        {
            isSasiaValid();
        }

        private bool isSasiaValid()
        {
            bool check = true;
            if (onLoad) check = false;
            var sasia = Helper.SantitizeDouble(txtSasia.Text.ToString());
            if (sasiaCurrente < sasia)
            {
                SasiaMagazine.ForeColor = Color.Red;
                txtSasia.ForeColor = Color.Red;
                XtraMessageBox.Show("Sasia ne magazine eshte me e vogel se sasia e kerkuar !!!!");
                check = false;
            }
            else if (sasia <= 0)
            {
                SasiaMagazine.ForeColor = Color.Red;
                txtSasia.ForeColor = Color.Red;
                XtraMessageBox.Show("Kujdes sasine e kerkuar !!!!");
                check = false;
            }
            else if (sasiaCurrente > sasia && sasia > 0)
            {
                SasiaMagazine.ForeColor = Color.Black;
                txtSasia.ForeColor = Color.Black;
                check = true;
            }
            return check;
        }

        //private void ControlShtoBtn()
        //{
        //    if (isArtikulliValid && isSasiaValid) btnShto.Enabled = true;
        //    else ""
        //}

        private void btnShto_Click(object sender, EventArgs e)
        {
            var no = Helper.SantitizeLong(NoFature.Text.ToString());
            if (no == 0)
            {
                XtraMessageBox.Show("Ploteso numrin e fatures !!!");
                return;
            }
            else if (!isArtikulliValid() || !isSasiaValid())
            {
                return;
            }
            else if (dateEdit1.DateTime == DateTime.MinValue)
            {
                XtraMessageBox.Show("Ploteso daten e fatures !!!");
                return;
            }
            else
            {
                ArtikullFature artikullFature = toArtikullFature();
                if (!CheckUnique(artikullFature)) return;
                artikujt.Add(artikullFature);
                FillGrid();
                Deactivate();
            }
        }

        private void FillGrid()
        {
            gridFature.DataSource = null;
            gridFature.DataSource = artikujt;
            ModelGrid();
        }

        private void Deactivate()
        {
            NoFature.Enabled = false;
            cmbKlienti.Enabled = false;
            cmbPunetori.Enabled = false;
            txtSasia.EditValue = 0;
            txtCmimi.EditValue = 0;
            txtArtikulli.Text = string.Empty;
            dateEdit1.Enabled = false;
        }

        private void Clear()
        {
            txtSasia.EditValue = 0;
            txtCmimi.EditValue = 0;
            txtArtikulli.Text = string.Empty;
        }

        private ArtikullFature toArtikullFature()
        {
            double _cmimi = Helper.SantitizeDouble(txtCmimi.Text.ToString());
            double _sasia = Helper.SantitizeDouble(txtSasia.Text.ToString());
            return new ArtikullFature(new NotValidEvent(ThrowMessage))
            {
                NArtikull = new NArtikujt(txtArtikulli.Text.ToString()),
                Cmimi = _cmimi,
                NoFature = Helper.SantitizeLong(NoFature.Text.ToString()),
                Sasia = _sasia,
                Vlera = (_sasia * _cmimi)
            };
        }

        private void ThrowMessage(string message)
        {
            XtraMessageBox.Show(message);
        }

        private void Fature_Load(object sender, EventArgs e)
        {
            _Load();
            artikujt = new BindingList<ArtikullFature>();
            gridFature.DataSource = artikujt;
            ModelGrid();
            onLoad = false;
        }

        private void GridTable(ArtikullFature artikull)
        {
            object[] obj = new object[] {
                artikull.NArtikull.Emri,
                artikull.Sasia,
                artikull.Cmimi,
                (artikull.Sasia * artikull.Cmimi)
            };
            table.Rows.Add(obj);
        }

        private void InitTable()
        {
            table = new DataTable();
            table.Columns.Add("Artikulli", typeof(String));
            table.Columns.Add("Sasia", typeof(double));
            table.Columns.Add("Cmimi", typeof(double));
            table.Columns.Add("Vlera", typeof(double));
        }

        private void ModelGrid()
        {
            gridFature.Columns["ID"].Visible = false;
            gridFature.Columns["NoFature"].Visible = false;
            gridFature.Columns["NArtikull"].HeaderText = "Artikulli";
            gridFature.Columns["NArtikull"].Width = 139;
            gridFature.Columns["Vlera"].Width = 109;
            Total();
            txtTotal.Text = Total().ToString();
        }

        private double Total()
        {
            double totali = 0;
            foreach (DataGridViewRow row in gridFature.Rows)
            {
                var artikulli = (ArtikullFature)row.DataBoundItem;
                totali += artikulli.Vlera;
            }
            return totali;
        }

        private void NewFature()
        {
            fatura = new Fatura();
            fatura.fature = new FatureDalje()
            {
                Date = dateEdit1.DateTime,
                Klienti = (Klienti)cmbKlienti.SelectedItem,
                Puntori = (Punetori)cmbPunetori.SelectedItem,
                NoFature = Helper.SantitizeLong(NoFature.Text.ToString())
            };
            fatura.artikujt = artikujt.ToList<ArtikullFature>();
        }

        private void SaveFature(object o, EventArgs e)
        {
            NewFature();
            string ms;
            if (!IsValidFatura(out ms))
            {
                XtraMessageBox.Show(ms);
            }
            else
            {
                DialogResult res = XtraMessageBox.Show("Gjenero Faturen !!!", "Je e sigurte qe do te gjenerosh nje fature te re ??", MessageBoxButtons.OKCancel);
                if (res == DialogResult.Cancel) return;
                if (fatura._Save())
                {
                    Reporting.Reporting.GetFaturaByNo(fatura.fature.NoFature);
                    XtraMessageBox.Show("Fatura u gjenerua !!!");
                    PopulateArtikujt();
                    ClearAll();
                    if (Fature.reload != null) reload.Invoke();
                }
                else
                {
                    XtraMessageBox.Show("Fatura nuk gjenerua, KA NJE PROBLEM !!!");
                }
            }
        }

        private void Clear(object o, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            fatura = null;
            NoFature.Enabled = true;
            cmbKlienti.Enabled = true;
            cmbPunetori.Enabled = true;
            txtSasia.EditValue = 0;
            txtCmimi.EditValue = 0;
            artikujt = new BindingList<ArtikullFature>();
            gridFature.DataSource = artikujt;
            NoFature.Text = "";
            txtTotal.Text = "0";            
            txtArtikulli.Text = string.Empty;
            SasiaMagazine.Visible = false;
            dateEdit1.Enabled = true;
            dateEdit1.DeselectAll();
        }

        private bool IsValidFatura(out string msg)
        {
            bool check = true;
            msg = string.Empty;
            if (NoFature.Text == "")
            {
                check = false;
                msg = "Ploteso numrin e fatures";
            }
            if (fatura.artikujt.Count == 0)
            {
                check = false;
                msg = "Ploteso Artikullin";
            }
            if (dateEdit1.DateTime == DateTime.MinValue)
            {
                check = false;
                msg = "Ploteso Daten";
            }
            return check;
        }

        private void gridFature_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private bool CheckUnique(ArtikullFature afature)
        {
            bool check = true;
            foreach (DataGridViewRow row in gridFature.Rows)
            {
                var artikulli = (ArtikullFature)row.DataBoundItem;
                if (afature.NArtikull.ID == artikulli.NArtikull.ID)
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

        private void FillArtikujt()
        {
            var arts = GetAll.GetNArtikujt();
            txtArtikulli.AutoCompleteSource = AutoCompleteSource.CustomSource;
            foreach (var art in arts)
            {
                txtArtikulli.AutoCompleteCustomSource.Add(art.Emri);
            }
        }

        private void txtArtikulli_Validating(object sender, CancelEventArgs e)
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

        private void CheckEnter(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                
            }
        }

        private void searchControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

