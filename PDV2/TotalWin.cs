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
using PlayerServices;
using System.Threading;

namespace PDV2
{
    public partial class TotalWin : Form
    {
        

        public TotalWin(Player player)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            lbl_sveikinimai.Text = "Sveikiname laimėjus žaidimą \nir surinkus visus įmanomus taškus\nJūsų rezultatas bus įrašytas";
            if (player.Name != "pd_nugaletojas")
            {
                try
                {
                    string conString = @"Data Source=user-pc\sqlexpress;Initial Catalog=PD_NugaletojuSarasas;Integrated Security=True";
                    using (SqlConnection conn = new SqlConnection(conString))
                    {

                        conn.Open();

                        SqlCommand cmd = new SqlCommand("insert into Nugaletojai (vardas, taskai, data) values (@name, @taskai, getdate())", conn);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@name", player.Name);
                        cmd.Parameters.AddWithValue("@taskai", player.BendriTaskai);

                        cmd.ExecuteNonQuery();
                    }
                }

                catch
                {
                    MessageBox.Show("Dėja, įvyko klaida ir nepavyko \nsusisiekti su serveriu ir įrašyti jūsų rezultato");
                }
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            
            PradinisLaukas pl = new PradinisLaukas();

            pl.Show();
            this.Close();
        }

        private void btn_exit_Click_1(object sender, EventArgs e)
        {
            PradinisLaukas pl = new PradinisLaukas();

            pl.Show();
            this.Close();

        }
    }
}
