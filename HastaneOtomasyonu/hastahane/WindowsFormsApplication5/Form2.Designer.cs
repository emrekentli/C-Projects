namespace WindowsFormsApplication5
{
    partial class Form2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnGiris = new System.Windows.Forms.Button();
            this.btnParolamiUnuttum = new System.Windows.Forms.Button();
            this.btnYeniUye = new System.Windows.Forms.Button();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.maskedtxtTC = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblHastaneAdi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGiris
            // 
            this.btnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.Location = new System.Drawing.Point(398, 223);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(106, 40);
            this.btnGiris.TabIndex = 21;
            this.btnGiris.Text = "GİRİŞ";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // btnParolamiUnuttum
            // 
            this.btnParolamiUnuttum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnParolamiUnuttum.Location = new System.Drawing.Point(139, 223);
            this.btnParolamiUnuttum.Name = "btnParolamiUnuttum";
            this.btnParolamiUnuttum.Size = new System.Drawing.Size(170, 40);
            this.btnParolamiUnuttum.TabIndex = 23;
            this.btnParolamiUnuttum.Text = "PAROLAMI UNUTTUM";
            this.btnParolamiUnuttum.UseVisualStyleBackColor = true;
            this.btnParolamiUnuttum.Click += new System.EventHandler(this.btnParolamiUnuttum_Click);
            // 
            // btnYeniUye
            // 
            this.btnYeniUye.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniUye.Location = new System.Drawing.Point(33, 223);
            this.btnYeniUye.Name = "btnYeniUye";
            this.btnYeniUye.Size = new System.Drawing.Size(100, 40);
            this.btnYeniUye.TabIndex = 22;
            this.btnYeniUye.Text = "YENİ ÜYE";
            this.btnYeniUye.UseVisualStyleBackColor = true;
            this.btnYeniUye.Click += new System.EventHandler(this.btnYeniUye_Click);
            // 
            // txtParola
            // 
            this.txtParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtParola.Location = new System.Drawing.Point(195, 172);
            this.txtParola.MaxLength = 11;
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '●';
            this.txtParola.Size = new System.Drawing.Size(309, 35);
            this.txtParola.TabIndex = 20;
            // 
            // maskedtxtTC
            // 
            this.maskedtxtTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedtxtTC.Location = new System.Drawing.Point(195, 131);
            this.maskedtxtTC.Mask = "00000000000";
            this.maskedtxtTC.Name = "maskedtxtTC";
            this.maskedtxtTC.Size = new System.Drawing.Size(309, 35);
            this.maskedtxtTC.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(29, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Parola";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(29, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "T.C. Kimlik Numarası";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(236, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(74, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 64;
            this.pictureBox3.TabStop = false;
            // 
            // lblHastaneAdi
            // 
            this.lblHastaneAdi.AutoSize = true;
            this.lblHastaneAdi.BackColor = System.Drawing.Color.Transparent;
            this.lblHastaneAdi.Font = new System.Drawing.Font("Lucida Fax", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHastaneAdi.Location = new System.Drawing.Point(134, 53);
            this.lblHastaneAdi.Name = "lblHastaneAdi";
            this.lblHastaneAdi.Size = new System.Drawing.Size(290, 33);
            this.lblHastaneAdi.TabIndex = 63;
            this.lblHastaneAdi.Text = "PAMUK HOSPITAL";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 315);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblHastaneAdi);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.btnParolamiUnuttum);
            this.Controls.Add(this.btnYeniUye);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.maskedtxtTC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Pamuk Hastanesi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Button btnParolamiUnuttum;
        private System.Windows.Forms.Button btnYeniUye;
        private System.Windows.Forms.TextBox txtParola;
        public System.Windows.Forms.MaskedTextBox maskedtxtTC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblHastaneAdi;
    }
}