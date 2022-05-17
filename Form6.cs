using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OdevGP2
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private string baglantiCümlesi = @"Data Source=ALIHANYESIL\SQLDB;Initial Catalog=otomasyon;Integrated Security=True";

        public void aracListele()
        {
            SqlConnection baglanti =new SqlConnection(baglantiCümlesi);
            baglanti.Open();

            string komutCümlesi = "Select * From arabalar Where durum='Boş'";
            SqlCommand komut = new SqlCommand(komutCümlesi, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                cbxPlaka.Items.Add(read["plaka"]);
            }
        }

        public void satisListele()
        {
            SqlConnection baglanti = new SqlConnection(baglantiCümlesi);
            baglanti.Open();

            string komutCümlesi = "Select * From satis";
            
            SqlCommand komut = new SqlCommand(komutCümlesi,baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();
            da.Fill(dt);

            gridViewSatis.DataSource = dt;
            baglanti.Close();
        }

        private void cbxDurum_SelectedIndexChanged(object sender, EventArgs e)
        {
           if(cbxDurum.SelectedIndex == 1) //kiralandı
            {
                label10.Visible = true;
                label11.Visible = true;
                label15.Visible = true;
                label16.Visible = true;
                txtGun.Visible = true;
                txtKiraUcret.Visible = true;
                dtPickerDonus.Visible=true;
                btnHesapla.Visible = true;
            }
            else
            {
                label11.Visible = false;
                label15.Visible = false;
                label16.Visible = false;
                txtGun.Visible = false;
                txtKiraUcret.Visible = false;
                dtPickerDonus.Visible = false;
                btnHesapla.Visible = false;
            }
        }

        private void txtKiraUcret_TextChanged(object sender, EventArgs e)
        {
            btnHesapla.Enabled = true; 
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            aracListele();
            satisListele();

        }

        private void cbxPlaka_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCümlesi);
            baglanti.Open();

            string komutCümlesi = "Select * From arabalar Where Plaka like '" + cbxPlaka.SelectedItem + "'";
            SqlCommand komut = new SqlCommand(komutCümlesi, baglanti);

            SqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                cbxMarka.Text = read["marka"].ToString();
                cbxModel.Text = read["model"].ToString();
                cbxYakit.Text = read["yakit"].ToString();
            }
           
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            TimeSpan gunFarki = DateTime.Parse(dtPickerDonus.Text)- DateTime.Parse(dtPickerAlis.Text);
            int gunHesap = gunFarki.Days;

            txtFiyat.Text = (gunHesap * int.Parse(txtKiraUcret.Text)).ToString();
            txtGun.Text = gunHesap.ToString();
        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCümlesi);
            baglanti.Open();

            String komutCümlesi = "Insert Into satis Values (@tcno,@ad,@soyad,@telno,@ehliyetno,@plaka,@marka,@model,@yakit,@fiyat,@durum,@alistarih,@donustarih)";
            
            SqlCommand komut = new SqlCommand(komutCümlesi,baglanti);

            komut.Parameters.AddWithValue("@tcno",txtTcno.Text);
            komut.Parameters.AddWithValue("@ad",txtAd.Text);
            komut.Parameters.AddWithValue("@soyad",txtSoyad.Text);
            komut.Parameters.AddWithValue("@telno",txtTelno.Text);
            komut.Parameters.AddWithValue("@ehliyetno",txtEhliyetno.Text);
            komut.Parameters.AddWithValue("@plaka",cbxPlaka.SelectedItem);
            komut.Parameters.AddWithValue("@marka",cbxMarka.SelectedItem);
            komut.Parameters.AddWithValue("@model",cbxModel.Text);
            komut.Parameters.AddWithValue("@yakit",cbxYakit.SelectedItem);
            komut.Parameters.AddWithValue("@fiyat",txtFiyat.Text);
            komut.Parameters.AddWithValue("@durum",cbxDurum.SelectedItem);
            komut.Parameters.AddWithValue("@alistarih", dtPickerAlis.Text);
            komut.Parameters.AddWithValue("@donustarih", dtPickerDonus.Text);


            string komutCümlesiUpdate = "Update arabalar set Durum='"+cbxDurum.SelectedItem+"' Where plaka ='"+cbxPlaka.SelectedItem+"'";

            SqlCommand komutUpdate = new SqlCommand(komutCümlesiUpdate, baglanti);

            komut.ExecuteNonQuery();
            komutUpdate.ExecuteNonQuery();
            baglanti.Close();

            

            MessageBox.Show("Kayıt Başarılı", "Satış İşlemi");
            txtTcno.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtTelno.Text = "";
            txtEhliyetno.Text = "";
            cbxPlaka.Text = "";
            cbxMarka.Text = "";
            cbxModel.Text = "";
            cbxYakit.Text = "";
            txtFiyat.Text = "";
            cbxDurum.Text = "";
            dtPickerAlis.Text = "";
            dtPickerDonus.Text = "";

            aracListele();
            satisListele();

        }

        private void txtTcnoAra_TextChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCümlesi);
            baglanti.Open();

            String komutCümlesi = "Select * From musteriler where tc_no like '"+txtTcnoAra.Text+"'";
            SqlCommand komut = new SqlCommand(komutCümlesi, baglanti);
            SqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                txtTcno.Text = read["tc_no"].ToString();
                txtAd.Text = read["ad"].ToString();
                txtSoyad.Text = read["soyad"].ToString();
                txtTelno.Text = read["tel_no"].ToString();
                txtEhliyetno.Text = read["ehliyet_no"].ToString();
            }  
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = gridViewSatis.CurrentRow;
            SqlConnection baglanti = new SqlConnection(baglantiCümlesi);
            baglanti.Open();

            String komutCümlesiUpdate = "Update arabalar set durum= 'Boş' where plaka ='"+ satir.Cells["plaka"].Value.ToString()+"'";
            SqlCommand komutUpdate = new SqlCommand(komutCümlesiUpdate, baglanti);
            komutUpdate.ExecuteReader();

            


            baglanti.Close();
            MessageBox.Show("ARAC TESLİM ALINDI");
            satisListele();
            aracListele();
        }

        private void gridViewSatis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSil.Enabled = true;
        }
    }
}
