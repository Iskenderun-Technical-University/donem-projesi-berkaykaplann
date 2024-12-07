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
    public partial class SekreterDetay : Form
    {
        public SekreterDetay()
        {
            InitializeComponent();
        }

        public string TCnumara;

        Sqlbaglanti bgl = new Sqlbaglanti();
        private void SekreterDetay_Load(object sender, EventArgs e)
        {
            lblTC.Text = TCnumara;

            // adsoyad çekme
            SqlCommand komut1 = new SqlCommand("Select SekreterAdSoyad From Table_Sekreter where SekreterTC=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", lblTC.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while(dr1.Read())
            {
                lblADSOYAD.Text = dr1[0].ToString();    
            }
            bgl.baglanti().Close();

            // branşları datagridviewe aktarma
            DataTable dt1=new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select BransAd from Table_Brans",bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource= dt1;

            // doktorları datagride aktarma
            DataTable dt2=new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoktorAd + ' ' + DoktorSoyad) as 'Doktorlar',DoktorBrans from Table_Doktor", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource= dt2;

            // bransları aktarma cmbbox
            SqlCommand komut2 = new SqlCommand("Select BransAd from Table_Brans", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while(dr2.Read())
            {
                comboBoxBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into Table_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@p1", maskedTextBoxTarih.Text);
            komutkaydet.Parameters.AddWithValue("@p2",maskedTextBoxSaat.Text);
            komutkaydet.Parameters.AddWithValue("@p3", comboBoxBrans.Text);
            komutkaydet.Parameters.AddWithValue("@p4", comboBoxDoktor.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu.");
        }

        private void comboBoxBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxDoktor.Items.Clear();

            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad from Table_Doktor where DoktorBrans=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", comboBoxBrans.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                comboBoxDoktor.Items.Add(dr[0] + " " + dr[1]);
            }
            bgl.baglanti().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut =new SqlCommand("insert into Table_Duyurular (duyuru) values (@p1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", richTextBoxDuyuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Doktor_Paneli dfr = new Doktor_Paneli();
            dfr.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Brans_Paneli fr = new Brans_Paneli();
            fr.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Randevu_Listesi fr = new Randevu_Listesi();
            fr.Show();
           
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Duyurular fr = new Duyurular();
            fr.Show();
           // this.Hide();

        }

        private void SekreterDetay_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormGiris fr = new FormGiris();
            fr.Show();
            this.Hide();
        }
    }
}
