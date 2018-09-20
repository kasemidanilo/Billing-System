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
    public partial class _ShpenzimeExtra : UserControl
    {
        private static _ShpenzimeExtra instance = null;
        private static readonly object padlock = new object();
        private FaturaShpenzime fatura;
        private double sasiaCurrente;
        private bool onLoad = true;
        private BindingList<ShpenzimeExtra> shpenzimeExtra;

        _ShpenzimeExtra()
        {
            InitializeComponent();
        }

        public static _ShpenzimeExtra Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new _ShpenzimeExtra();
                    }
                    return instance;
                }
            }
        }

        private void _Load()
        {
            PopulateNjesite();
            PopulatePunetoret();
        }

        private void PopulatePunetoret()
        {
            this.cmbPunetori.DataSource = GetAll.GetPunetoret();
            this.cmbPunetori.DisplayMember = "Emri";
            this.cmbPunetori.ValueMember = "ID";
        }

        private void PopulateNjesite()
        {
            this.njesiaCmb.DataSource = GetAll.GetNjesite();
            this.njesiaCmb.DisplayMember = "Njesi";
            this.njesiaCmb.ValueMember = "ID";
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
            shpenzimeExtra = new BindingList<ShpenzimeExtra>();
            gridFature.DataSource = shpenzimeExtra;
            ModelGrid();
            onLoad = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _Load();
        }

        private void artikujtCmb_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void ModelGrid()
        {
            gridFature.Columns["ExtraID"].Visible = false;
            gridFature.Columns["shpenzimeID"].Visible = false;
            gridFature.Columns["Pershkrimi"].Visible = false;
            gridFature.Columns["njesia"].HeaderText = "Njesia";
            gridFature.Columns["Emertimi"].Width = 128;
            gridFature.Columns["Sasia"].Width = 79;
            gridFature.Columns["Cmimi"].Width = 79;
            gridFature.Columns["Njesia"].Width = 52;
            gridFature.Columns["Vlera"].Width = 109;
            Total();
            txtTotal.Text = Total().ToString();
        }

        private double Total()
        {
            double totali = 0;
            foreach (DataGridViewRow row in gridFature.Rows)
            {
                var shpenzimi = (ShpenzimeExtra)row.DataBoundItem;
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
            fatura.shpenzimeExtra = shpenzimeExtra.ToList<ShpenzimeExtra>();
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
                    PopulatePunetoret();
                    PopulateNjesite();
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
            if (fatura.shpenzimeExtra.Count == 0)
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
            textEdit2.Text = "";
            txtPershkrimi.Text = "";
            shpenzimeExtra = new BindingList<ShpenzimeExtra>();
            gridFature.DataSource = shpenzimeExtra;
            txtTotal.Text = "0";
        }

        private void ShtoClear()
        {
            txtSasia.EditValue = 0;
            txtCmimi.EditValue = 0;
            textEdit2.Text = "";
            txtPershkrimi.Text = "";
        }

        private void validateSasia(object sender, EventArgs e)
        {
            validate();
        }

        private void validate()
        {
            if (onLoad) return;
            var sasia = Helper.SantitizeDouble(txtSasia.Text.ToString());
            if (sasia <= 0)
            {
                txtSasia.ForeColor = Color.Red;
                btnShto.Enabled = false;
                XtraMessageBox.Show("Kujdes sasine e kerkuar !!!!");
            }
            else
            {
                txtSasia.ForeColor = Color.Black;
                btnShto.Enabled = true;
            }
        }

        private void Clear(object o, EventArgs e)
        {
            ClearAll();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            _Load();
        }

        private void btnShto_Click(object sender, EventArgs e)
        {

            ShpenzimeExtra fature = toFatureHyrje();
            shpenzimeExtra.Add(fature);
            FillGrid();
            ShtoClear();
            Deactivate();
        }

        private void FillGrid()
        {
            gridFature.DataSource = null;
            gridFature.DataSource = shpenzimeExtra;
            ModelGrid();
        }

        private void Deactivate()
        {
            cmbPunetori.Enabled = false;
            txtSasia.EditValue = 0;
            txtCmimi.EditValue = 0;
        }

        private ShpenzimeExtra toFatureHyrje()
        {
            double _cmimi = Helper.SantitizeDouble(txtCmimi.Text.ToString());
            double _sasia = Helper.SantitizeDouble(txtSasia.Text.ToString());
            return new ShpenzimeExtra()
            {
                Cmimi = _cmimi,
                Sasia = _sasia,
                Vlera = (_sasia * _cmimi),
                Emertimi = textEdit2.Text.ToString(),
                Pershkrimi = txtPershkrimi.Text.ToString(),
                njesia = (Njesia)njesiaCmb.SelectedItem
            };
        }

        private void gridFature_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
