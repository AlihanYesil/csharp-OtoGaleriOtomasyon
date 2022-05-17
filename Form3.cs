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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private string baglantiCümlesi = @"Data Source=ALIHANYESIL\SQLDB;Initial Catalog=otomasyon;Integrated Security=True";


        private void musterikayit_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCümlesi);
            baglanti.Open();


            string kayit = "Insert Into musteriler Values (@ad,@soyad,@tcno,@telno,@ehliyetno)";
            SqlCommand komut = new SqlCommand(kayit,baglanti);

            komut.Parameters.AddWithValue("@ad", txtAd.Text);
            komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
            komut.Parameters.AddWithValue("@tcno", txtTcno.Text);
            komut.Parameters.AddWithValue("@telno", txtTelno.Text);
            komut.Parameters.AddWithValue("@ehliyetno", txtEhliyetno.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Başarılı");
        }
        public void müsteriListele()
        {
            SqlConnection baglanti = new SqlConnection(baglantiCümlesi);
            baglanti.Open();


            string komutCümlesi = " Select * From musteriler";
            SqlCommand komut = new SqlCommand(komutCümlesi,baglanti);

            SqlDataAdapter da = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();
            da.Fill(dt);

            gridViewMüsteri.DataSource = dt;
            baglanti.Close();

        }


        private void müsteriEkle_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCümlesi);
            baglanti.Open();


            string komutCümlesi = "Update musteriler set ad=@ad,soyad=@soyad,tel_no=@telno,ehliyet_no=@ehliyetno Where tc_no=@tcno ";

           SqlCommand komut = new SqlCommand(komutCümlesi ,baglanti);

            komut.Parameters.AddWithValue("@tcno", txtTcno.Text);
            komut.Parameters.AddWithValue("@ad", txtAd.Text);
            komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
            komut.Parameters.AddWithValue("@telno", txtTelno.Text);
            komut.Parameters.AddWithValue("@ehliyetno", txtEhliyetno.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            müsteriListele();

            MessageBox.Show("Müşteri Başarı ile Güncellendi","Güncelleme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            müsteriListele();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            müsteriListele();

        }

        private void gridViewMüsteri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnGüncelle.Enabled = true;
            btnSil.Enabled = true;
            txtAd.Text = gridViewMüsteri.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = gridViewMüsteri.CurrentRow.Cells[2].Value.ToString();
            txtTelno.Text = gridViewMüsteri.CurrentRow.Cells[3].Value.ToString();
            txtEhliyetno.Text = gridViewMüsteri.CurrentRow.Cells[4].Value.ToString();
            txtTcno.Text = gridViewMüsteri.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCümlesi);
            baglanti.Open();

            string komutCümlesi = "Delete From musteriler Where tc_no='" + gridViewMüsteri.CurrentRow.Cells["tc_no"].Value.ToString()+"'";

            SqlCommand komut = new SqlCommand(komutCümlesi, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            müsteriListele();
            MessageBox.Show("Müşteri Başarı ile Silindi", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }
    }
}
