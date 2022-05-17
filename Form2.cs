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
    public partial class Form2 : Form
    {
        public Form2()
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

        

        private void btnAracEkle_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
        }


        public void aracListele()
        {
            SqlConnection baglanti = new SqlConnection(baglantiCümlesi);
            baglanti.Open();

            string komutCümlesi = "Select * From arabalar";

            SqlCommand komut = new SqlCommand(komutCümlesi,baglanti);

            SqlDataAdapter da =new SqlDataAdapter(komut);
            
            DataTable dt = new DataTable();
            
            da.Fill(dt);

            gridViewAraba.DataSource = dt;

            baglanti.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            aracListele();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            
                SqlConnection baglanti = new SqlConnection(baglantiCümlesi);
                baglanti.Open();

                string komutCümlesi = "Update arabalar set marka = @marka,model=@model,model_date=@modeldate,vites=@vites,yakit=@yakit,kasa_tip=@kasa,km=@km,fiyat=@fiyat,durum=@durum Where  plaka=@plaka ";
                SqlCommand komut = new SqlCommand(komutCümlesi,baglanti);

                komut.Parameters.AddWithValue("@marka", cbxMarka.SelectedItem);
                komut.Parameters.AddWithValue("@model", cbxModel.SelectedItem);
                komut.Parameters.AddWithValue("@modeldate", txtModelDate.Text);
                komut.Parameters.AddWithValue("@vites",cbxVites.SelectedItem);
                komut.Parameters.AddWithValue("@yakit",cbxYakit.SelectedItem);
                komut.Parameters.AddWithValue("@kasa",cbxKasa.SelectedItem);
                komut.Parameters.AddWithValue("@km",txtKm.Text);
                komut.Parameters.AddWithValue("@fiyat",txtFiyat.Text);
                komut.Parameters.AddWithValue("@durum",cbxDurum.SelectedItem);
                komut.Parameters.AddWithValue("@plaka", txtPlaka.Text);
                
                 komut.ExecuteNonQuery();
                 baglanti.Close();
                    aracListele();

            MessageBox.Show("Müşteri Başarı ile Güncellendi", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            
                SqlConnection baglanti = new SqlConnection(baglantiCümlesi);
                baglanti.Open();

                string komutCümlesi = "Delete From arabalar Where plaka='" + gridViewAraba.CurrentRow.Cells["plaka"].Value.ToString() + "'";

                SqlCommand komut = new SqlCommand(komutCümlesi, baglanti);

                komut.ExecuteNonQuery();
                baglanti.Close();
                aracListele();

            MessageBox.Show("Müşteri Başarı ile Silindi", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }

        private void gridViewAraba_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnGüncelle.Enabled = true;
            btnSil.Enabled = true;
            txtPlaka.Text = gridViewAraba.CurrentRow.Cells[1].Value.ToString();
            cbxMarka.Text = gridViewAraba.CurrentRow.Cells[2].Value.ToString();
            cbxModel.Text = gridViewAraba.CurrentRow.Cells[3].Value.ToString();
            txtModelDate.Text = gridViewAraba.CurrentRow.Cells[4].Value.ToString();
            cbxVites.Text = gridViewAraba.CurrentRow.Cells[5].Value.ToString();
            cbxYakit.Text = gridViewAraba.CurrentRow.Cells[6].Value.ToString();
            cbxKasa.Text = gridViewAraba.CurrentRow.Cells[7].Value.ToString();
            txtKm.Text = gridViewAraba.CurrentRow.Cells[8].Value.ToString();
            txtFiyat.Text = gridViewAraba.CurrentRow.Cells[9].Value.ToString();
            cbxDurum.Text = gridViewAraba.CurrentRow.Cells[10].Value.ToString();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            aracListele();

        }
    }
}
