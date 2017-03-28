using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace PDV2
{
    public partial class PradinisLaukas : Form
    {
        public PradinisLaukas()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        private void btn_NewGame_Click(object sender, EventArgs e)
        {
            NewPlayer npLangas = new NewPlayer();
            npLangas.Show();

            this.Hide();

        }

        private void btn_Rules_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Žaidimo tikslas: surinkti figūras, kurių taškų kiekis neviršytų 21 taško.\nŽaidėjas bei bankas raundo pradžioje gauna po dvi figūras.\nŽaidėjas gali matyti visas savo turimas figūras bei vieną banko turimą\nŽaidėjas gali pasirnkti 3 veiksmus:\n-Imti naują figūrą\n-Padidinti statomų taškų kiekį\n-Užbaigti raundą\nUžbaigus raundą bus susumuoti žaidėjo bei banko taškai ir palyginti.Didžiausia taškų, neviršijanti 21-no taško, suma suteikia pergalę.");


        }

        private void btn_Scoreboard_Click(object sender, EventArgs e)
        {
            Nugaletojai nugLang = new Nugaletojai();
            nugLang.Show();
            

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
}
    }
