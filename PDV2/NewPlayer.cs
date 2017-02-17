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
    public partial class NewPlayer : Form
    {
        public NewPlayer()
        {
            InitializeComponent();


        }

        private void btn_createPlayer_Click(object sender, EventArgs e)
        {
            Player player = new Player();
            player.Name = txtBx_playerName.Text.ToString();

            player.BendriTaskai = 500;

            Bank bankas = new Bank();
            bankas.BendriTaskai = 999999500;

            PradinisStatymas psLauk = new PradinisStatymas(player, bankas);
            psLauk.Show();
            this.Hide();





        }
    }
}
