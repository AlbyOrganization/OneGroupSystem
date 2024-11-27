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
    public partial class Fornecedor : Form
    {
        bool hasChanges = false;
        public Fornecedor()
        {
            InitializeComponent();
            LoadGrid();
        }
        #region "Voltar para a página Home"
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var home = new Home();
            home.Show();
            this.Close();
        }
        #endregion
        #region "Navegar para a página de Cadastro de Fornecedor"
        private void btnNovo_Click(object sender, EventArgs e)
        {
            var cadFornec = new SignInFornec();
            cadFornec.Show();
            this.Hide();
        }
        #endregion
        #region "Deletar Fornecedor"
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (dataGridViewFornec.SelectedRows.Count > 0)
            {
                var selectedLine = dataGridViewFornec.SelectedRows[0];
                var selectedFornec = (FornecedorModel)selectedLine.DataBoundItem;

                var result = MessageBox.Show("Tem certeza que deseja remover este produto?", "Confirmação", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DataStore.Fornecedores.Remove(selectedFornec);
                    LoadGrid();
                }
            }
        }
        #endregion
        #region "Atualizar Grid"
        private void LoadGrid()
        {
            dataGridViewFornec.DataSource = null;
            dataGridViewFornec.DataSource = DataStore.Fornecedores;
        }
        #endregion

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!hasChanges)
            {
                MessageBox.Show("Nenhuma alteração foi feita para salvar.");
                return;
            }

            foreach (DataGridViewRow row in dataGridViewFornec.Rows)
            {
                if (row.IsNewRow) continue;

                var id = (int)row.Cells["Id"].Value;
                var fornecedor = DataStore.Fornecedores.FirstOrDefault(fornec => fornec.Id == id);

                if (fornecedor != null)
                {
                    fornecedor.Nome = row.Cells["Nome"].Value.ToString();
                    fornecedor.Email = row.Cells["Email"].Value.ToString();
                    fornecedor.Cnpj = row.Cells["Cnpj"].Value.ToString();
                    fornecedor.Telefone = row.Cells["Telefone"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Fornecedor não encontrado.");
                    return;
                }
            }

            MessageBox.Show("Alterações salvas com sucesso!");
            LoadGrid();
            hasChanges = false; 
        }
        #region "Verificando Mudança em Célula do GridView"
        private void dataGridViewFornec_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                hasChanges = true;
            }
        }
        #endregion
    }
}
