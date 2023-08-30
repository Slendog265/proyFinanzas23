using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyFinanzas23
{
    public partial class RazonesFinaacieras : Form
    {
        public RazonesFinaacieras()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu m = new Menu();
            m.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            RAct rEnde = new RAct();
            rEnde.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RFluidez rFluidez = new RFluidez();
            rFluidez.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            REnde rEnde = new REnde();  
            rEnde.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            RRent rRRent = new RRent();
            rRRent.Show();
        }
    }
}
