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
    public partial class FormHastaKayıt : Form
    {
        public FormHastaKayıt()
        {
            InitializeComponent();
        }

        Sqlbaglanti bgl =new Sqlbaglanti();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Table_Hastalar (HastaAd,HastaSoyad,HastaTelefon,HastaTC,HastaCinsiyet,HastaSifre) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", textBoxAd.Text);
            komut.Parameters.AddWithValue("@p2", textBoxSoyad.Text);
            komut.Parameters.AddWithValue("@p3", maskedTextBoxTelefon.Text );
            komut.Parameters.AddWithValue("@p4", maskedTextBoxTC.Text);
            komut.Parameters.AddWithValue("@p5", comboBoxCinsiyet.Text);
            komut.Parameters.AddWithValue("@p6", textBoxSifre.Text);

            komut.ExecuteNonQuery();

            bgl.baglanti().Close();
            MessageBox.Show("Kaydınız Yapılmıştır. ŞİFRENİZ:" + textBoxSifre.Text,"Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void FormHastaKayıt_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }
    }
}
