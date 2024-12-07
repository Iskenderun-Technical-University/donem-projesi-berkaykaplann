using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    internal class Sqlbaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-JC99FFNO\\SQLEXPRESS02;Initial Catalog=HastaneRandevu;Integrated Security=True");    

            baglan.Open();
            return baglan;

        }



    }
}
