namespace OdevGP2
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
            this.gridViewAraba = new System.Windows.Forms.DataGridView();
            this.cbxYakit = new System.Windows.Forms.ComboBox();
            this.cbxKasa = new System.Windows.Forms.ComboBox();
            this.cbxVites = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtModelDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFiyat = new System.Windows.Forms.MaskedTextBox();
            this.txtKm = new System.Windows.Forms.MaskedTextBox();
            this.cbxModel = new System.Windows.Forms.ComboBox();
            this.cbxMarka = new System.Windows.Forms.ComboBox();
            this.btnAracEkle = new System.Windows.Forms.Button();
            this.cbxDurum = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnYenile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAraba)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridViewAraba
            // 
            this.gridViewAraba.AllowUserToAddRows = false;
            this.gridViewAraba.AllowUserToDeleteRows = false;
            this.gridViewAraba.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.gridViewAraba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewAraba.GridColor = System.Drawing.Color.DarkGray;
            this.gridViewAraba.Location = new System.Drawing.Point(16, 9);
            this.gridViewAraba.Name = "gridViewAraba";
            this.gridViewAraba.ReadOnly = true;
            this.gridViewAraba.Size = new System.Drawing.Size(750, 560);
            this.gridViewAraba.TabIndex = 7;
            this.gridViewAraba.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewAraba_CellContentClick);
            // 
            // cbxYakit
            // 
            this.cbxYakit.FormattingEnabled = true;
            this.cbxYakit.Items.AddRange(new object[] {
            "LPG + BENZİN",
            "BENZİN",
            "DİZEL",
            "HİBRİT"});
            this.cbxYakit.Location = new System.Drawing.Point(446, 245);
            this.cbxYakit.MaxLength = 50;
            this.cbxYakit.Name = "cbxYakit";
            this.cbxYakit.Size = new System.Drawing.Size(191, 39);
            this.cbxYakit.TabIndex = 2;
            // 
            // cbxKasa
            // 
            this.cbxKasa.FormattingEnabled = true;
            this.cbxKasa.Items.AddRange(new object[] {
            "Sedan",
            "Hatchback",
            "Pick up",
            "Cabrio"});
            this.cbxKasa.Location = new System.Drawing.Point(446, 298);
            this.cbxKasa.MaxLength = 50;
            this.cbxKasa.Name = "cbxKasa";
            this.cbxKasa.Size = new System.Drawing.Size(191, 39);
            this.cbxKasa.TabIndex = 2;
            // 
            // cbxVites
            // 
            this.cbxVites.FormattingEnabled = true;
            this.cbxVites.Items.AddRange(new object[] {
            "Otomatik",
            "Manuel",
            "Yarı Otomatik"});
            this.cbxVites.Location = new System.Drawing.Point(446, 192);
            this.cbxVites.MaxLength = 50;
            this.cbxVites.Name = "cbxVites";
            this.cbxVites.Size = new System.Drawing.Size(191, 39);
            this.cbxVites.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(292, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marka";
            // 
            // txtPlaka
            // 
            this.txtPlaka.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPlaka.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPlaka.Location = new System.Drawing.Point(446, 403);
            this.txtPlaka.MaxLength = 10;
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(191, 38);
            this.txtPlaka.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(292, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Model";
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(151, 574);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(161, 53);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Enabled = false;
            this.btnGüncelle.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGüncelle.Location = new System.Drawing.Point(466, 561);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(161, 53);
            this.btnGüncelle.TabIndex = 3;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(292, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "Yakıt Türü";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(292, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 31);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kasa Tipi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(290, 408);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 31);
            this.label8.TabIndex = 1;
            this.label8.Text = "Plaka";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(294, 461);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 31);
            this.label7.TabIndex = 1;
            this.label7.Text = "Fiyat";
            // 
            // txtModelDate
            // 
            this.txtModelDate.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtModelDate.Location = new System.Drawing.Point(446, 140);
            this.txtModelDate.MaxLength = 5;
            this.txtModelDate.Name = "txtModelDate";
            this.txtModelDate.Size = new System.Drawing.Size(191, 38);
            this.txtModelDate.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(291, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 31);
            this.label5.TabIndex = 1;
            this.label5.Text = "Vites";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(291, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 31);
            this.label6.TabIndex = 1;
            this.label6.Text = "Model Yılı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(291, 355);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 31);
            this.label9.TabIndex = 1;
            this.label9.Text = "KM";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFiyat);
            this.groupBox1.Controls.Add(this.txtKm);
            this.groupBox1.Controls.Add(this.cbxModel);
            this.groupBox1.Controls.Add(this.cbxMarka);
            this.groupBox1.Controls.Add(this.cbxYakit);
            this.groupBox1.Controls.Add(this.btnGüncelle);
            this.groupBox1.Controls.Add(this.btnAracEkle);
            this.groupBox1.Controls.Add(this.cbxDurum);
            this.groupBox1.Controls.Add(this.cbxKasa);
            this.groupBox1.Controls.Add(this.cbxVites);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPlaka);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtModelDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(772, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 642);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Araç Bilgileri";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFiyat.Location = new System.Drawing.Point(446, 458);
            this.txtFiyat.Mask = "0000000000";
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(191, 38);
            this.txtFiyat.TabIndex = 10;
            this.txtFiyat.ValidatingType = typeof(int);
            // 
            // txtKm
            // 
            this.txtKm.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKm.Location = new System.Drawing.Point(446, 352);
            this.txtKm.Mask = "000.000.000";
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(191, 38);
            this.txtKm.TabIndex = 9;
            // 
            // cbxModel
            // 
            this.cbxModel.FormattingEnabled = true;
            this.cbxModel.Location = new System.Drawing.Point(446, 87);
            this.cbxModel.MaxLength = 50;
            this.cbxModel.Name = "cbxModel";
            this.cbxModel.Size = new System.Drawing.Size(191, 39);
            this.cbxModel.TabIndex = 2;
            // 
            // cbxMarka
            // 
            this.cbxMarka.FormattingEnabled = true;
            this.cbxMarka.Items.AddRange(new object[] {
            "Audi",
            "Bmw",
            "Mercedes",
            "Honda",
            "Toyota",
            "Volvo",
            "Fiat",
            "Ford"});
            this.cbxMarka.Location = new System.Drawing.Point(446, 34);
            this.cbxMarka.MaxLength = 50;
            this.cbxMarka.Name = "cbxMarka";
            this.cbxMarka.Size = new System.Drawing.Size(191, 39);
            this.cbxMarka.TabIndex = 2;
            this.cbxMarka.SelectedIndexChanged += new System.EventHandler(this.cbxMarka_SelectedIndexChanged);
            // 
            // btnAracEkle
            // 
            this.btnAracEkle.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAracEkle.Location = new System.Drawing.Point(17, 249);
            this.btnAracEkle.Name = "btnAracEkle";
            this.btnAracEkle.Size = new System.Drawing.Size(161, 53);
            this.btnAracEkle.TabIndex = 5;
            this.btnAracEkle.Text = "Araç Ekle";
            this.btnAracEkle.UseVisualStyleBackColor = true;
            this.btnAracEkle.Click += new System.EventHandler(this.btnAracEkle_Click);
            // 
            // cbxDurum
            // 
            this.cbxDurum.FormattingEnabled = true;
            this.cbxDurum.Items.AddRange(new object[] {
            "Satıldı",
            "Boş"});
            this.cbxDurum.Location = new System.Drawing.Point(446, 507);
            this.cbxDurum.MaxLength = 15;
            this.cbxDurum.Name = "cbxDurum";
            this.cbxDurum.Size = new System.Drawing.Size(191, 39);
            this.cbxDurum.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(297, 514);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 31);
            this.label10.TabIndex = 1;
            this.label10.Text = "Durum";
            // 
            // btnYenile
            // 
            this.btnYenile.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYenile.Location = new System.Drawing.Point(383, 575);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(161, 52);
            this.btnYenile.TabIndex = 8;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1466, 639);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.gridViewAraba);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAraba)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewAraba;
        private System.Windows.Forms.ComboBox cbxYakit;
        private System.Windows.Forms.ComboBox cbxKasa;
        private System.Windows.Forms.ComboBox cbxVites;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtModelDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxModel;
        private System.Windows.Forms.ComboBox cbxMarka;
        private System.Windows.Forms.ComboBox cbxDurum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAracEkle;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.MaskedTextBox txtKm;
        private System.Windows.Forms.MaskedTextBox txtFiyat;
    }
}