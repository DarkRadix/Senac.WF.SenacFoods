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
        private CardapioItem _cardapioItem;
        public FrmCardapioCad()
        {
            InitializeComponent();
        }

        public FrmCardapioCad(CardapioItem cardapioItem)

        {
            _cardapioItem = cardapioItem;
            InitializeComponent();



            CarregarDadosDaTela();
        }

        private void CarregarDadosDaTela()
        {
            
            if (_cardapioItem != null)
            {
                txtTitulo.Text = _cardapioItem.Titulo;
                txtdescricao.Text = _cardapioItem.Descricao;
                txtvalor.Text = _cardapioItem.Preco.ToString("F2");
                chkPossuiPreparo.Checked = _cardapioItem.PossuiPreparo;
            }
            
            
            
            
            
            
            
        
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            if (_cardapioItem == null)
            {
                InserirCardapio();
            }
            else 
            
            {
                AtualizarCardapio();
            }


                InserirCardapio();
        }

        private void AtualizarCardapio()
        {
            using (var banco = new ComandoDBContext())
            {
                string titulo=txtTitulo.Text;
                string descricao = txtdescricao.Text;
                decimal.TryParse(txtvalor.Text, out var valor);
                bool possuiPreparo = chkPossuiPreparo.Checked;
                var cardapioItem = banco.CardapioItems.First(x => x.Id == _cardapioItem.Id);
                cardapioItem.Titulo = titulo;
                cardapioItem.Descricao = descricao;
                cardapioItem.Preco = valor;
                cardapioItem.PossuiPreparo= possuiPreparo;
                banco.CardapioItems.Update(cardapioItem);
                banco.SaveChanges();

            }
            MessageBox.Show("Cardápio salvo com sucesso!",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            this.Close();


        }

        private void InserirCardapio()
        {
            // conectar
            using (var banco = new ComandoDBContext())
            {

                //captar os dados da tela
                string titulo = txtTitulo.Text;
                string descricao = txtdescricao.Text;
                decimal.TryParse(txtvalor.Text, out decimal preco);
                bool possuiPreparo = chkPossuiPreparo.Checked;
                //criar um novo cardapio
                var cardapio = new CardapioItem()
                {
                    Descricao = descricao,
                    Titulo = titulo,
                    Preco = preco,
                    PossuiPreparo = possuiPreparo
                };

                //adicionar o cardapio//salvar as alterações no banco
                banco.CardapioItems.Add(cardapio);
                banco.SaveChanges();
            }
            MessageBox.Show("Cardápio salvo com sucesso!",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
