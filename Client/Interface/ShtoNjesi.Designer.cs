namespace Client.Interface
{
    partial class ShtoNjesi
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
            this.artikujList = new DevExpress.XtraEditors.ListBoxControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Njesia = new System.Windows.Forms.Label();
            this.lblArtikujt = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.artikujList)).BeginInit();
            this.SuspendLayout();
            // 
            // artikujList
            // 
            this.artikujList.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.artikujList.Appearance.Options.UseFont = true;
            this.artikujList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.artikujList.HotTrackSelectMode = DevExpress.XtraEditors.HotTrackSelectMode.SelectItemOnClick;
            this.artikujList.Location = new System.Drawing.Point(237, 69);
            this.artikujList.Name = "artikujList";
            this.artikujList.Size = new System.Drawing.Size(207, 194);
            this.artikujList.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 126);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 10;
            // 
            // Njesia
            // 
            this.Njesia.AutoSize = true;
            this.Njesia.Location = new System.Drawing.Point(47, 129);
            this.Njesia.Name = "Njesia";
            this.Njesia.Size = new System.Drawing.Size(36, 13);
            this.Njesia.TabIndex = 11;
            this.Njesia.Text = "Njesia";
            // 
            // lblArtikujt
            // 
            this.lblArtikujt.AutoSize = true;
            this.lblArtikujt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtikujt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblArtikujt.Location = new System.Drawing.Point(44, 26);
            this.lblArtikujt.Name = "lblArtikujt";
            this.lblArtikujt.Size = new System.Drawing.Size(98, 31);
            this.lblArtikujt.TabIndex = 12;
            this.lblArtikujt.Text = "Njesite";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(89, 171);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 13;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // ShtoNjesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Save);
            this.Controls.Add(this.lblArtikujt);
            this.Controls.Add(this.Njesia);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.artikujList);
            this.Name = "ShtoNjesi";
            this.Size = new System.Drawing.Size(479, 348);
            ((System.ComponentModel.ISupportInitialize)(this.artikujList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ListBoxControl artikujList;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Njesia;
        private System.Windows.Forms.Label lblArtikujt;
        private System.Windows.Forms.Button Save;
    }
}
