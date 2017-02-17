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
using FigureServices;
using OtherServices;
using System.Threading;

namespace PDV2
{
    public partial class ZaidimoLaukas : Form
    {
        private Player player = new Player();
        private Bank bank = new Bank();
        private int statymas;
        private bool arJauNePirmasKartas;

        public ZaidimoLaukas(Player playerInformation, Bank bankInformation, int _statymas, bool _arJauNePirmasKartas)
        {
            InitializeComponent();

            player = playerInformation;
            bank = bankInformation;
            arJauNePirmasKartas = _arJauNePirmasKartas;
            if (arJauNePirmasKartas == false)
            {
                

                player.TurimosFiguros.Add(FigurosKomandos.Generuoti());
                player.RaundoTaskai += player.TurimosFiguros[player.TurimosFiguros.Count - 1].TaskuKiekis;
                Thread.Sleep(250);

                player.TurimosFiguros.Add(FigurosKomandos.Generuoti());
                player.RaundoTaskai += player.TurimosFiguros[player.TurimosFiguros.Count - 1].TaskuKiekis;
                Thread.Sleep(250);

                bank.TurimosFiguros.Add(FigurosKomandos.Generuoti());
                bank.RaundoTaskai += bank.TurimosFiguros[bank.TurimosFiguros.Count - 1].TaskuKiekis;
                Thread.Sleep(250);

                bank.TurimosFiguros.Add(FigurosKomandos.Generuoti());
                bank.RaundoTaskai += bank.TurimosFiguros[bank.TurimosFiguros.Count - 1].TaskuKiekis;
                Thread.Sleep(250);


                arJauNePirmasKartas = true; 

            }

            statymas = _statymas;
            lbl_CurrentStakes.Text = statymas.ToString();

            string lbl_TurimosFigurosText = "Žaidėjo turimos figūros : \n";
            foreach(Figura fgr in player.TurimosFiguros)
            {
                lbl_TurimosFigurosText += (fgr.Pavadinimas + "\n");
            }

            lbl_TurimosFigurosText += "\nbanko turima figūra \n" + bank.TurimosFiguros[0].Pavadinimas;

            lbl_TurimosFiguros.Text = lbl_TurimosFigurosText;

            lbl_Taskai.Text = "Žaidėjo bendri taškai :\n" + player.BendriTaskai.ToString() + "\n\nBanko bendri taškai:\n" + bank.BendriTaskai.ToString();




        }

        private void btn_NewFigure_Click(object sender, EventArgs e)
        {
            if (player.TurimosFiguros.Count <= 10 )
            {
                player.TurimosFiguros.Add(FigurosKomandos.Generuoti());
                player.RaundoTaskai += player.TurimosFiguros[player.TurimosFiguros.Count - 1].TaskuKiekis;
                Thread.Sleep(250);


                string lbl_TurimosFigurosText = "Žaidėjo turimos figūros : \n";
                foreach (Figura fgr in player.TurimosFiguros)
                {
                    lbl_TurimosFigurosText += (fgr.Pavadinimas + "\n");
                }

                lbl_TurimosFigurosText += "\nbanko turima figūra \n" + bank.TurimosFiguros[0].Pavadinimas;

                lbl_TurimosFiguros.Text = lbl_TurimosFigurosText;

                lbl_CurrentStakes.Text = statymas.ToString();

                lbl_Taskai.Text = "Žaidėjo bendri taškai :\n" + player.BendriTaskai.ToString() + "\n\nBanko bendri taškai:\n" + bank.BendriTaskai.ToString();
            }

            else
            {
                MessageBox.Show("Pasiekėte figūrų limitą");
            }
        }

        private void btn_IncreaseStakes_Click(object sender, EventArgs e)
        {
            StatymuLangas st1 = new StatymuLangas(player, bank, statymas, arJauNePirmasKartas);
            st1.Show();
            this.Close();
        }

        private void btn_EndRound_Click(object sender, EventArgs e)
        {
            if (player.RaundoTaskai >21)
            {
                MessageBox.Show("{0} pralaimėjo, nes viršijo 21-no taško ribą.", player.Name);
                bank.BendriTaskai += statymas;
            }

            else if (bank.RaundoTaskai > 21)
            {
                MessageBox.Show("{0} laimėjo, nes bankas viršijo 21-no taško ribą.", player.Name);
                player.BendriTaskai += statymas;
            }

            else
            {
                if (bank.RaundoTaskai <= 16)
                {
                    bank.TurimosFiguros.Add(FigurosKomandos.Generuoti());
                    bank.RaundoTaskai += bank.TurimosFiguros[bank.TurimosFiguros.Count - 1].TaskuKiekis;
                }

                if (bank.RaundoTaskai > 21)
                {
                    MessageBox.Show("{0} laimėjo, nes bankas viršijo 21-no taško ribą.", player.Name);
                    player.BendriTaskai += statymas;
                }

                if (player.RaundoTaskai == 21)
                {
                    MessageBox.Show("{0} laimėjo, nes surinko 21-ną tašką!", player.Name);
                    player.BendriTaskai += statymas;
                }
                else if (bank.RaundoTaskai == 21)
                {
                    MessageBox.Show("{0} pralaimėjo, nes bankas surinko 21-ną tašką.", player.Name);
                    bank.BendriTaskai += statymas;
                }

                else if (player.RaundoTaskai == bank.RaundoTaskai)
                {
                    MessageBox.Show("Lygiosios! {0} ir bankas surinko vienodą taškų kiekį", player.Name);
                    bank.BendriTaskai += statymas / 2;
                    player.BendriTaskai += statymas / 2;
                }

                else if (player.RaundoTaskai > bank.RaundoTaskai)
                {
                    MessageBox.Show("{0} laimėjo, nes surinko daugiau taškų nei bankas.", player.Name);
                    player.BendriTaskai += statymas;
                }

                else if (bank.RaundoTaskai > player.RaundoTaskai)
                {
                    MessageBox.Show("{0} pralaimėjo, nes bankas surinko daugiau taškų.", player.Name);
                    bank.BendriTaskai += statymas;
                }

            }
            //pralaimejo visiskai
            if (player.BendriTaskai == 0)
            {

            }

            //galima testi zaidima

            else if (player.BendriTaskai > 0 && bank.BendriTaskai>0 )
            {

            }

            //istustejo bankas

            else
            {

            }

        }

        private void btn_Rules_Click(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {

        }
    }
}
