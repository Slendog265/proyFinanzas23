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
    public partial class mMenu : System.Windows.Forms.Form
    {
        public mMenu()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            resgiBG menu3 = new resgiBG();
            menu3.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            addSave menu4 = new addSave();
            menu4.ShowDialog();
        }


    }
}
