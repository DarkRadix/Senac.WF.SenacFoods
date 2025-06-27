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
    public partial class FrmCardapioCad : Form
    {
        public FrmCardapioCad()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            SalvarCardapio();
        }

        private void SalvarCardapio()
        {
            // conectar
            using (var banco = new ComandoDBContext()) 
            {

                //captar os dados da tela
                string titulo = txtTitulo.Text;
                string descricao = txtdescricao.Text;
                decimal.TryParse(txtvalor.Text, out decimal valor);
                bool possuiPreparo = chkPossuiPreparo.Checked;
                //criar um novo cardapio
                var cardapio = new CardapioItem()
                {
                    Descricao = descricao,
                    Titulo = titulo,
                    PossuiPreparo = possuiPreparo
                };

                //adicionar o cardapio//salvar as alterações no banco
                banco.CardapioItems.Add(cardapio);
                banco.SaveChanges();
            }
           
        }
    }
}
