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
using OtherServices;

namespace PDV2
{
    public partial class PaprastasLaimejimas : Form
    {

        
        public PaprastasLaimejimas(Player _player, Bank _bank)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            lbl_text.Text = "Laimėjote raundą, norite pratęsti žaidimą ar išsaugoti ir užbaigti ";

            this.player = _player;
            this.bank = _bank;
        }

        private Player player;
        private Bank bank;

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                string conString = @"Data Source=user-pc\sqlexpress;Initial Catalog=PD_NugaletojuSarasas;Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(conString))
                {

                    conn.Open();
                    SqlTransaction tr = conn.BeginTransaction();

                    SqlCommand cmd = new SqlCommand("insert into Nugaletojai (vardas, taskai, data) values (@name, @taskai, getdate())", conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@name", player.Name);
                    cmd.Parameters.AddWithValue("@taskai", player.BendriTaskai);

                    cmd.ExecuteNonQuery();
                    tr.Commit();
                }
            }

            catch
            {
                MessageBox.Show("Dėja, įvyko klaida ir nepavyko \nsusisiekti su serveriu ir įrašyti jūsų rezultato");
            }
            FigurosKomandos.PradedamIsNaujo();
            PradinisLaukas pl = new PradinisLaukas();
            pl.Show();
            this.Close();

        }

        private void btn_Continue_Click(object sender, EventArgs e)
        {
            PradinisStatymas psl = new PradinisStatymas(player, bank);
            psl.Show();
            this.Close();
        }
    }
}
