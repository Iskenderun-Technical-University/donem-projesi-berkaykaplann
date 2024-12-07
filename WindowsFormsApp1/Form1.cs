using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }

        private void buttonHastaGiris_Click(object sender, EventArgs e)
        {
            FormHastaGiris fr =new FormHastaGiris();
            fr.Show();
            this.Hide();   
        }

        private void buttonDoktorGiris_Click(object sender, EventArgs e)
        {
            Doktor_Giris fr = new Doktor_Giris();
            fr.Show();
            this.Hide();

        }

        private void buttonSekreterGiris_Click(object sender, EventArgs e)
        {
            SekreterGiris fr = new SekreterGiris();
            fr.Show();
            this.Hide();
        }

        private void FormGiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
