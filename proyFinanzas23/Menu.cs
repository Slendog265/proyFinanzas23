using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyFinanzas23
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            PanelAH.Visible = false;
            PanelAV.Visible = false;
            PanelRF.Visible = false;
            PanelPM.Visible = false;
        }

        private void hideSubMenu()
        {
            if (PanelAH.Visible == true)
                PanelAH.Visible = false;
            if (PanelAV.Visible == true)
                PanelAV.Visible = false;
            if (PanelRF.Visible == true)
                PanelRF.Visible = false;
            if (PanelPM.Visible == true)
                PanelPM.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelAH);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelAV);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelRF);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelPM);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new resgiBG());
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openChildForm(new addSave());
            hideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            openChildForm(new BGV());
            hideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            openChildForm(new ERV());
            hideSubMenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            openChildForm(new RFluidez());
            hideSubMenu();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            openChildForm(new RAct());
            hideSubMenu();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            openChildForm(new REnde());
            hideSubMenu();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            openChildForm(new RRent());
            hideSubMenu();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            openChildForm(new BGPro());
            hideSubMenu();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            openChildForm(new ERPro());
            hideSubMenu();
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            openChildForm(new BGOAp());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCaprure();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCaprure();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
