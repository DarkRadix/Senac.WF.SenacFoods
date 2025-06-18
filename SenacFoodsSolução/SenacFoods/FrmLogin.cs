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
            bool usuarioValido = false;
            //CONECTA AO BANCO
            using (var banco = new ComandoDBContext())
            {
                //CONSULTAR A TABELA USUARIO, SELECT * FROM USUARIOS WHERE EMAIL = ? AND SENHA = ?
                var usuario = banco.Usuarios.FirstOrDefault(u => u.Email == login && u.Senha == senha);

                if (usuario is not null)
                    usuarioValido = true;

                if (usuarioValido)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Login ou Senha Inválidos");
                }
                return false;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }
    }
}