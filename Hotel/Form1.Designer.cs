namespace Hotel
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.chb_1 = new System.Windows.Forms.CheckBox();
            this.cmb_2 = new System.Windows.Forms.ComboBox();
            this.cmb_1 = new System.Windows.Forms.ComboBox();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chb_1
            // 
            this.chb_1.AutoSize = true;
            this.chb_1.Location = new System.Drawing.Point(480, 108);
            this.chb_1.Name = "chb_1";
            this.chb_1.Size = new System.Drawing.Size(80, 17);
            this.chb_1.TabIndex = 0;
            this.chb_1.Text = "checkBox1";
            this.chb_1.UseVisualStyleBackColor = true;
            this.chb_1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cmb_2
            // 
            this.cmb_2.FormattingEnabled = true;
            this.cmb_2.Items.AddRange(new object[] {
            "BASE",
            "MEDIA",
            "ALTA"});
            this.cmb_2.Location = new System.Drawing.Point(480, 65);
            this.cmb_2.Name = "cmb_2";
            this.cmb_2.Size = new System.Drawing.Size(121, 21);
            this.cmb_2.TabIndex = 1;
            // 
            // cmb_1
            // 
            this.cmb_1.FormattingEnabled = true;
            this.cmb_1.Items.AddRange(new object[] {
            "BASSA STAGIONE",
            "MEDIA STAGIONE",
            "ALTA STAGIONE"});
            this.cmb_1.Location = new System.Drawing.Point(480, 13);
            this.cmb_1.Name = "cmb_1";
            this.cmb_1.Size = new System.Drawing.Size(121, 21);
            this.cmb_1.TabIndex = 2;
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Font = new System.Drawing.Font("Maiandra GD", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_1.Location = new System.Drawing.Point(120, 20);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(106, 32);
            this.lbl_1.TabIndex = 3;
            this.lbl_1.Text = "HOTEL";
            this.lbl_1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(126, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.cmb_1);
            this.Controls.Add(this.cmb_2);
            this.Controls.Add(this.chb_1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chb_1;
        private System.Windows.Forms.ComboBox cmb_2;
        private System.Windows.Forms.ComboBox cmb_1;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

