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
    public partial class Estoque : Form
    {
        bool hasChanges = false;
        public Estoque()
        {
            InitializeComponent();
            LoadGrid();
            dataGridViewEstoque.CellValueChanged += dataGridViewEstoque_CellValueChanged;
        }
        #region "Atualizar Grid"
        private void LoadGrid()
        {
            dataGridViewEstoque.DataSource = null;
            dataGridViewEstoque.DataSource = DataStore.Estoques;
        }
        #endregion
        #region "Navegar para Home"
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }
        #endregion
        #region "Deletar do Estoque"
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (dataGridViewEstoque.SelectedRows.Count > 0)
            {
                var selectedLine = dataGridViewEstoque.SelectedRows[0];
                var selectedEstoque = (EstoqueModel)selectedLine.DataBoundItem;

                var result = MessageBox.Show("Tem certeza que deseja remover este item de estoque juntamente com seu produto?", "Confirmação", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DataStore.Estoques.Remove(selectedEstoque);

                    var produtoToRemove = DataStore.Produtos.FirstOrDefault(p => p.Id == selectedEstoque.IdEstoque);
                    if (produtoToRemove != null)
                    {
                        DataStore.Produtos.Remove(produtoToRemove);
                    }

                    LoadGrid();
                }
            }
        }

#endregion
        #region "Salvar Edição"
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!hasChanges)
            {
                MessageBox.Show("Nenhuma alteração foi feita para salvar.");
                return;
            }

            foreach (DataGridViewRow row in dataGridViewEstoque.Rows)
            {
                if (row.IsNewRow) continue;

                var id = (int)row.Cells["Id"].Value;
                var estoque = DataStore.Estoques.FirstOrDefault(e => e.IdEstoque == id);

                if (estoque != null)
                {
                    estoque.Localizacao = row.Cells["Localizacao"].Value.ToString();
                    estoque.Saida = Convert.ToInt32(row.Cells["Saida"].Value);
                    estoque.Entrada = Convert.ToInt32(row.Cells["Entrada"].Value);
                    estoque.DataAtualizacao = DateTime.Now; 
                    estoque.MotivoEntrada = row.Cells["MotivoEntrada"].Value.ToString();
                    estoque.MotivoSaida = row.Cells["MotivoSaida"].Value.ToString();
                    estoque.QtdDisponivel = Convert.ToInt32(row.Cells["QtdDisponivel"].Value);
                }
                else
                {
                    MessageBox.Show("Estoque não encontrado.");
                    return;
                }
            }

            MessageBox.Show("Alterações salvas com sucesso!");
            LoadGrid();
            hasChanges = false;
        }

#endregion
        
        private void dataGridViewEstoque_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                hasChanges = true; 
            }
        }
    }
}
