using System.Runtime.InteropServices;

namespace proyFinanzas23
{
    public partial class Login : System.Windows.Forms.Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbLogin.Text == "Josselyn" && tbPass.Text == "Docente")
            {
                this.Hide();
                Menu Menu = new Menu();
                Menu.Show();
            }
            else
            {
                MessageBox.Show("Usuarios o contraseña incorrectos");
            }

        }
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCaprure();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCaprure();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}