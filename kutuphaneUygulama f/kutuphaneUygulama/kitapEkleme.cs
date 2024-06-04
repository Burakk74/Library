using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace kutuphaneUygulama
{
    public partial class kitapEkleme : Form
    {
        public kitapEkleme()
        {
            InitializeComponent();
        }
        string kitapAd;
        int sayfaSayisi, kitapTur, yayId, yazarId;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void kitapEkleme_Load(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                    SqlConnection Baglanti = new SqlConnection("server=.\\SQLEXPRESS; Initial Catalog=kutupHane;Integrated Security=SSPI");
                DataSet ds = new DataSet();
                Baglanti.Open();

                string kayit = "insert into kitapBil(kitapAd,sayfaSayisi,yazarId,yayId,turId) values (@kitapAd,@sayfaSayisi,@yazarId,@yayId,@kitapTur)";
                SqlCommand komut = new SqlCommand(kayit, Baglanti);
                komut.Parameters.AddWithValue("@kitapAd", textBox1.Text);
                komut.Parameters.AddWithValue("@yazarId", Convert.ToInt32( textBox2.Text));
                komut.Parameters.AddWithValue("@sayfaSayisi", Convert.ToInt32( textBox4.Text));
                komut.Parameters.AddWithValue("@kitapTur", Convert.ToInt32( textBox8.Text));
                komut.Parameters.AddWithValue("@yayId", Convert.ToInt32( textBox9.Text));

                komut.ExecuteNonQuery();

                Baglanti.Close();
                MessageBox.Show("Kitap Ekleme İşlemi Gerçekleşti.");
            }
            catch (Exception ex)
            {

                MessageBox.Show(Convert.ToString(ex));
            }
            
        }
    }
}
