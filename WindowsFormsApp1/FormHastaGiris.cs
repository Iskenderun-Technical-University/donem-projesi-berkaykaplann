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
    public partial class FormHastaGiris : Form
    {
        public FormHastaGiris()
        {
            InitializeComponent();
        }

        Sqlbaglanti bgl =new Sqlbaglanti();
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormHastaKayıt fr = new FormHastaKayıt();
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut =new SqlCommand("Select * From Table_Hastalar Where HastaTC=@p1 and HastaSifre=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", maskedTextBoxTC.Text);
            komut.Parameters.AddWithValue("@p2",textBoxSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();

            if(dr.Read())
            {
                HastaDetay fr = new HastaDetay();
                fr.tc = maskedTextBoxTC.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sifreniz veya kimlik numaranız hatalı!");
            }
            bgl.baglanti().Close();

        }

        private void FormHastaGiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormGiris fr1 = new FormGiris();
            fr1.Show();
            this.Hide();
        }
    }
}
