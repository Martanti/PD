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

namespace PDV2
{
    public partial class StatymuLangas : Form
    {
        private Player player = new Player();
        private Bank bank = new Bank();
        private bool arJauNePirmasKartas;
        private int naujasStatymas;
        public StatymuLangas(Player playerInformation, Bank bankInformation, int senasStatymas, bool _arJauNePirmasKartas)
        {
            InitializeComponent();
            naujasStatymas = senasStatymas;
            player = playerInformation;
            bank = bankInformation;
            arJauNePirmasKartas = _arJauNePirmasKartas;

            lbl_taskai.Text = "Žaidėjo bendri taškai :\n" + player.BendriTaskai.ToString() + "\n\nBanko bendri taškai:\n" + bank.BendriTaskai.ToString();


        }

        private void btn_IncreaseStakes_Click(object sender, EventArgs e)
        {
            int statymas;
            bool arGeraiIvede = true;
            arGeraiIvede = Int32.TryParse(txtBx_IncreaseStakes.Text, out statymas);
            if (arGeraiIvede == false)
            {
                MessageBox.Show("Įvyko klaida, prašome įvesti dar kartą");
            }
            else
            {
                if (statymas > player.BendriTaskai || statymas > bank.BendriTaskai)
                {
                    MessageBox.Show("Prašome pasirinkti mažesnę sumą");
                }
                else
                {
                    player.BendriTaskai -= statymas;
                    bank.BendriTaskai -= statymas;
                    statymas *= 2;
                    naujasStatymas += statymas;
                    
                    ZaidimoLaukas zl = new ZaidimoLaukas(player, bank, naujasStatymas, arJauNePirmasKartas);
                    zl.Show();
                    this.Close();

                }
            }
            
        }
    }
}
