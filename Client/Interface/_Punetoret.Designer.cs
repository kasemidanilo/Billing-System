namespace Client.Interface
{
    partial class _Punetoret
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
            this.punetoretList = new DevExpress.XtraEditors.ListBoxControl();
            this.Save = new DevExpress.XtraEditors.SimpleButton();
            this.Mbiemri = new System.Windows.Forms.Label();
            this.Emri = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.punetoretList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // punetoretList
            // 
            this.punetoretList.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.punetoretList.Appearance.Options.UseFont = true;
            this.punetoretList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.punetoretList.HotTrackSelectMode = DevExpress.XtraEditors.HotTrackSelectMode.SelectItemOnClick;
            this.punetoretList.Location = new System.Drawing.Point(473, 67);
            this.punetoretList.Name = "punetoretList";
            this.punetoretList.Size = new System.Drawing.Size(243, 142);
            this.punetoretList.TabIndex = 15;
            this.punetoretList.Click += new System.EventHandler(this.artikujList_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(294, 186);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(141, 23);
            this.Save.TabIndex = 14;
            this.Save.Text = "Save";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Mbiemri
            // 
            this.Mbiemri.AutoSize = true;
            this.Mbiemri.Location = new System.Drawing.Point(181, 45);
            this.Mbiemri.Name = "Mbiemri";
            this.Mbiemri.Size = new System.Drawing.Size(43, 13);
            this.Mbiemri.TabIndex = 11;
            this.Mbiemri.Text = "Mbiemri";
            // 
            // Emri
            // 
            this.Emri.AutoSize = true;
            this.Emri.Location = new System.Drawing.Point(54, 44);
            this.Emri.Name = "Emri";
            this.Emri.Size = new System.Drawing.Size(27, 13);
            this.Emri.TabIndex = 10;
            this.Emri.Text = "Emri";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(57, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(184, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 16;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.textBox1);
            this.groupControl2.Controls.Add(this.textBox2);
            this.groupControl2.Controls.Add(this.Emri);
            this.groupControl2.Controls.Add(this.Mbiemri);
            this.groupControl2.Location = new System.Drawing.Point(41, 67);
            this.groupControl2.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(394, 113);
            this.groupControl2.TabIndex = 33;
            this.groupControl2.Text = "Punetoret";
            // 
            // _Punetoret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.punetoretList);
            this.Controls.Add(this.Save);
            this.Name = "_Punetoret";
            this.Size = new System.Drawing.Size(786, 273);
            ((System.ComponentModel.ISupportInitialize)(this.punetoretList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ListBoxControl punetoretList;
        private DevExpress.XtraEditors.SimpleButton Save;
        private System.Windows.Forms.Label Mbiemri;
        private System.Windows.Forms.Label Emri;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
    }
}
