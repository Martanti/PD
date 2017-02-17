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
    public partial class EndTotalLoss : Form
    {
        public EndTotalLoss()
        {
            InitializeComponent();
            lbl_FinalText.Text = "Tu visiškai pralaimėjai, bet visada galima pradėti iš naujo";
        }

        private void btn_NewGame_Click(object sender, EventArgs e)
        {
            NewPlayer nw = new NewPlayer();
            nw.Show();
            this.Close();
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {

        }
    }
}
