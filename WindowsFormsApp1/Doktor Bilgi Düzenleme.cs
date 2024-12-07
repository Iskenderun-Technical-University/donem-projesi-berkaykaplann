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

namespace WindowsFormsApp1
{
    public partial class Doktor_Bilgi_Düzenleme : Form
    {
        public Doktor_Bilgi_Düzenleme()
        {
            InitializeComponent();
        }
        Sqlbaglanti bgl=new Sqlbaglanti();
        public string TCNO;
        private void Doktor_Bilgi_Düzenleme_Load(object sender, EventArgs e)
        {
            maskedTextBoxTC.Text = TCNO;

            SqlCommand komut = new SqlCommand("Select * from Table_Doktor where DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", maskedTextBoxTC.Text);
            SqlDataReader dr =komut.ExecuteReader();
            while(dr.Read())
            {
                textBoxAd.Text = dr[1].ToString();
                textBoxSoyad.Text = dr[2].ToString();
                comboBoxBrans.Text = dr[3].ToString();
                textBoxSifre.Text = dr[5].ToString();
            }
            bgl.baglanti().Close();
        }

        private void Doktor_Bilgi_Düzenleme_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Table_Doktor set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p4 where DoktorTC=@p5", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBoxAd.Text);
            komut.Parameters.AddWithValue("@p2", textBoxSoyad.Text);
            komut.Parameters.AddWithValue("@p3", comboBoxBrans.Text);
            komut.Parameters.AddWithValue("@p4", textBoxSifre.Text);
            komut.Parameters.AddWithValue("@p5", maskedTextBoxTC.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgiler Güncellendi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);


        }
    }
}
