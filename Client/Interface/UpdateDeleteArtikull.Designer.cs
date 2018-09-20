namespace Client.Interface
{
    partial class UpdateDeleteArtikull
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
            this.Save = new System.Windows.Forms.Button();
            this.njesiaCmb = new System.Windows.Forms.ComboBox();
            this.Njesia = new System.Windows.Forms.Label();
            this.Emri = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblArtikujt = new System.Windows.Forms.Label();
            this.Fshi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(108, 195);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 12;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // njesiaCmb
            // 
            this.njesiaCmb.FormattingEnabled = true;
            this.njesiaCmb.Location = new System.Drawing.Point(125, 145);
            this.njesiaCmb.Name = "njesiaCmb";
            this.njesiaCmb.Size = new System.Drawing.Size(121, 21);
            this.njesiaCmb.TabIndex = 11;
            // 
            // Njesia
            // 
            this.Njesia.AutoSize = true;
            this.Njesia.Location = new System.Drawing.Point(69, 148);
            this.Njesia.Name = "Njesia";
            this.Njesia.Size = new System.Drawing.Size(36, 13);
            this.Njesia.TabIndex = 10;
            this.Njesia.Text = "Njesia";
            // 
            // Emri
            // 
            this.Emri.AutoSize = true;
            this.Emri.Location = new System.Drawing.Point(69, 104);
            this.Emri.Name = "Emri";
            this.Emri.Size = new System.Drawing.Size(27, 13);
            this.Emri.TabIndex = 9;
            this.Emri.Text = "Emri";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 8;
            // 
            // lblArtikujt
            // 
            this.lblArtikujt.AutoSize = true;
            this.lblArtikujt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtikujt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblArtikujt.Location = new System.Drawing.Point(128, 23);
            this.lblArtikujt.Name = "lblArtikujt";
            this.lblArtikujt.Size = new System.Drawing.Size(102, 31);
            this.lblArtikujt.TabIndex = 13;
            this.lblArtikujt.Text = "Artikulli";
            // 
            // Fshi
            // 
            this.Fshi.Location = new System.Drawing.Point(189, 195);
            this.Fshi.Name = "Fshi";
            this.Fshi.Size = new System.Drawing.Size(75, 23);
            this.Fshi.TabIndex = 14;
            this.Fshi.Text = "Fshi";
            this.Fshi.UseVisualStyleBackColor = true;
            this.Fshi.Click += new System.EventHandler(this.Fshi_Click);
            // 
            // UpdateDeleteArtikull
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Fshi);
            this.Controls.Add(this.lblArtikujt);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.njesiaCmb);
            this.Controls.Add(this.Njesia);
            this.Controls.Add(this.Emri);
            this.Controls.Add(this.textBox1);
            this.Name = "UpdateDeleteArtikull";
            this.Size = new System.Drawing.Size(376, 284);
            this.Load += new System.EventHandler(this.UpdateDeleteArtikull_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.ComboBox njesiaCmb;
        private System.Windows.Forms.Label Njesia;
        private System.Windows.Forms.Label Emri;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblArtikujt;
        private System.Windows.Forms.Button Fshi;
    }
}
