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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private string baglantiCümlesi = @"Data Source=ALIHANYESIL\SQLDB;Initial Catalog=otomasyon;Integrated Security=True";

        private void musteriEkle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCümlesi);
            baglanti.Open();


            string kayit = "Insert Into musteriler Values (@ad,@soyad,@telno,@ehliyetno,@tcno)";
            SqlCommand komut = new SqlCommand(kayit, baglanti);

            komut.Parameters.AddWithValue("@ad", txtAd.Text);
            komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
            komut.Parameters.AddWithValue("@telno", txtTelno.Text);
            komut.Parameters.AddWithValue("@ehliyetno", txtEhliyetno.Text);
            komut.Parameters.AddWithValue("@tcno", txtTcno.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Başalarılı");
        }
    }
}
