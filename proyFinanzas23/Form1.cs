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
    }
}