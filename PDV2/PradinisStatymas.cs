﻿using System;
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

namespace PDV2
{
    public partial class PradinisStatymas : Form
    {

        private Player player = new Player();
        private Bank bank = new Bank();

        public PradinisStatymas(Player playerInformation, Bank bankInformation)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            player = playerInformation;
            bank = bankInformation;

            lbl_CurrentPoints.Text = "Žaidėjo turimi taškai \n" + player.BendriTaskai + "\n\nBanko turimi taškai\n" + bank.BendriTaskai ;


        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            int statomiZaidejoTaskai;
            bool arGeraiIvede = true;
            arGeraiIvede = Int32.TryParse(txtBx_Statymai.Text, out statomiZaidejoTaskai);
            if (arGeraiIvede == false || txtBx_Statymai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Įvyko klaida, prašome įvesti dar kartą");
            }
            else
            {
                if (statomiZaidejoTaskai < 0)
                {
                    statomiZaidejoTaskai *= -1;
                }

                if (statomiZaidejoTaskai > player.BendriTaskai || statomiZaidejoTaskai > bank.BendriTaskai)
                {
                    MessageBox.Show("Prašome pasirinkti mažesnę sumą");
                }
                else if (statomiZaidejoTaskai == 0)
                {
                    MessageBox.Show("Statymas negali būti 0");
                }
                
                else
                {
                    player.BendriTaskai -= statomiZaidejoTaskai;
                    bank.BendriTaskai -= statomiZaidejoTaskai;
                    statomiZaidejoTaskai *= 2;
                    bool arJauNepirmasKartas = false;
                    ZaidimoLaukas zL = new ZaidimoLaukas(player, bank, statomiZaidejoTaskai, arJauNepirmasKartas);
                    
                    zL.Show();
                    this.Close();
                }
            }

        }
    }
}
