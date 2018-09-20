using Models;
using System.Collections.Generic;

namespace Client.Interface
{
    partial class Fature
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSasia = new DevExpress.XtraEditors.TextEdit();
            this.txtCmimi = new DevExpress.XtraEditors.TextEdit();
            this.Sasia = new DevExpress.XtraEditors.LabelControl();
            this.Cmimi = new DevExpress.XtraEditors.LabelControl();
            this.Klienti = new DevExpress.XtraEditors.LabelControl();
            this.SasiaMagazine = new DevExpress.XtraEditors.LabelControl();
            this.btnShto = new DevExpress.XtraEditors.SimpleButton();
            this.btnPastro = new DevExpress.XtraEditors.SimpleButton();
            this.btnPri = new DevExpress.XtraEditors.SimpleButton();
            this.cmbKlienti = new System.Windows.Forms.ComboBox();
            this.cmbPunetori = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnAddKlienti = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddPunetori = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.NoFature = new DevExpress.XtraEditors.TextEdit();
            this.gridFature = new System.Windows.Forms.DataGridView();
            this.txtTotal = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnAddArtikull = new DevExpress.XtraEditors.SimpleButton();
            this.Artikull = new DevExpress.XtraEditors.LabelControl();
            this.artikujtCmb = new System.Windows.Forms.ComboBox();
            this.button1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtArtikulli = new System.Windows.Forms.TextBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSasia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCmimi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoFature.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSasia
            // 
            this.txtSasia.Location = new System.Drawing.Point(244, 71);
            this.txtSasia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSasia.Name = "txtSasia";
            this.txtSasia.Properties.Mask.BeepOnError = true;
            this.txtSasia.Properties.Mask.EditMask = "n2";
            this.txtSasia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSasia.Size = new System.Drawing.Size(133, 22);
            this.txtSasia.TabIndex = 3;
            // 
            // txtCmimi
            // 
            this.txtCmimi.Location = new System.Drawing.Point(385, 71);
            this.txtCmimi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCmimi.Name = "txtCmimi";
            this.txtCmimi.Properties.Mask.BeepOnError = true;
            this.txtCmimi.Properties.Mask.EditMask = "n2";
            this.txtCmimi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCmimi.Size = new System.Drawing.Size(133, 22);
            this.txtCmimi.TabIndex = 5;
            // 
            // Sasia
            // 
            this.Sasia.Location = new System.Drawing.Point(244, 48);
            this.Sasia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Sasia.Name = "Sasia";
            this.Sasia.Size = new System.Drawing.Size(31, 16);
            this.Sasia.TabIndex = 7;
            this.Sasia.Text = "Sasia";
            // 
            // Cmimi
            // 
            this.Cmimi.Location = new System.Drawing.Point(385, 48);
            this.Cmimi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cmimi.Name = "Cmimi";
            this.Cmimi.Size = new System.Drawing.Size(36, 16);
            this.Cmimi.TabIndex = 9;
            this.Cmimi.Text = "Cmimi";
            // 
            // Klienti
            // 
            this.Klienti.Location = new System.Drawing.Point(213, 54);
            this.Klienti.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Klienti.Name = "Klienti";
            this.Klienti.Size = new System.Drawing.Size(34, 16);
            this.Klienti.TabIndex = 10;
            this.Klienti.Text = "Klienti";
            // 
            // SasiaMagazine
            // 
            this.SasiaMagazine.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.SasiaMagazine.Appearance.Options.UseFont = true;
            this.SasiaMagazine.Location = new System.Drawing.Point(472, 1);
            this.SasiaMagazine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SasiaMagazine.Name = "SasiaMagazine";
            this.SasiaMagazine.Size = new System.Drawing.Size(98, 40);
            this.SasiaMagazine.TabIndex = 11;
            this.SasiaMagazine.Text = "*20 kg";
            this.SasiaMagazine.Visible = false;
            // 
            // btnShto
            // 
            this.btnShto.Location = new System.Drawing.Point(509, 373);
            this.btnShto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShto.Name = "btnShto";
            this.btnShto.Size = new System.Drawing.Size(188, 28);
            this.btnShto.TabIndex = 12;
            this.btnShto.Text = "Shto ne fature";
            this.btnShto.Click += new System.EventHandler(this.btnShto_Click);
            // 
            // btnPastro
            // 
            this.btnPastro.Location = new System.Drawing.Point(1199, 375);
            this.btnPastro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPastro.Name = "btnPastro";
            this.btnPastro.Size = new System.Drawing.Size(207, 26);
            this.btnPastro.TabIndex = 14;
            this.btnPastro.Text = "Pastro";
            this.btnPastro.Click += new System.EventHandler(this.Clear);
            // 
            // btnPri
            // 
            this.btnPri.Location = new System.Drawing.Point(984, 375);
            this.btnPri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPri.Name = "btnPri";
            this.btnPri.Size = new System.Drawing.Size(207, 26);
            this.btnPri.TabIndex = 15;
            this.btnPri.Text = "Pri Faturen";
            this.btnPri.Click += new System.EventHandler(this.SaveFature);
            // 
            // cmbKlienti
            // 
            this.cmbKlienti.FormattingEnabled = true;
            this.cmbKlienti.Location = new System.Drawing.Point(213, 78);
            this.cmbKlienti.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbKlienti.Name = "cmbKlienti";
            this.cmbKlienti.Size = new System.Drawing.Size(132, 24);
            this.cmbKlienti.TabIndex = 17;
            // 
            // cmbPunetori
            // 
            this.cmbPunetori.FormattingEnabled = true;
            this.cmbPunetori.Location = new System.Drawing.Point(385, 78);
            this.cmbPunetori.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPunetori.Name = "cmbPunetori";
            this.cmbPunetori.Size = new System.Drawing.Size(132, 24);
            this.cmbPunetori.TabIndex = 18;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(385, 54);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 16);
            this.labelControl1.TabIndex = 19;
            this.labelControl1.Text = "Punetori";
            // 
            // btnAddKlienti
            // 
            this.btnAddKlienti.Location = new System.Drawing.Point(355, 78);
            this.btnAddKlienti.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddKlienti.Name = "btnAddKlienti";
            this.btnAddKlienti.Size = new System.Drawing.Size(23, 25);
            this.btnAddKlienti.TabIndex = 21;
            this.btnAddKlienti.Text = "+";
            this.btnAddKlienti.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnAddPunetori
            // 
            this.btnAddPunetori.Location = new System.Drawing.Point(527, 78);
            this.btnAddPunetori.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddPunetori.Name = "btnAddPunetori";
            this.btnAddPunetori.Size = new System.Drawing.Size(23, 25);
            this.btnAddPunetori.TabIndex = 22;
            this.btnAddPunetori.Text = "+";
            this.btnAddPunetori.Click += new System.EventHandler(this.button6_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(72, 54);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(79, 16);
            this.labelControl2.TabIndex = 24;
            this.labelControl2.Text = "Numer Fature";
            // 
            // NoFature
            // 
            this.NoFature.Location = new System.Drawing.Point(72, 78);
            this.NoFature.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NoFature.Name = "NoFature";
            this.NoFature.Properties.Mask.BeepOnError = true;
            this.NoFature.Properties.Mask.EditMask = "\\d+";
            this.NoFature.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.NoFature.Size = new System.Drawing.Size(133, 22);
            this.NoFature.TabIndex = 23;
            // 
            // gridFature
            // 
            this.gridFature.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.gridFature.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridFature.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.gridFature.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridFature.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridFature.Location = new System.Drawing.Point(751, 82);
            this.gridFature.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridFature.Name = "gridFature";
            this.gridFature.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridFature.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridFature.Size = new System.Drawing.Size(655, 235);
            this.gridFature.TabIndex = 25;
            this.gridFature.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridFature_CellClick);
            // 
            // txtTotal
            // 
            this.txtTotal.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.txtTotal.Appearance.Options.UseFont = true;
            this.txtTotal.Location = new System.Drawing.Point(1299, 325);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(54, 40);
            this.txtTotal.TabIndex = 26;
            this.txtTotal.Text = "200";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(1187, 325);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(93, 40);
            this.labelControl4.TabIndex = 27;
            this.labelControl4.Text = "Totali:";
            // 
            // btnAddArtikull
            // 
            this.btnAddArtikull.Location = new System.Drawing.Point(213, 71);
            this.btnAddArtikull.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddArtikull.Name = "btnAddArtikull";
            this.btnAddArtikull.Size = new System.Drawing.Size(23, 25);
            this.btnAddArtikull.TabIndex = 20;
            this.btnAddArtikull.Text = "+";
            this.btnAddArtikull.Click += new System.EventHandler(this.button4_Click);
            // 
            // Artikull
            // 
            this.Artikull.Location = new System.Drawing.Point(72, 48);
            this.Artikull.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Artikull.Name = "Artikull";
            this.Artikull.Size = new System.Drawing.Size(39, 16);
            this.Artikull.TabIndex = 6;
            this.Artikull.Text = "Artikull";
            // 
            // artikujtCmb
            // 
            this.artikujtCmb.FormattingEnabled = true;
            this.artikujtCmb.Location = new System.Drawing.Point(807, 423);
            this.artikujtCmb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.artikujtCmb.Name = "artikujtCmb";
            this.artikujtCmb.Size = new System.Drawing.Size(132, 24);
            this.artikujtCmb.TabIndex = 16;
            this.artikujtCmb.Visible = false;
            this.artikujtCmb.SelectedValueChanged += new System.EventHandler(this.artikujtCmb_SelectedValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(509, 49);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 26);
            this.button1.TabIndex = 28;
            this.button1.Text = "Refresh";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtArtikulli
            // 
            this.txtArtikulli.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtArtikulli.Location = new System.Drawing.Point(72, 71);
            this.txtArtikulli.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtArtikulli.Name = "txtArtikulli";
            this.txtArtikulli.Size = new System.Drawing.Size(132, 23);
            this.txtArtikulli.TabIndex = 29;
            this.txtArtikulli.Leave += new System.EventHandler(this.txtArtikulli_TextChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnAddPunetori);
            this.groupControl1.Controls.Add(this.Klienti);
            this.groupControl1.Controls.Add(this.cmbKlienti);
            this.groupControl1.Controls.Add(this.cmbPunetori);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.btnAddKlienti);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.NoFature);
            this.groupControl1.Location = new System.Drawing.Point(55, 82);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(643, 143);
            this.groupControl1.TabIndex = 30;
            this.groupControl1.Text = "Fatura";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.txtSasia);
            this.groupControl2.Controls.Add(this.txtCmimi);
            this.groupControl2.Controls.Add(this.txtArtikulli);
            this.groupControl2.Controls.Add(this.Artikull);
            this.groupControl2.Controls.Add(this.Sasia);
            this.groupControl2.Controls.Add(this.Cmimi);
            this.groupControl2.Controls.Add(this.btnAddArtikull);
            this.groupControl2.Controls.Add(this.SasiaMagazine);
            this.groupControl2.Location = new System.Drawing.Point(55, 231);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(643, 134);
            this.groupControl2.TabIndex = 31;
            this.groupControl2.Text = "Artikujt";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(55, 54);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(26, 16);
            this.labelControl3.TabIndex = 36;
            this.labelControl3.Text = "Data";
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(89, 52);
            this.dateEdit1.Margin = new System.Windows.Forms.Padding(4);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(133, 22);
            this.dateEdit1.TabIndex = 35;
            // 
            // Fature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.dateEdit1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.gridFature);
            this.Controls.Add(this.artikujtCmb);
            this.Controls.Add(this.btnShto);
            this.Controls.Add(this.btnPri);
            this.Controls.Add(this.btnPastro);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Fature";
            this.Size = new System.Drawing.Size(1456, 486);
            this.Load += new System.EventHandler(this.Fature_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSasia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCmimi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoFature.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txtSasia;
        private DevExpress.XtraEditors.TextEdit txtCmimi;
        private DevExpress.XtraEditors.LabelControl Sasia;
        private DevExpress.XtraEditors.LabelControl Cmimi;
        private DevExpress.XtraEditors.LabelControl Klienti;
        private DevExpress.XtraEditors.LabelControl SasiaMagazine;
        private DevExpress.XtraEditors.SimpleButton btnShto;
        private DevExpress.XtraEditors.SimpleButton btnPastro;
        private DevExpress.XtraEditors.SimpleButton btnPri;
        private System.Windows.Forms.ComboBox cmbKlienti;
        private System.Windows.Forms.ComboBox cmbPunetori;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnAddKlienti;
        private DevExpress.XtraEditors.SimpleButton btnAddPunetori;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit NoFature;
        private System.Windows.Forms.DataGridView gridFature;
        private DevExpress.XtraEditors.LabelControl txtTotal;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnAddArtikull;
        private DevExpress.XtraEditors.LabelControl Artikull;
        private System.Windows.Forms.ComboBox artikujtCmb;
        private DevExpress.XtraEditors.SimpleButton button1;
        private System.Windows.Forms.TextBox txtArtikulli;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
    }
}
