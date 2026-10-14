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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chb_1 = new System.Windows.Forms.CheckBox();
            this.cmb_2 = new System.Windows.Forms.ComboBox();
            this.cmb_1 = new System.Windows.Forms.ComboBox();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.btn_1 = new System.Windows.Forms.Button();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.lbl_3 = new System.Windows.Forms.Label();
            this.lbl_4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chb_1
            // 
            this.chb_1.AutoSize = true;
            this.chb_1.BackColor = System.Drawing.SystemColors.Control;
            this.chb_1.Location = new System.Drawing.Point(623, 276);
            this.chb_1.Margin = new System.Windows.Forms.Padding(4);
            this.chb_1.Name = "chb_1";
            this.chb_1.Size = new System.Drawing.Size(99, 20);
            this.chb_1.TabIndex = 0;
            this.chb_1.Text = "Parcheggio";
            this.chb_1.UseVisualStyleBackColor = false;
            // 
            // cmb_2
            // 
            this.cmb_2.FormattingEnabled = true;
            this.cmb_2.Items.AddRange(new object[] {
            "BASE",
            "MEDIA",
            "ALTA"});
            this.cmb_2.Location = new System.Drawing.Point(623, 190);
            this.cmb_2.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_2.Name = "cmb_2";
            this.cmb_2.Size = new System.Drawing.Size(160, 24);
            this.cmb_2.TabIndex = 1;

            // 
            // cmb_1
            // 
            this.cmb_1.FormattingEnabled = true;
            this.cmb_1.Items.AddRange(new object[] {
            "BASSA STAGIONE",
            "MEDIA STAGIONE",
            "ALTA STAGIONE"});
            this.cmb_1.Location = new System.Drawing.Point(623, 132);
            this.cmb_1.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_1.Name = "cmb_1";
            this.cmb_1.Size = new System.Drawing.Size(160, 24);
            this.cmb_1.TabIndex = 2;
            this.cmb_1.SelectedIndexChanged += new System.EventHandler(this.cmb_1_SelectedIndexChanged);
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Font = new System.Drawing.Font("Maiandra GD", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_1.Location = new System.Drawing.Point(13, 20);
            this.lbl_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(764, 72);
            this.lbl_1.TabIndex = 3;
            this.lbl_1.Text = "CANTA\'S GRANDE HOTEL";
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(623, 320);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(169, 51);
            this.btn_1.TabIndex = 4;
            this.btn_1.Text = "CALCOLA IL TOTALE E PRENOTA";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_2.Location = new System.Drawing.Point(623, 110);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(78, 18);
            this.lbl_2.TabIndex = 5;
            this.lbl_2.Text = "STAGIONE";
            // 
            // lbl_3
            // 
            this.lbl_3.AutoSize = true;
            this.lbl_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_3.Location = new System.Drawing.Point(620, 170);
            this.lbl_3.Name = "lbl_3";
            this.lbl_3.Size = new System.Drawing.Size(64, 16);
            this.lbl_3.TabIndex = 6;
            this.lbl_3.Text = "CAMERA";
            // 
            // lbl_4
            // 
            this.lbl_4.AutoSize = true;
            this.lbl_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_4.Location = new System.Drawing.Point(620, 228);
            this.lbl_4.Name = "lbl_4";
            this.lbl_4.Size = new System.Drawing.Size(132, 16);
            this.lbl_4.TabIndex = 8;
            this.lbl_4.Text = "NUMERO DI GIORNI";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(527, 424);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // txt_1
            // 
            this.txt_1.Location = new System.Drawing.Point(623, 247);
            this.txt_1.Name = "txt_1";
            this.txt_1.Size = new System.Drawing.Size(100, 22);
            this.txt_1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 554);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_4);
            this.Controls.Add(this.txt_1);
            this.Controls.Add(this.lbl_3);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.cmb_1);
            this.Controls.Add(this.cmb_2);
            this.Controls.Add(this.chb_1);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.Label lbl_3;
        private System.Windows.Forms.Label lbl_4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_1;
    }
}

