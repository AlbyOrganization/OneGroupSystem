using OneGroup.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneGroup
{
    public partial class Vendas : Form
    {
        public Vendas()
        {
            InitializeComponent();
            lblDisponivel.Text = "";
        }

        #region "Restringindo txtQntVendida"
        private void txtQntVendida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                txtQntVendida.BackColor = Color.Red;
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
                txtQntVendida.BackColor = SystemColors.ActiveCaption;
            }
        }
        #endregion
        #region "Restringindo txtId"
        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                txtQntVendida.BackColor = Color.Red;
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
                txtQntVendida.BackColor = SystemColors.ActiveCaption;
            }
        }
        #endregion
        #region "Navegar para GestaoVenda"
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var gestVenda = new GestaoVenda();
            gestVenda.Show();
            this.Close();
        }
        #endregion
        #region "Limpar Campos"
        public void ClearInputs()
        {
            txtId.Clear();
            txtQntVendida.Clear();
        }
        #endregion
        #region "Formatação de Entrada em txtId"
        private void txtId_Leave(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtId.Text, out int id))
                {
                    var produto = DataStore.Produtos.FirstOrDefault(prod => prod.Id == id);
                    if (produto != null)
                    {
                        var estoque = DataStore.Estoques.FirstOrDefault(estoque => estoque.IdEstoque == produto.Id);
                        if (estoque != null)
                        {
                            txtId.BackColor = SystemColors.ActiveCaption;
                            lblDisponivel.Text = estoque.QtdDisponivel.ToString();
                        }
                        else
                        {
                            txtId.BackColor = Color.Red;
                            MessageBox.Show("Estoque não encontrado para produto.");

                        }
                    }
                    else
                    {
                        txtId.BackColor = Color.Red;
                        MessageBox.Show("Produto não encontrado.");

                    }
                }
                else
                {
                    txtId.BackColor = Color.Red;
                    MessageBox.Show("ID inválido. Por favor, insira um ID válido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro identificado: " + ex.Message);
            }
        }
        #endregion
        #region "Formatação de Entrada de txtQntVendida"
        private void txtQntVendida_Leave(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtQntVendida.Text, out int qtdVendida))
                {
                    if (qtdVendida < 0)
                    {
                        txtQntVendida.BackColor = Color.Red;
                        MessageBox.Show("Quantidade vendida não pode ser negativa.");
                    }
                    else
                    {
                        txtQntVendida.BackColor = SystemColors.ActiveCaption;
                    }
                }
                else
                {
                    txtQntVendida.BackColor = Color.Red;
                    MessageBox.Show("Por favor, insira uma quantidade válida.");
                    txtQntVendida.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro identificado: " + ex.Message);
            }
        }
        #endregion
        #region "Botão de Venda"
        private void btnVender_Click(object sender, EventArgs e)
        {
            try
            {
                int qtdVendida = Convert.ToInt32(txtQntVendida.Text);
                int idProduto = Convert.ToInt32(txtId.Text);
                int qtdEntrada = 0;

                var produto = DataStore.Produtos.FirstOrDefault(p => p.Id == idProduto);
                if (produto == null)
                {
                    MessageBox.Show("Produto não encontrado.");
                    return;
                }

                var estoque = DataStore.Estoques.FirstOrDefault(e => e.IdEstoque == produto.IdEstoque);
                if (estoque == null)
                {
                    MessageBox.Show("Estoque não encontrado.");
                    return;
                }

                if (qtdVendida > 0)
                {
                    if (estoque.QtdDisponivel < qtdVendida)
                    {
                        MessageBox.Show("Estoque insuficiente para a venda.");
                        return;
                    }

                    produto.AtualizarQntVenda(qtdVendida);

                    estoque.QtdDisponivel -= qtdVendida;
                    estoque.Saida += qtdVendida;
                    estoque.DataAtualizacao = DateTime.Now;

                    estoque.MotivoSaida = "Venda de produtos - " + produto.Nome;
                    lblDisponivel.Text = "";
                    MessageBox.Show("Venda realizada com sucesso!");
                }
                else
                {
                    qtdEntrada = Math.Abs(qtdVendida);

                    estoque.QtdDisponivel += qtdEntrada;
                    estoque.Entrada += qtdEntrada;
                    estoque.DataAtualizacao = DateTime.Now;

                    estoque.MotivoEntrada = "Entrada de produtos - " + produto.Nome;

                    MessageBox.Show("Entrada de produtos registrada com sucesso!");
                }

                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao processar a venda ou entrada: " + ex.Message);
            }
            #endregion
        }
    }
}
