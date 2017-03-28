using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PDV2
{
    public partial class Nugaletojai : Form
    {
        private SqlDataReader dReader;
        public Nugaletojai()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            string conString = @"Data Source=user-pc\sqlexpress;Initial Catalog=PD_NugaletojuSarasas;Integrated Security=True";
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {

                    conn.Open();
                    string nugaletojai = "Nugaletojo vardas - taškai - data \n\n";

                    SqlCommand cmd = new SqlCommand("select top 10 vardas, taskai, data from Nugaletojai order by taskai desc", conn);
                    cmd.CommandType = CommandType.Text;

                    dReader = cmd.ExecuteReader();
                    int i = 1;
                    while (dReader.Read())
                    {
                        nugaletojai += "\n" + i.ToString() + ": " + dReader.GetString(0) + "----" + dReader.GetInt32(1).ToString() + "----" + dReader.GetDateTime(2).ToString();
                        i++;
                    }
                    dReader.Close();
                    lbl_top.Text = nugaletojai;

                }
            }
            catch
            {
                lbl_top.Text = "Dėje, bet įvyko klaida susisiekiant su serveriu ir nepavyko pardoyti nugalėtojų :(";
            }

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
