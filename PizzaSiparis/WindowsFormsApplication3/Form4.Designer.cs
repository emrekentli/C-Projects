namespace WindowsFormsApplication3
{
    partial class mailgonder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mailgonder));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblmesaj = new System.Windows.Forms.Label();
            this.lblbaslik = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(167, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "Maili Gönder!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(167, 165);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(191, 169);
            this.textBox4.TabIndex = 7;
            // 
            // lblmesaj
            // 
            this.lblmesaj.AutoSize = true;
            this.lblmesaj.BackColor = System.Drawing.Color.Transparent;
            this.lblmesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblmesaj.Location = new System.Drawing.Point(54, 165);
            this.lblmesaj.Name = "lblmesaj";
            this.lblmesaj.Size = new System.Drawing.Size(109, 17);
            this.lblmesaj.TabIndex = 6;
            this.lblmesaj.Text = "Mesaj İçeriği :";
            // 
            // lblbaslik
            // 
            this.lblbaslik.AutoSize = true;
            this.lblbaslik.BackColor = System.Drawing.Color.Transparent;
            this.lblbaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblbaslik.Location = new System.Drawing.Point(100, 136);
            this.lblbaslik.Name = "lblbaslik";
            this.lblbaslik.Size = new System.Drawing.Size(61, 17);
            this.lblbaslik.TabIndex = 5;
            this.lblbaslik.Text = "Başlık :";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(167, 139);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(191, 20);
            this.textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(167, 103);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(191, 20);
            this.textBox2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(40, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Gönderen Kişi :";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(167, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(18, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Gönderilecek Kişi :";
            // 
            // mailgonder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(441, 431);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.lblmesaj);
            this.Controls.Add(this.lblbaslik);
            this.Controls.Add(this.textBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mailgonder";
            this.Text = "Mail Gönderme ";
            this.Load += new System.EventHandler(this.mailgonder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblmesaj;
        private System.Windows.Forms.Label lblbaslik;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}