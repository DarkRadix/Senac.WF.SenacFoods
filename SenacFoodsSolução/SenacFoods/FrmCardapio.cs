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
    public partial class FrmCardapio : Form
    {
        public FrmCardapio()
        {
            InitializeComponent();
        }

        private void FrmCardapio_Load(object sender, EventArgs e)
        {
            BuscarCardapio();
        }

        private void BuscarCardapio()
        {
            //conectar no banco de dados
            using (var bd = new ComandoDBContext())
            {
                //consultar a tabela cardapioitem SELECT * FROM CARDAPIO
                var cardapios = bd.CardapioItems.AsQueryable();
                if(!string.IsNullOrEmpty(txtPesquisa.Text))
                {
                    cardapios = cardapios.Where(c=> c.Titulo.Contains(txtPesquisa.Text) || 
                                                    c.Descricao.Contains(txtPesquisa.Text));
                }
                //popular o grid com a tabela consultada
                dataGridView1.DataSource = cardapios.ToList();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            new FrmCardapioCad().ShowDialog();
            BuscarCardapio();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            //chamar o metodo buscar cardápio
            BuscarCardapio();
        }
    }
}
