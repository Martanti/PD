using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlayerServices;
using System.Data.SqlClient;

namespace PDV2
{
    public partial class ArTikraiNoriIseiti : Form
    {
        public ArTikraiNoriIseiti(Player _player)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.player = _player;
            lbl_BeforeExiting.Text = "Ar prieš išeinant norite išsaugoti?";
        }

        private Player player;

        private void btn_Save_Click(object sender, EventArgs e)
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

            catch (Exception ex)
            {
                MessageBox.Show("Dėja, įvyko klaida ir nepavyko \nsusisiekti su serveriu ir įrašyti jūsų rezultato");
                MessageBox.Show(ex.ToString());
            }

            PradinisLaukas pl = new PradinisLaukas();
            pl.Show();
            this.Close();

        }

        private void btn_NoSave_Click(object sender, EventArgs e)
        {
            PradinisLaukas pl = new PradinisLaukas();
            pl.Show();
            this.Close();
        }
    }
}
