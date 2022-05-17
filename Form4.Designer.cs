namespace OdevGP2
{
    partial class Form4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtKm = new System.Windows.Forms.MaskedTextBox();
            this.txtFiyat = new System.Windows.Forms.MaskedTextBox();
            this.cbxModel = new System.Windows.Forms.ComboBox();
            this.cbxMarka = new System.Windows.Forms.ComboBox();
            this.cbxYakit = new System.Windows.Forms.ComboBox();
            this.cbxDurum = new System.Windows.Forms.ComboBox();
            this.cbxKasa = new System.Windows.Forms.ComboBox();
            this.cbxVites = new System.Windows.Forms.ComboBox();
            this.kaydet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtModelDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtKm);
            this.groupBox1.Controls.Add(this.txtFiyat);
            this.groupBox1.Controls.Add(this.cbxModel);
            this.groupBox1.Controls.Add(this.cbxMarka);
            this.groupBox1.Controls.Add(this.cbxYakit);
            this.groupBox1.Controls.Add(this.cbxDurum);
            this.groupBox1.Controls.Add(this.cbxKasa);
            this.groupBox1.Controls.Add(this.cbxVites);
            this.groupBox1.Controls.Add(this.kaydet);
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
            this.groupBox1.Location = new System.Drawing.Point(183, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 711);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Araç Ekle";
            // 
            // txtKm
            // 
            this.txtKm.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKm.Location = new System.Drawing.Point(285, 354);
            this.txtKm.Mask = "000.000.000";
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(191, 38);
            this.txtKm.TabIndex = 8;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFiyat.Location = new System.Drawing.Point(285, 457);
            this.txtFiyat.Mask = "0000000000";
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(191, 38);
            this.txtFiyat.TabIndex = 8;
            this.txtFiyat.ValidatingType = typeof(int);
            // 
            // cbxModel
            // 
            this.cbxModel.FormattingEnabled = true;
            this.cbxModel.Location = new System.Drawing.Point(285, 90);
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
            this.cbxMarka.Location = new System.Drawing.Point(285, 37);
            this.cbxMarka.Name = "cbxMarka";
            this.cbxMarka.Size = new System.Drawing.Size(191, 39);
            this.cbxMarka.TabIndex = 2;
            this.cbxMarka.SelectedIndexChanged += new System.EventHandler(this.cbxMarka_SelectedIndexChanged);
            // 
            // cbxYakit
            // 
            this.cbxYakit.FormattingEnabled = true;
            this.cbxYakit.Items.AddRange(new object[] {
            "LPG + BENZİN",
            "BENZİN",
            "DİZEL",
            "HİBRİT"});
            this.cbxYakit.Location = new System.Drawing.Point(285, 248);
            this.cbxYakit.Name = "cbxYakit";
            this.cbxYakit.Size = new System.Drawing.Size(191, 39);
            this.cbxYakit.TabIndex = 2;
            // 
            // cbxDurum
            // 
            this.cbxDurum.FormattingEnabled = true;
            this.cbxDurum.Items.AddRange(new object[] {
            "Satıldı",
            "Boş"});
            this.cbxDurum.Location = new System.Drawing.Point(285, 510);
            this.cbxDurum.Name = "cbxDurum";
            this.cbxDurum.Size = new System.Drawing.Size(191, 39);
            this.cbxDurum.TabIndex = 2;
            // 
            // cbxKasa
            // 
            this.cbxKasa.FormattingEnabled = true;
            this.cbxKasa.Items.AddRange(new object[] {
            "Sedan",
            "Hatchback",
            "Pick up",
            "Cabrio"});
            this.cbxKasa.Location = new System.Drawing.Point(285, 301);
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
            this.cbxVites.Location = new System.Drawing.Point(285, 195);
            this.cbxVites.Name = "cbxVites";
            this.cbxVites.Size = new System.Drawing.Size(191, 39);
            this.cbxVites.TabIndex = 2;
            // 
            // kaydet
            // 
            this.kaydet.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaydet.Location = new System.Drawing.Point(296, 586);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(169, 63);
            this.kaydet.TabIndex = 10;
            this.kaydet.Text = "Aracı Kaydet";
            this.kaydet.UseVisualStyleBackColor = true;
            this.kaydet.Click += new System.EventHandler(this.kaydet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(131, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marka";
            // 
            // txtPlaka
            // 
            this.txtPlaka.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPlaka.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPlaka.Location = new System.Drawing.Point(285, 406);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(191, 38);
            this.txtPlaka.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(131, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(131, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "Yakıt Türü";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(131, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 31);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kasa Tipi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(136, 361);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 31);
            this.label9.TabIndex = 1;
            this.label9.Text = "KM";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(129, 411);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 31);
            this.label8.TabIndex = 1;
            this.label8.Text = "Plaka";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(136, 517);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 31);
            this.label10.TabIndex = 1;
            this.label10.Text = "Durum";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(133, 464);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 31);
            this.label7.TabIndex = 1;
            this.label7.Text = "Fiyat";
            // 
            // txtModelDate
            // 
            this.txtModelDate.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtModelDate.Location = new System.Drawing.Point(285, 143);
            this.txtModelDate.MaxLength = 5;
            this.txtModelDate.Name = "txtModelDate";
            this.txtModelDate.Size = new System.Drawing.Size(191, 38);
            this.txtModelDate.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(130, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 31);
            this.label5.TabIndex = 1;
            this.label5.Text = "Vites";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(130, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 31);
            this.label6.TabIndex = 1;
            this.label6.Text = "Model Yılı";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1112, 723);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxModel;
        private System.Windows.Forms.ComboBox cbxMarka;
        private System.Windows.Forms.ComboBox cbxYakit;
        private System.Windows.Forms.ComboBox cbxDurum;
        private System.Windows.Forms.ComboBox cbxKasa;
        private System.Windows.Forms.ComboBox cbxVites;
        private System.Windows.Forms.Button kaydet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtModelDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtFiyat;
        private System.Windows.Forms.MaskedTextBox txtKm;
        private System.Windows.Forms.TextBox txtPlaka;
    }
}