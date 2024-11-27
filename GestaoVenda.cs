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
    public partial class GestaoVenda : Form
    {
        bool hasChanges = false;
        public GestaoVenda()
        {
            InitializeComponent();
            LoadGrid();
        }
        #region "Atualizar Grid"
        private void LoadGrid()
        {
            dataGridViewEstoque.DataSource = null;
            dataGridViewProd.DataSource = null;

            dataGridViewProd.DataSource = DataStore.Produtos.ToList();
            dataGridViewProd.Columns["Marca"].Visible = false;
            dataGridViewProd.Columns["Descricao"].Visible = false;
            dataGridViewProd.Columns["Categoria"].Visible = false;
            dataGridViewProd.Columns["IdEstoque"].Visible = false;

            dataGridViewEstoque.DataSource = DataStore.Estoques.ToList();
            dataGridViewEstoque.Columns["QtdDisponivel"].Visible = false;
            dataGridViewEstoque.Columns["QntVenda"].Visible = false;
            dataGridViewEstoque.Columns["MotivoEntrada"].Visible = false;
            dataGridViewEstoque.Columns["MotivoSaida"].Visible = false;
        }
        #endregion
        #region "Navegar para a página Fornecedor"
        private void btnCadFornec_Click(object sender, EventArgs e)
        {
            var cadFornec = new SignInFornec();
            cadFornec.Show();
            this.Hide();
        }
        #endregion
        #region "Navegar para a página Home"
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var home = new Home();
            home.Show();
            this.Close();
        }
        #endregion
        #region "Deletar Vendas"
        private void btnDeletarGestaoVenda_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewProd.SelectedRows.Count > 0)
                {
                    var selectedLine = dataGridViewProd.SelectedRows[0];
                    int selectedProdId = (int)selectedLine.Cells["Id"].Value;

                    var result = MessageBox.Show("Tem certeza que deseja remover este produto e o estoque correspondente?", "Confirmação", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        var selectedProd = DataStore.Produtos.FirstOrDefault(prod => prod.Id == selectedProdId);
                        if (selectedProd != null)
                        {
                            DataStore.Produtos.Remove(selectedProd);

                            var estoqueToRemove = DataStore.Estoques.FirstOrDefault(e => e.IdEstoque == selectedProd.IdEstoque);
                            if (estoqueToRemove != null)
                            {
                                 result = MessageBox.Show("Tem certeza que deseja remover este produto?", "Confirmação", MessageBoxButtons.YesNo);
                                if (result == DialogResult.Yes)
                                {
                                    DataStore.Estoques.Remove(estoqueToRemove);
                                }
                            }

                            LoadGrid();
                        }
                        else
                        {
                            MessageBox.Show("Produto não encontrado.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region "Botão Salvar"
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!hasChanges)
                {
                    MessageBox.Show("Nenhuma alteração foi feita para salvar.");
                    return;
                }

                if (dataGridViewProd.Rows.Count == 0 || dataGridViewEstoque.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhum dado para salvar.");
                    return;
                }

                foreach (DataGridViewRow row in dataGridViewProd.Rows)
                {
                    if (row.IsNewRow) continue;

                    var id = (int)row.Cells["Id"].Value;
                    var produto = DataStore.Produtos.FirstOrDefault(prod => prod.Id == id);

                    if (produto != null)
                    {
                        produto.Nome = row.Cells["Nome"].Value.ToString();
                        produto.Preco = Convert.ToDecimal(row.Cells["Preco"].Value);
                        produto.DtVenda = Convert.ToDateTime(row.Cells["DtVenda"].Value);
                    }
                    else
                    {
                        MessageBox.Show("Produto não encontrado.");
                        return;
                    }
                }

                foreach (DataGridViewRow row in dataGridViewEstoque.Rows)
                {
                    if (row.IsNewRow) continue;

                    var id = (int)row.Cells["Id"].Value;
                    var estoque = DataStore.Estoques.FirstOrDefault(e => e.IdEstoque == id);

                    if (estoque != null)
                    {
                        estoque.QtdDisponivel = Convert.ToInt32(row.Cells["QtdDisponivel"].Value);
                        estoque.DataAtualizacao = DateTime.Now;
                    }
                    else
                    {
                        MessageBox.Show("Estoque não encontrado.");
                        return;
                    }
                }

                MessageBox.Show("Alterações salvas com sucesso!");
                hasChanges = false;
                LoadGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro encontrado: " + ex.Message);
            }
        }
        #endregion
        #region "Verificando Mudança em Célula do GridViewProduto"
        private void dataGridViewVendas_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                hasChanges = true;
            }
        }
        #endregion
        #region "Botão Vendas"
        private void btnVendas_Click(object sender, EventArgs e)
        {
            var vendas = new Vendas();
            vendas.Show();
            this.Hide();
        }
        #endregion
        #region "Verificando Mudança em Célula do GridViewEstoque"
        private void dataGridViewEstoque_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                hasChanges = true;
            }
        }
        #endregion
    }
}