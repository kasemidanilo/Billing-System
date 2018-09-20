namespace Client.Interface
{
    partial class UpdateDeletePunetoret
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblPunetoret = new System.Windows.Forms.Label();
            this.Mbiemri = new System.Windows.Forms.Label();
            this.Emri = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Fshi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(107, 155);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 22;
            // 
            // lblPunetoret
            // 
            this.lblPunetoret.AutoSize = true;
            this.lblPunetoret.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPunetoret.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblPunetoret.Location = new System.Drawing.Point(48, 28);
            this.lblPunetoret.Name = "lblPunetoret";
            this.lblPunetoret.Size = new System.Drawing.Size(132, 31);
            this.lblPunetoret.TabIndex = 20;
            this.lblPunetoret.Text = "Punetoret";
            // 
            // Mbiemri
            // 
            this.Mbiemri.AutoSize = true;
            this.Mbiemri.Location = new System.Drawing.Point(51, 158);
            this.Mbiemri.Name = "Mbiemri";
            this.Mbiemri.Size = new System.Drawing.Size(43, 13);
            this.Mbiemri.TabIndex = 19;
            this.Mbiemri.Text = "Mbiemri";
            // 
            // Emri
            // 
            this.Emri.AutoSize = true;
            this.Emri.Location = new System.Drawing.Point(51, 114);
            this.Emri.Name = "Emri";
            this.Emri.Size = new System.Drawing.Size(27, 13);
            this.Emri.TabIndex = 18;
            this.Emri.Text = "Emri";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 17;
            // 
            // Fshi
            // 
            this.Fshi.Location = new System.Drawing.Point(169, 213);
            this.Fshi.Name = "Fshi";
            this.Fshi.Size = new System.Drawing.Size(75, 23);
            this.Fshi.TabIndex = 24;
            this.Fshi.Text = "Fshi";
            this.Fshi.UseVisualStyleBackColor = true;
            this.Fshi.Click += new System.EventHandler(this.Fshi_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Save_Click);
            // 
            // UpdateDeletePunetoret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Fshi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblPunetoret);
            this.Controls.Add(this.Mbiemri);
            this.Controls.Add(this.Emri);
            this.Controls.Add(this.textBox1);
            this.Name = "UpdateDeletePunetoret";
            this.Size = new System.Drawing.Size(293, 283);
            this.Load += new System.EventHandler(this.UpdateDeletePunetoret_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblPunetoret;
        private System.Windows.Forms.Label Mbiemri;
        private System.Windows.Forms.Label Emri;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Fshi;
        private System.Windows.Forms.Button button1;
    }
}
