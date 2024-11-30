using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using OneGroup.Class;
using OneGroup.Utils;

namespace OneGroup
{
    public partial class Produto : Form
    {
        bool hasChanges = false;
        List<ProdutoModel> allProducts;
        public Produto()
        {
            InitializeComponent();
            LoadGrid();
        }
        #region "Deletar Produto
        private void btnDeletarProd_Click(object sender, EventArgs e)
        {
            if (dataGridViewProd.SelectedRows.Count > 0)
            {
                var selectedLine = dataGridViewProd.SelectedRows[0];
                var selectedProd = (ProdutoModel)selectedLine.DataBoundItem;

                var result = MessageBox.Show("Tem certeza que deseja remover este produto?", "Confirmação", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DataStore.Produtos.Remove(selectedProd);

                    var estoqueToRemove = DataStore.Estoques.FirstOrDefault(e => e.IdEstoque == selectedProd.Id);
                    if (estoqueToRemove != null)
                    {
                            DataStore.Estoques.Remove(estoqueToRemove);
                            LoadGrid();
                    }

                    LoadGrid();
                }
            }
        }
        #endregion
        #region "Atualizar Grid"
        private void LoadGrid()
        {
            allProducts = DataStore.Produtos.ToList();

            dataGridViewProd.DataSource = null;
            dataGridViewProd.DataSource = allProducts;

            if (dataGridViewProd.Columns["QntVenda"] != null)
            {
                dataGridViewProd.Columns["QntVenda"].Visible = false;
            }
        }
        #endregion
        #region "Atualizar Grid Seletivamente"
        private void DisplayProducts(List<ProdutoModel> produtos)
        {
            dataGridViewProd.DataSource = null;
            dataGridViewProd.DataSource = produtos;

            if (dataGridViewProd.Columns["QntVenda"] != null)
            {
                dataGridViewProd.Columns["QntVenda"].Visible = false;
            }
        }
        #endregion
        #region "Adicionar Produto"
        private void btnNovoProd_Click(object sender, EventArgs e)
        {
            var cadProd = new SignInProd();
            cadProd.Show();
            this.Hide();
        }
        #endregion
        #region "Navegar para a Home"

        #region "Botão Voltar"
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var home = new Home();
            home.Show();
            this.Close();
        }
        #endregion
        #endregion
        #region "Buscar Produto"
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                string searchText = txtPesquisa.Text.Trim().ToLower(); 

                if (allProducts == null)
                {
                    MessageBox.Show("Nenhum produto carregado. Por favor, carregue os produtos antes de pesquisar.");
                    return;
                }

                var filteredProducts = allProducts
                    .Where(prod => prod.Nome.ToLower().Contains(searchText) ||
                                   prod.Id.ToString().Contains(searchText))
                    .ToList();

                DisplayProducts(filteredProducts);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro identificado ao tentar pesquisar: " + ex.Message);
            }
        }
        #endregion
        #region "Botão Salvar"
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!hasChanges)
            {
                MessageBox.Show("Nenhuma alteração foi feita para salvar.");
                return;
            }

            foreach (DataGridViewRow row in dataGridViewProd.Rows)
            {
                if (row.IsNewRow) continue;

                var id = (int)row.Cells["Id"].Value;
                var produto = DataStore.Produtos.FirstOrDefault(p => p.Id == id);

                if (produto != null)
                {
                    produto.Nome = row.Cells["Nome"].Value.ToString();
                    produto.Preco = Convert.ToDecimal(row.Cells["Preco"].Value);
                    produto.Descricao = row.Cells["Descricao"].Value.ToString();
                    produto.Categoria = row.Cells["Categoria"].Value.ToString();
                    produto.Marca = row.Cells["Marca"].Value.ToString();
                    produto.DtEntrada = Convert.ToDateTime(row.Cells["DtEntrada"].Value);
                    produto.DtVenda = Convert.ToDateTime(row.Cells["DtVenda"].Value);
                }
                else
                {
                    var novoProduto = new ProdutoModel(
                        row.Cells["Nome"].Value.ToString(),
                        Convert.ToDecimal(row.Cells["Preco"].Value),
                        row.Cells["Descricao"].Value.ToString(),
                        row.Cells["Categoria"].Value.ToString(),
                        row.Cells["Marca"].Value.ToString(),
                        Convert.ToDateTime(row.Cells["DtEntrada"].Value),
                        Convert.ToDateTime(row.Cells["DtVenda"].Value)
                    );
                    DataStore.Produtos.Add(novoProduto);
                }
            }

            MessageBox.Show("Alterações salvas com sucesso!");
            hasChanges = false; 
            LoadGrid(); 
        }
        #endregion
        #region "Validação de Mudanças no GridView"
        private void dataGridViewProd_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return; 

            hasChanges = true; 
        }
        #endregion
        #region "Botão Exibir"
        private void btnExibir_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }
        #endregion
        #region "Restringindo txtPesquisa"
        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {;
                txtPesquisa.BackColor = Color.Red;
                e.Handled = true;
            }
            else
            {
                txtPesquisa.BackColor = SystemColors.ActiveCaption;
                e.Handled = false;
            }
        }
        #endregion
    }
}