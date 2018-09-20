namespace Client.Interface
{
    partial class Klientet
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
            this.Save = new System.Windows.Forms.Button();
            this.lblArtikujt = new System.Windows.Forms.Label();
            this.Emri = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.artikujList)).BeginInit();
            this.SuspendLayout();
            // 
            // artikujList
            // 
            this.artikujList.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.artikujList.Appearance.Options.UseFont = true;
            this.artikujList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.artikujList.HotTrackSelectMode = DevExpress.XtraEditors.HotTrackSelectMode.SelectItemOnClick;
            this.artikujList.Location = new System.Drawing.Point(264, 69);
            this.artikujList.Name = "artikujList";
            this.artikujList.Size = new System.Drawing.Size(243, 166);
            this.artikujList.TabIndex = 15;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(84, 159);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 14;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Event);
            // 
            // lblArtikujt
            // 
            this.lblArtikujt.AutoSize = true;
            this.lblArtikujt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtikujt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblArtikujt.Location = new System.Drawing.Point(25, 34);
            this.lblArtikujt.Name = "lblArtikujt";
            this.lblArtikujt.Size = new System.Drawing.Size(105, 31);
            this.lblArtikujt.TabIndex = 12;
            this.lblArtikujt.Text = "Klientet";
            // 
            // Emri
            // 
            this.Emri.AutoSize = true;
            this.Emri.Location = new System.Drawing.Point(28, 120);
            this.Emri.Name = "Emri";
            this.Emri.Size = new System.Drawing.Size(27, 13);
            this.Emri.TabIndex = 10;
            this.Emri.Text = "Emri";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 9;
            // 
            // Klientet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.artikujList);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.lblArtikujt);
            this.Controls.Add(this.Emri);
            this.Controls.Add(this.textBox1);
            this.Name = "Klientet";
            this.Size = new System.Drawing.Size(538, 316);
            ((System.ComponentModel.ISupportInitialize)(this.artikujList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ListBoxControl artikujList;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label lblArtikujt;
        private System.Windows.Forms.Label Emri;
        private System.Windows.Forms.TextBox textBox1;
    }
}
