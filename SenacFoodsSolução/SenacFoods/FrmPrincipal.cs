using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenacFoods
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
            var frmLogin = new FrmLogin();
            frmLogin.Show();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            //altera o estado da tela para o estado minimizado
            WindowState = FormWindowState.Minimized;
        }

        private void btnCardapio_Click(object sender, EventArgs e)
        {
            //cria uma instancia do FrmCardapio
            var frmCardapio = new FrmCardapio();
            //exibe a tela do cardapio em estilo modal.
            frmCardapio.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frmComanda = new FrmComanda();
            frmComanda.ShowDialog();
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            var frmPedidoCozinha = new FrmPedidoCozinha();
            frmPedidoCozinha.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            var frmUsuarios = new FrmUsuario();
            frmUsuarios.ShowDialog();
        }
    }
}
