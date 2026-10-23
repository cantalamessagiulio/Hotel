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
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chb_1
            // 
            this.chb_1.AutoSize = true;
            this.chb_1.BackColor = System.Drawing.SystemColors.Control;
            this.chb_1.Location = new System.Drawing.Point(467, 224);
            this.chb_1.Name = "chb_1";
            this.chb_1.Size = new System.Drawing.Size(80, 17);
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
            this.cmb_2.Location = new System.Drawing.Point(467, 154);
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
            this.cmb_1.Location = new System.Drawing.Point(467, 107);
            this.cmb_1.Name = "cmb_1";
            this.cmb_1.Size = new System.Drawing.Size(121, 21);
            this.cmb_1.TabIndex = 2;

            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Font = new System.Drawing.Font("Maiandra GD", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_1.Location = new System.Drawing.Point(10, 16);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(616, 57);
            this.lbl_1.TabIndex = 3;
            this.lbl_1.Text = "CANTA\'S GRANDE HOTEL";
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(467, 260);
            this.btn_1.Margin = new System.Windows.Forms.Padding(2);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(127, 41);
            this.btn_1.TabIndex = 4;
            this.btn_1.Text = "CALCOLA IL TOTALE E PRENOTA";
            this.btn_1.UseVisualStyleBackColor = true;
       
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_2.Location = new System.Drawing.Point(467, 89);
            this.lbl_2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(64, 15);
            this.lbl_2.TabIndex = 5;
            this.lbl_2.Text = "STAGIONE";
            // 
            // lbl_3
            // 
            this.lbl_3.AutoSize = true;
            this.lbl_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_3.Location = new System.Drawing.Point(465, 138);
            this.lbl_3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_3.Name = "lbl_3";
            this.lbl_3.Size = new System.Drawing.Size(52, 13);
            this.lbl_3.TabIndex = 6;
            this.lbl_3.Text = "CAMERA";
            // 
            // lbl_4
            // 
            this.lbl_4.AutoSize = true;
            this.lbl_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_4.Location = new System.Drawing.Point(465, 185);
            this.lbl_4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_4.Name = "lbl_4";
            this.lbl_4.Size = new System.Drawing.Size(110, 13);
            this.lbl_4.TabIndex = 8;
            this.lbl_4.Text = "NUMERO DI GIORNI";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 75);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(378, 318);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // txt_1
            // 
            this.txt_1.Location = new System.Drawing.Point(467, 201);
            this.txt_1.Margin = new System.Windows.Forms.Padding(2);
            this.txt_1.Name = "txt_1";
            this.txt_1.Size = new System.Drawing.Size(76, 20);
            this.txt_1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(585, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(19, 22);
            this.button1.TabIndex = 10;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbl_5
            // 
            this.lbl_5.AutoSize = true;
            this.lbl_5.Location = new System.Drawing.Point(409, 371);
            this.lbl_5.Name = "lbl_5";
            this.lbl_5.Size = new System.Drawing.Size(170, 13);
            this.lbl_5.TabIndex = 11;
            this.lbl_5.Text = "Per informazioni premere il tasto -->";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 450);
            this.Controls.Add(this.lbl_5);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_5;
    }
}

