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
            this.Hide();
            // Criar instancia de FrmPrincipal
            var frmPrincipal = new FrmPrincipal();
            frmPrincipal.Show();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }
    }
}