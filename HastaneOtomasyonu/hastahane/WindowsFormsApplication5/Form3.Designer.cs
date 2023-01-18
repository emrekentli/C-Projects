namespace WindowsFormsApplication5
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderKlinikAdii = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDoktorAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSaat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNo,
            this.columnHeaderKlinikAdii,
            this.columnHeaderDoktorAdi,
            this.columnHeaderTarih,
            this.columnHeaderSaat,
            this.columnHeaderid});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.Location = new System.Drawing.Point(12, 43);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(926, 200);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderNo
            // 
            this.columnHeaderNo.Text = "No";
            // 
            // columnHeaderKlinikAdii
            // 
            this.columnHeaderKlinikAdii.Text = "Klinik Adı";
            this.columnHeaderKlinikAdii.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderKlinikAdii.Width = 383;
            // 
            // columnHeaderDoktorAdi
            // 
            this.columnHeaderDoktorAdi.Text = "Doktor";
            this.columnHeaderDoktorAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderDoktorAdi.Width = 234;
            // 
            // columnHeaderTarih
            // 
            this.columnHeaderTarih.Text = "Tarih";
            this.columnHeaderTarih.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderTarih.Width = 122;
            // 
            // columnHeaderSaat
            // 
            this.columnHeaderSaat.Text = "Saat";
            this.columnHeaderSaat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderSaat.Width = 79;
            // 
            // columnHeaderid
            // 
            this.columnHeaderid.Text = "R.Kodu";
            this.columnHeaderid.Width = 50;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(814, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "İptal ET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 314);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Alınan Randevular";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderNo;
        private System.Windows.Forms.ColumnHeader columnHeaderKlinikAdii;
        private System.Windows.Forms.ColumnHeader columnHeaderDoktorAdi;
        private System.Windows.Forms.ColumnHeader columnHeaderTarih;
        private System.Windows.Forms.ColumnHeader columnHeaderSaat;
        private System.Windows.Forms.ColumnHeader columnHeaderid;
        private System.Windows.Forms.Button button1;
    }
}