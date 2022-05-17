namespace OdevGP2
{
    partial class Form6
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTcnoAra = new System.Windows.Forms.MaskedTextBox();
            this.txtTelno = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEhliyetno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.kaydet = new System.Windows.Forms.Button();
            this.cbxPlaka = new System.Windows.Forms.ComboBox();
            this.cbxModel = new System.Windows.Forms.ComboBox();
            this.cbxMarka = new System.Windows.Forms.ComboBox();
            this.cbxYakit = new System.Windows.Forms.ComboBox();
            this.cbxDurum = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.gridViewSatis = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtFiyat = new System.Windows.Forms.MaskedTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtGun = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtKiraUcret = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dtPickerDonus = new System.Windows.Forms.DateTimePicker();
            this.dtPickerAlis = new System.Windows.Forms.DateTimePicker();
            this.txtTcno = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSatis)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTcnoAra);
            this.groupBox1.Controls.Add(this.txtTelno);
            this.groupBox1.Controls.Add(this.txtTcno);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtEhliyetno);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 304);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            // 
            // txtTcnoAra
            // 
            this.txtTcnoAra.Location = new System.Drawing.Point(142, 37);
            this.txtTcnoAra.Mask = "00000000000";
            this.txtTcnoAra.Name = "txtTcnoAra";
            this.txtTcnoAra.Size = new System.Drawing.Size(167, 29);
            this.txtTcnoAra.TabIndex = 23;
            this.txtTcnoAra.ValidatingType = typeof(int);
            this.txtTcnoAra.TextChanged += new System.EventHandler(this.txtTcnoAra_TextChanged);
            // 
            // txtTelno
            // 
            this.txtTelno.Location = new System.Drawing.Point(92, 155);
            this.txtTelno.Mask = "(999) 000-0000";
            this.txtTelno.Name = "txtTelno";
            this.txtTelno.Size = new System.Drawing.Size(167, 29);
            this.txtTelno.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(6, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "TCno ile ARA";
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(92, 85);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(167, 29);
            this.txtAd.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(39, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Adı";
            // 
            // txtEhliyetno
            // 
            this.txtEhliyetno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEhliyetno.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEhliyetno.Location = new System.Drawing.Point(92, 190);
            this.txtEhliyetno.MaxLength = 14;
            this.txtEhliyetno.Name = "txtEhliyetno";
            this.txtEhliyetno.Size = new System.Drawing.Size(167, 29);
            this.txtEhliyetno.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(27, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Soyadı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(27, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tel no";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(27, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "TC no";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(92, 120);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(167, 29);
            this.txtSoyad.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(5, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ehliyet No";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtPickerAlis);
            this.groupBox2.Controls.Add(this.dtPickerDonus);
            this.groupBox2.Controls.Add(this.txtFiyat);
            this.groupBox2.Controls.Add(this.kaydet);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.cbxPlaka);
            this.groupBox2.Controls.Add(this.cbxModel);
            this.groupBox2.Controls.Add(this.txtKiraUcret);
            this.groupBox2.Controls.Add(this.cbxMarka);
            this.groupBox2.Controls.Add(this.cbxYakit);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.cbxDurum);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.btnHesapla);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtGun);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(351, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1096, 304);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " ";
            // 
            // kaydet
            // 
            this.kaydet.Location = new System.Drawing.Point(73, 214);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(231, 74);
            this.kaydet.TabIndex = 14;
            this.kaydet.Text = "Kaydet";
            this.kaydet.UseVisualStyleBackColor = true;
            this.kaydet.Click += new System.EventHandler(this.kaydet_Click);
            // 
            // cbxPlaka
            // 
            this.cbxPlaka.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxPlaka.FormattingEnabled = true;
            this.cbxPlaka.Location = new System.Drawing.Point(74, 50);
            this.cbxPlaka.Name = "cbxPlaka";
            this.cbxPlaka.Size = new System.Drawing.Size(190, 31);
            this.cbxPlaka.TabIndex = 13;
            this.cbxPlaka.SelectedIndexChanged += new System.EventHandler(this.cbxPlaka_SelectedIndexChanged);
            // 
            // cbxModel
            // 
            this.cbxModel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxModel.FormattingEnabled = true;
            this.cbxModel.Location = new System.Drawing.Point(454, 38);
            this.cbxModel.MaxLength = 50;
            this.cbxModel.Name = "cbxModel";
            this.cbxModel.Size = new System.Drawing.Size(191, 31);
            this.cbxModel.TabIndex = 2;
            // 
            // cbxMarka
            // 
            this.cbxMarka.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
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
            this.cbxMarka.Location = new System.Drawing.Point(73, 98);
            this.cbxMarka.MaxLength = 50;
            this.cbxMarka.Name = "cbxMarka";
            this.cbxMarka.Size = new System.Drawing.Size(191, 31);
            this.cbxMarka.TabIndex = 2;
            // 
            // cbxYakit
            // 
            this.cbxYakit.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxYakit.FormattingEnabled = true;
            this.cbxYakit.Items.AddRange(new object[] {
            "LPG + BENZİN",
            "BENZİN",
            "DİZEL",
            "HİBRİT"});
            this.cbxYakit.Location = new System.Drawing.Point(454, 98);
            this.cbxYakit.MaxLength = 50;
            this.cbxYakit.Name = "cbxYakit";
            this.cbxYakit.Size = new System.Drawing.Size(191, 31);
            this.cbxYakit.TabIndex = 2;
            // 
            // cbxDurum
            // 
            this.cbxDurum.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxDurum.FormattingEnabled = true;
            this.cbxDurum.Items.AddRange(new object[] {
            "Satıldı",
            "Kiralandı",
            "Boş"});
            this.cbxDurum.Location = new System.Drawing.Point(870, 41);
            this.cbxDurum.MaxLength = 15;
            this.cbxDurum.Name = "cbxDurum";
            this.cbxDurum.Size = new System.Drawing.Size(191, 31);
            this.cbxDurum.TabIndex = 2;
            this.cbxDurum.SelectedIndexChanged += new System.EventHandler(this.cbxDurum_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(13, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "Marka";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(394, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 23);
            this.label8.TabIndex = 1;
            this.label8.Text = "Model";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(369, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 23);
            this.label9.TabIndex = 1;
            this.label9.Text = "Yakıt Türü";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(17, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 23);
            this.label12.TabIndex = 1;
            this.label12.Text = "Plaka";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(804, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 23);
            this.label13.TabIndex = 1;
            this.label13.Text = "Durum";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(816, 99);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 23);
            this.label14.TabIndex = 1;
            this.label14.Text = "Fiyat";
            // 
            // gridViewSatis
            // 
            this.gridViewSatis.AllowUserToAddRows = false;
            this.gridViewSatis.AllowUserToDeleteRows = false;
            this.gridViewSatis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewSatis.Location = new System.Drawing.Point(12, 322);
            this.gridViewSatis.Name = "gridViewSatis";
            this.gridViewSatis.ReadOnly = true;
            this.gridViewSatis.Size = new System.Drawing.Size(1435, 386);
            this.gridViewSatis.TabIndex = 20;
            this.gridViewSatis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewSatis_CellContentClick);
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(1211, 714);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(236, 80);
            this.btnSil.TabIndex = 21;
            this.btnSil.Text = "Arac Teslim Alındı";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtFiyat
            // 
            this.txtFiyat.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFiyat.Location = new System.Drawing.Point(870, 88);
            this.txtFiyat.Mask = "0000000000";
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(191, 29);
            this.txtFiyat.TabIndex = 15;
            this.txtFiyat.ValidatingType = typeof(int);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Enabled = false;
            this.btnHesapla.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.Location = new System.Drawing.Point(872, 239);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(107, 42);
            this.btnHesapla.TabIndex = 3;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Visible = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txtGun
            // 
            this.txtGun.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGun.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGun.Location = new System.Drawing.Point(503, 165);
            this.txtGun.MaxLength = 10;
            this.txtGun.Name = "txtGun";
            this.txtGun.Size = new System.Drawing.Size(191, 29);
            this.txtGun.TabIndex = 7;
            this.txtGun.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(721, 208);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 23);
            this.label11.TabIndex = 1;
            this.label11.Text = "Dönüş Tarihi";
            this.label11.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(734, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 23);
            this.label10.TabIndex = 1;
            this.label10.Text = "Alış Tarihi";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(426, 222);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 23);
            this.label16.TabIndex = 1;
            this.label16.Text = "Kira ücreti";
            this.label16.Visible = false;
            // 
            // txtKiraUcret
            // 
            this.txtKiraUcret.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKiraUcret.Location = new System.Drawing.Point(504, 220);
            this.txtKiraUcret.Mask = "0000000000";
            this.txtKiraUcret.Name = "txtKiraUcret";
            this.txtKiraUcret.Size = new System.Drawing.Size(191, 29);
            this.txtKiraUcret.TabIndex = 10;
            this.txtKiraUcret.ValidatingType = typeof(int);
            this.txtKiraUcret.Visible = false;
            this.txtKiraUcret.TextChanged += new System.EventHandler(this.txtKiraUcret_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(442, 167);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 23);
            this.label15.TabIndex = 1;
            this.label15.Text = "Gün";
            this.label15.Visible = false;
            // 
            // dtPickerDonus
            // 
            this.dtPickerDonus.CalendarFont = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtPickerDonus.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtPickerDonus.Location = new System.Drawing.Point(820, 203);
            this.dtPickerDonus.Name = "dtPickerDonus";
            this.dtPickerDonus.Size = new System.Drawing.Size(241, 29);
            this.dtPickerDonus.TabIndex = 11;
            this.dtPickerDonus.Visible = false;
            // 
            // dtPickerAlis
            // 
            this.dtPickerAlis.CalendarFont = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtPickerAlis.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtPickerAlis.Location = new System.Drawing.Point(820, 161);
            this.dtPickerAlis.Name = "dtPickerAlis";
            this.dtPickerAlis.Size = new System.Drawing.Size(241, 29);
            this.dtPickerAlis.TabIndex = 11;
            // 
            // txtTcno
            // 
            this.txtTcno.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTcno.Location = new System.Drawing.Point(86, 231);
            this.txtTcno.Mask = "0000000000";
            this.txtTcno.Name = "txtTcno";
            this.txtTcno.Size = new System.Drawing.Size(191, 29);
            this.txtTcno.TabIndex = 15;
            this.txtTcno.ValidatingType = typeof(int);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1459, 806);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.gridViewSatis);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSatis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEhliyetno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtTelno;
        private System.Windows.Forms.MaskedTextBox txtTcnoAra;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbxModel;
        private System.Windows.Forms.ComboBox cbxMarka;
        private System.Windows.Forms.ComboBox cbxYakit;
        private System.Windows.Forms.ComboBox cbxDurum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView gridViewSatis;
        private System.Windows.Forms.ComboBox cbxPlaka;
        private System.Windows.Forms.Button kaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.MaskedTextBox txtFiyat;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DateTimePicker dtPickerAlis;
        private System.Windows.Forms.DateTimePicker dtPickerDonus;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox txtKiraUcret;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtGun;
        private System.Windows.Forms.MaskedTextBox txtTcno;
    }
}