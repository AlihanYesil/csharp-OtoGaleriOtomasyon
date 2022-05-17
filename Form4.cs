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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private string baglantiCümlesi = @"Data Source=ALIHANYESIL\SQLDB;Initial Catalog=otomasyon;Integrated Security=True";

       

        private void cbxMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMarka.SelectedIndex == 0) //audi
            {
                cbxModel.Text = "";
                cbxModel.Items.Clear();

                cbxModel.Items.Add("A3");
                cbxModel.Items.Add("A4");
                cbxModel.Items.Add("A5");
            }
            else if (cbxMarka.SelectedIndex == 1) //bmw
            {
                cbxModel.Text = "";

                cbxModel.Items.Clear();
                cbxModel.Items.Add("320");
                cbxModel.Items.Add("520");
                cbxModel.Items.Add("720");
            }
            else if (cbxMarka.SelectedIndex == 2) //Mercedes
            {
                cbxModel.Text = "";

                cbxModel.Items.Clear();
                cbxModel.Items.Add("E63");
                cbxModel.Items.Add("C180");
                cbxModel.Items.Add("E200");
            }
            else if (cbxMarka.SelectedIndex == 3) //Honda
            {
                cbxModel.Text = "";

                cbxModel.Items.Clear();
                cbxModel.Items.Add("Civic");
                cbxModel.Items.Add("City");
            }
            else if (cbxMarka.SelectedIndex == 4) //Toyota
            {
                cbxModel.Text = "";

                cbxModel.Items.Clear();
                cbxModel.Items.Add("Corolla");
                cbxModel.Items.Add("Yaris");
                cbxModel.Items.Add("Hilux");
            }
            else if (cbxMarka.SelectedIndex == 5) //Volvo
            {
                cbxModel.Text = "";

                cbxModel.Items.Clear();
                cbxModel.Items.Add("S30");
                cbxModel.Items.Add("S60");
                cbxModel.Items.Add("S90");
            }
            else if (cbxMarka.SelectedIndex == 6) //Fiat
            {
                cbxModel.Text = "";

                cbxModel.Items.Clear();
                cbxModel.Items.Add("Egea");
                cbxModel.Items.Add("Linea");
                cbxModel.Items.Add("Doblo");
            }
            else if (cbxMarka.SelectedIndex == 7) //Ford
            {
                cbxModel.Text = "";

                cbxModel.Items.Clear();
                cbxModel.Items.Add("Focus");
                cbxModel.Items.Add("Fiesta");
                cbxModel.Items.Add("Ranger");
            }
            else
            {

                cbxModel.Items.Clear();

            }
        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCümlesi);
            baglanti.Open();

            string komutCümlesi = "Insert Into arabalar Values (@plaka,@marka,@model,@modeldate,@vites,@yakit,@kasa,@km,@fiyat,@durum)";
            SqlCommand komut = new SqlCommand(komutCümlesi, baglanti);

            komut.Parameters.AddWithValue("plaka", txtPlaka.Text);
            komut.Parameters.AddWithValue("marka", cbxMarka.SelectedItem);
            komut.Parameters.AddWithValue("model", cbxModel.SelectedItem);
            komut.Parameters.AddWithValue("modeldate", txtModelDate.Text);
            komut.Parameters.AddWithValue("vites", cbxVites.SelectedItem);
            komut.Parameters.AddWithValue("yakit", cbxYakit.SelectedItem);
            komut.Parameters.AddWithValue("kasa", cbxKasa.SelectedItem);
            komut.Parameters.AddWithValue("km", txtKm.Text);
            komut.Parameters.AddWithValue("fiyat", txtFiyat.Text);
            komut.Parameters.AddWithValue("durum", cbxDurum.SelectedItem);

            komut.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show(" Araç Kayıt Başarılı");
        }
    }
}
