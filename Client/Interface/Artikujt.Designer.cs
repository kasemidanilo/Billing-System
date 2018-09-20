namespace Client.Interface
{
    partial class Artikujt
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Emri = new System.Windows.Forms.Label();
            this.Njesia = new System.Windows.Forms.Label();
            this.njesiaCmb = new System.Windows.Forms.ComboBox();
            this.artikujList = new DevExpress.XtraEditors.ListBoxControl();
            this.Save = new DevExpress.XtraEditors.SimpleButton();
            this.button1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.artikujList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(57, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Emri
            // 
            this.Emri.AutoSize = true;
            this.Emri.Location = new System.Drawing.Point(54, 44);
            this.Emri.Name = "Emri";
            this.Emri.Size = new System.Drawing.Size(27, 13);
            this.Emri.TabIndex = 2;
            this.Emri.Text = "Emri";
            this.Emri.Click += new System.EventHandler(this.Emri_Click);
            // 
            // Njesia
            // 
            this.Njesia.AutoSize = true;
            this.Njesia.Location = new System.Drawing.Point(184, 45);
            this.Njesia.Name = "Njesia";
            this.Njesia.Size = new System.Drawing.Size(36, 13);
            this.Njesia.TabIndex = 3;
            this.Njesia.Text = "Njesia";
            // 
            // njesiaCmb
            // 
            this.njesiaCmb.FormattingEnabled = true;
            this.njesiaCmb.Location = new System.Drawing.Point(184, 61);
            this.njesiaCmb.Name = "njesiaCmb";
            this.njesiaCmb.Size = new System.Drawing.Size(121, 21);
            this.njesiaCmb.TabIndex = 6;
            // 
            // artikujList
            // 
            this.artikujList.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.artikujList.Appearance.Options.UseFont = true;
            this.artikujList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.artikujList.HotTrackSelectMode = DevExpress.XtraEditors.HotTrackSelectMode.SelectItemOnClick;
            this.artikujList.Location = new System.Drawing.Point(473, 67);
            this.artikujList.Name = "artikujList";
            this.artikujList.Size = new System.Drawing.Size(243, 142);
            this.artikujList.TabIndex = 8;
            this.artikujList.Click += new System.EventHandler(this.artikujList_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(294, 186);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(141, 23);
            this.Save.TabIndex = 7;
            this.Save.Text = "Save";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(311, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(19, 20);
            this.button1.TabIndex = 9;
            this.button1.Text = "+";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.njesiaCmb);
            this.groupControl2.Controls.Add(this.button1);
            this.groupControl2.Controls.Add(this.Njesia);
            this.groupControl2.Controls.Add(this.textBox1);
            this.groupControl2.Controls.Add(this.Emri);
            this.groupControl2.Location = new System.Drawing.Point(41, 67);
            this.groupControl2.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(394, 113);
            this.groupControl2.TabIndex = 32;
            this.groupControl2.Text = "Artikujt";
            // 
            // Artikujt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.artikujList);
            this.Controls.Add(this.Save);
            this.Name = "Artikujt";
            this.Size = new System.Drawing.Size(810, 276);
            ((System.ComponentModel.ISupportInitialize)(this.artikujList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Emri;
        private System.Windows.Forms.Label Njesia;
        private System.Windows.Forms.ComboBox njesiaCmb;
        private DevExpress.XtraEditors.ListBoxControl artikujList;
        private DevExpress.XtraEditors.SimpleButton Save;
        private DevExpress.XtraEditors.SimpleButton button1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
    }
}
