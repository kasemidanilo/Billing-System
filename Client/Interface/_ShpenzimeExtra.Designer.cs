namespace Client.Interface
{
    partial class _ShpenzimeExtra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnShto = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtTotal = new DevExpress.XtraEditors.LabelControl();
            this.btnPri = new DevExpress.XtraEditors.SimpleButton();
            this.btnPastro = new DevExpress.XtraEditors.SimpleButton();
            this.gridFature = new System.Windows.Forms.DataGridView();
            this.lblNjesia = new DevExpress.XtraEditors.LabelControl();
            this.Cmimi = new DevExpress.XtraEditors.LabelControl();
            this.txtCmimi = new DevExpress.XtraEditors.TextEdit();
            this.Sasia = new DevExpress.XtraEditors.LabelControl();
            this.txtSasia = new DevExpress.XtraEditors.TextEdit();
            this.btnAddPunetori = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmbPunetori = new System.Windows.Forms.ComboBox();
            this.txtEmertimi = new DevExpress.XtraEditors.LabelControl();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.txtPershkrimi = new System.Windows.Forms.TextBox();
            this.button2 = new DevExpress.XtraEditors.SimpleButton();
            this.button3 = new DevExpress.XtraEditors.SimpleButton();
            this.njesiaCmb = new System.Windows.Forms.ComboBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.Pershkrimi = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridFature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCmimi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSasia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pershkrimi)).BeginInit();
            this.Pershkrimi.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShto
            // 
            this.btnShto.Location = new System.Drawing.Point(382, 418);
            this.btnShto.Name = "btnShto";
            this.btnShto.Size = new System.Drawing.Size(141, 23);
            this.btnShto.TabIndex = 55;
            this.btnShto.Text = "Shto ne fature";
            this.btnShto.Click += new System.EventHandler(this.btnShto_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.labelControl4.Location = new System.Drawing.Point(890, 379);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(76, 33);
            this.labelControl4.TabIndex = 54;
            this.labelControl4.Text = "Totali:";
            // 
            // txtTotal
            // 
            this.txtTotal.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.txtTotal.Location = new System.Drawing.Point(974, 379);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(45, 33);
            this.txtTotal.TabIndex = 53;
            this.txtTotal.Text = "200";
            // 
            // btnPri
            // 
            this.btnPri.Location = new System.Drawing.Point(757, 420);
            this.btnPri.Name = "btnPri";
            this.btnPri.Size = new System.Drawing.Size(141, 21);
            this.btnPri.TabIndex = 52;
            this.btnPri.Text = "Pri Faturen";
            this.btnPri.Click += new System.EventHandler(this.SaveFature);
            // 
            // btnPastro
            // 
            this.btnPastro.Location = new System.Drawing.Point(904, 420);
            this.btnPastro.Name = "btnPastro";
            this.btnPastro.Size = new System.Drawing.Size(141, 21);
            this.btnPastro.TabIndex = 51;
            this.btnPastro.Text = "Pastro";
            this.btnPastro.Click += new System.EventHandler(this.Clear);
            // 
            // gridFature
            // 
            this.gridFature.AllowUserToAddRows = false;
            this.gridFature.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.gridFature.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridFature.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridFature.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridFature.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFature.Location = new System.Drawing.Point(563, 67);
            this.gridFature.Name = "gridFature";
            this.gridFature.ReadOnly = true;
            this.gridFature.Size = new System.Drawing.Size(491, 306);
            this.gridFature.TabIndex = 50;
            // 
            // lblNjesia
            // 
            this.lblNjesia.Location = new System.Drawing.Point(372, 39);
            this.lblNjesia.Name = "lblNjesia";
            this.lblNjesia.Size = new System.Drawing.Size(29, 13);
            this.lblNjesia.TabIndex = 49;
            this.lblNjesia.Text = "Njesia";
            // 
            // Cmimi
            // 
            this.Cmimi.Location = new System.Drawing.Point(266, 39);
            this.Cmimi.Name = "Cmimi";
            this.Cmimi.Size = new System.Drawing.Size(27, 13);
            this.Cmimi.TabIndex = 47;
            this.Cmimi.Text = "Cmimi";
            // 
            // txtCmimi
            // 
            this.txtCmimi.Location = new System.Drawing.Point(266, 58);
            this.txtCmimi.Name = "txtCmimi";
            this.txtCmimi.Properties.Mask.BeepOnError = true;
            this.txtCmimi.Properties.Mask.EditMask = "n2";
            this.txtCmimi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCmimi.Size = new System.Drawing.Size(100, 20);
            this.txtCmimi.TabIndex = 46;
            // 
            // Sasia
            // 
            this.Sasia.Location = new System.Drawing.Point(160, 39);
            this.Sasia.Name = "Sasia";
            this.Sasia.Size = new System.Drawing.Size(25, 13);
            this.Sasia.TabIndex = 45;
            this.Sasia.Text = "Sasia";
            // 
            // txtSasia
            // 
            this.txtSasia.Location = new System.Drawing.Point(160, 58);
            this.txtSasia.Name = "txtSasia";
            this.txtSasia.Properties.Mask.BeepOnError = true;
            this.txtSasia.Properties.Mask.EditMask = "n2";
            this.txtSasia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSasia.Size = new System.Drawing.Size(100, 20);
            this.txtSasia.TabIndex = 44;
            this.txtSasia.Validated += new System.EventHandler(this.validateSasia);
            // 
            // btnAddPunetori
            // 
            this.btnAddPunetori.Location = new System.Drawing.Point(160, 63);
            this.btnAddPunetori.Name = "btnAddPunetori";
            this.btnAddPunetori.Size = new System.Drawing.Size(17, 21);
            this.btnAddPunetori.TabIndex = 43;
            this.btnAddPunetori.Text = "+";
            this.btnAddPunetori.Click += new System.EventHandler(this.button6_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(54, 44);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 13);
            this.labelControl1.TabIndex = 42;
            this.labelControl1.Text = "Punetori";
            // 
            // cmbPunetori
            // 
            this.cmbPunetori.FormattingEnabled = true;
            this.cmbPunetori.Location = new System.Drawing.Point(54, 63);
            this.cmbPunetori.Name = "cmbPunetori";
            this.cmbPunetori.Size = new System.Drawing.Size(100, 21);
            this.cmbPunetori.TabIndex = 41;
            // 
            // txtEmertimi
            // 
            this.txtEmertimi.Location = new System.Drawing.Point(54, 39);
            this.txtEmertimi.Name = "txtEmertimi";
            this.txtEmertimi.Size = new System.Drawing.Size(40, 13);
            this.txtEmertimi.TabIndex = 38;
            this.txtEmertimi.Text = "Emertimi";
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(54, 58);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(100, 20);
            this.textEdit2.TabIndex = 56;
            // 
            // txtPershkrimi
            // 
            this.txtPershkrimi.Location = new System.Drawing.Point(54, 39);
            this.txtPershkrimi.Multiline = true;
            this.txtPershkrimi.Name = "txtPershkrimi";
            this.txtPershkrimi.Size = new System.Drawing.Size(377, 52);
            this.txtPershkrimi.TabIndex = 57;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(437, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(17, 21);
            this.button2.TabIndex = 59;
            this.button2.Text = "+";
            this.button2.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(382, 40);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 21);
            this.button3.TabIndex = 60;
            this.button3.Text = "Refresh";
            this.button3.Click += new System.EventHandler(this.button1_Click);
            // 
            // njesiaCmb
            // 
            this.njesiaCmb.FormattingEnabled = true;
            this.njesiaCmb.Location = new System.Drawing.Point(372, 58);
            this.njesiaCmb.Name = "njesiaCmb";
            this.njesiaCmb.Size = new System.Drawing.Size(59, 21);
            this.njesiaCmb.TabIndex = 61;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.cmbPunetori);
            this.groupControl1.Controls.Add(this.btnAddPunetori);
            this.groupControl1.Location = new System.Drawing.Point(41, 67);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(482, 116);
            this.groupControl1.TabIndex = 62;
            this.groupControl1.Text = "Fatura";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.njesiaCmb);
            this.groupControl2.Controls.Add(this.txtEmertimi);
            this.groupControl2.Controls.Add(this.txtSasia);
            this.groupControl2.Controls.Add(this.Sasia);
            this.groupControl2.Controls.Add(this.button2);
            this.groupControl2.Controls.Add(this.txtCmimi);
            this.groupControl2.Controls.Add(this.Cmimi);
            this.groupControl2.Controls.Add(this.lblNjesia);
            this.groupControl2.Controls.Add(this.textEdit2);
            this.groupControl2.Location = new System.Drawing.Point(41, 188);
            this.groupControl2.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(482, 109);
            this.groupControl2.TabIndex = 63;
            this.groupControl2.Text = "Artikujt";
            // 
            // Pershkrimi
            // 
            this.Pershkrimi.Controls.Add(this.txtPershkrimi);
            this.Pershkrimi.Location = new System.Drawing.Point(41, 303);
            this.Pershkrimi.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.Pershkrimi.Name = "Pershkrimi";
            this.Pershkrimi.Size = new System.Drawing.Size(482, 109);
            this.Pershkrimi.TabIndex = 64;
            this.Pershkrimi.Text = "Pershkrimi";
            // 
            // _ShpenzimeExtra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Pershkrimi);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnShto);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnPri);
            this.Controls.Add(this.btnPastro);
            this.Controls.Add(this.gridFature);
            this.Name = "_ShpenzimeExtra";
            this.Size = new System.Drawing.Size(1141, 493);
            this.Load += new System.EventHandler(this.FleteHyrje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridFature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCmimi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSasia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pershkrimi)).EndInit();
            this.Pershkrimi.ResumeLayout(false);
            this.Pershkrimi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnShto;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl txtTotal;
        private DevExpress.XtraEditors.SimpleButton btnPri;
        private DevExpress.XtraEditors.SimpleButton btnPastro;
        private System.Windows.Forms.DataGridView gridFature;
        private DevExpress.XtraEditors.LabelControl lblNjesia;
        private DevExpress.XtraEditors.LabelControl Cmimi;
        private DevExpress.XtraEditors.TextEdit txtCmimi;
        private DevExpress.XtraEditors.LabelControl Sasia;
        private DevExpress.XtraEditors.TextEdit txtSasia;
        private DevExpress.XtraEditors.SimpleButton btnAddPunetori;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox cmbPunetori;
        private DevExpress.XtraEditors.LabelControl txtEmertimi;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private System.Windows.Forms.TextBox txtPershkrimi;
        private DevExpress.XtraEditors.SimpleButton button2;
        private DevExpress.XtraEditors.SimpleButton button3;
        private System.Windows.Forms.ComboBox njesiaCmb;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl Pershkrimi;
    }
}
