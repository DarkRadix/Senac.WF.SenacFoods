namespace SenacFoods
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            bool loginValido = ValidarLogin(txtusuario.Text, txtsenha.Text);
            if (loginValido == true)
            {
                this.Hide();
                // Criar instancia de FrmPrincipal
                var frmPrincipal = new FrmPrincipal(txtusuario.Text, txtsenha.Text);
                frmPrincipal.Show();
            }
        }

        private bool ValidarLogin(string login, string senha)
        {
            if (login == "admin" && senha == "123")
            {
                return true;
            }
            else
            {
                MessageBox.Show("Login ou Senha Inválidos");
            }
            return false;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }
    }
}