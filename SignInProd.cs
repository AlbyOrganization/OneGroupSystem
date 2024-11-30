using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flunt.Br;
using OneGroup.Class;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace OneGroup
{
    public partial class SignInProd : Form
    {
        bool validatingTxtBox = false;
        public SignInProd()
        {
            InitializeComponent();
        }
        #region "Cadastrar Produto"
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    if (!ValidarCamposObrigatorios())
                    {
                        return;
                    }

                    ValidarCamposNaoObrigatorios();

                    if (validatingTxtBox == true)
                    {
                        AddingColorsToTxtBoxes();    
                        int qtdDisponivel = Convert.ToInt32(txtQtdDisponivel.Text.Trim());
                        decimal preco = decimal.Parse(txtPreco.Text.Trim(), CultureInfo.InvariantCulture);
                        string nome = txtNome.Text.Trim();
                        string descricao = txtDesc.Text.Trim();
                        string categoria = txtCategoria.Text.Trim();
                        string marca = txtMarca.Text.Trim();
                        DateTime dtEntrada = dtpEntrada.Value;
                        DateTime dtVenda = dtpVenda.Value;
                        string localizacao = cmbLocal.Text.Trim();
                        string motivoEntrada = txtMotivoEntrada.Text.Trim();
                        string motivoSaida = txtMotivoSaida.Text.Trim();
                        int entrada = string.IsNullOrEmpty(txtEntrada.Text.Trim()) ? 0 : Convert.ToInt32(txtEntrada.Text.Trim());
                        int saida = string.IsNullOrEmpty(txtSaida.Text.Trim()) ? 0 : Convert.ToInt32(txtSaida.Text.Trim());


                        var newEstoque = new EstoqueModel(localizacao, saida, entrada, motivoEntrada, motivoSaida, qtdDisponivel);
                        var newProd = new ProdutoModel(nome, preco, descricao, categoria, marca, dtEntrada, dtVenda);


                        DataStore.Produtos.Add(newProd);
                        DataStore.Estoques.Add(newEstoque);

                        MessageBox.Show("Cadastro realizado com sucesso!");
                        ClearInputs();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar produto: " + ex.Message);
                }
            }
        }
        #endregion

        #region "ValidarCamposObrigatorios"
        private bool ValidarCamposObrigatorios()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                txtNome.BackColor = Color.Red;
                MessageBox.Show("O campo Nome é obrigatório.");
                isValid = false;
            }
            else
            {
                txtNome.BackColor = SystemColors.ActiveCaption;
            }

            if (!decimal.TryParse(txtPreco.Text.Trim(), out decimal preco) || preco <= 0)
            {
                txtPreco.BackColor = Color.Red;
                MessageBox.Show("Preço inválido. Por favor, insira um valor numérico maior que zero.");
                isValid = false;
            }
            else
            {
                txtPreco.BackColor = SystemColors.ActiveCaption;
            }

            if (string.IsNullOrWhiteSpace(txtCategoria.Text))
            {
                txtCategoria.BackColor = Color.Red;
                MessageBox.Show("O campo Categoria é obrigatório.");
                isValid = false;
            }
            else
            {
                txtCategoria.BackColor = SystemColors.ActiveCaption;
            }

            return isValid;
        }
        #endregion
        #region "ValidarCamposNaoObrigatorios"
        private bool ValidarCamposNaoObrigatorios()
        {
            if (!string.IsNullOrEmpty(txtDesc.Text) && txtDesc.Text.Length > 150)
            {
                txtDesc.BackColor = Color.Red;
                MessageBox.Show("A descrição não pode conter mais de 150 caracteres.");
                return validatingTxtBox = false;
            }
            else if (!string.IsNullOrEmpty(txtMarca.Text) && txtMarca.Text.Length > 40)
            {
                txtMarca.BackColor = Color.Red;
                MessageBox.Show("A marca não pode conter mais de 40 caracteres.");
                return validatingTxtBox = false;
            }
            else if (dtpVenda.Value < dtpEntrada.Value)
            {
                MessageBox.Show("A data de venda não pode ser anterior à data de entrada.");
                return validatingTxtBox = false;
            }
            else
            {
                return validatingTxtBox = true;
            }
        }
        #endregion
        #region "Limpar Campos"
        private void ClearInputs()
        {
            cmbLocal.Text = "";
            cmbLocal.Text = "Localização";
            txtNome.Clear();
            txtDesc.Clear();
            txtCategoria.Clear();
            txtMarca.Clear();
            txtPreco.Clear();
            txtQtdDisponivel.Clear();
            txtMotivoEntrada.Clear();
            txtMotivoSaida.Clear();
            txtSaida.Clear();
            txtEntrada.Clear();
        }
        #endregion
        #region "Voltar para Produtos"
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var prod = new Produto();
            prod.Show();
            this.Close();
        }
        #endregion
        #region "Adicionar Cores aos TextBoxes"
        private void AddingColorsToTxtBoxes()
        {
            txtCategoria.BackColor = SystemColors.ActiveCaption;
            txtDesc.BackColor = SystemColors.ActiveCaption;
            txtEntrada.BackColor = SystemColors.ActiveCaption;
            txtMarca.BackColor = SystemColors.ActiveCaption;
            txtMotivoEntrada.BackColor = SystemColors.ActiveCaption;
            txtMotivoSaida.BackColor = SystemColors.ActiveCaption;
            txtNome.BackColor = SystemColors.ActiveCaption;
            txtPreco.BackColor = SystemColors.ActiveCaption;
            txtQtdDisponivel.BackColor = SystemColors.ActiveCaption;
            txtSaida.BackColor = SystemColors.ActiveCaption;
        }
        #endregion
        #region "Restringindo txtPreco"
        private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                txtPreco.BackColor = Color.Red;
                e.Handled = true;
            }
            else
            {
                txtPreco.BackColor = SystemColors.ActiveCaption;
                e.Handled = false;
            }
        }
        #endregion
        #region "Restringindo txtQtdDisponivel"
        private void txtQtdDisponivel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                txtQtdDisponivel.BackColor = Color.Red;
                e.Handled = true;
            }
            else
            {
                txtQtdDisponivel.BackColor = SystemColors.ActiveCaption;
                e.Handled = false;
            }
        }
        #endregion
        #region "Restringindo txtSaida"
        private void txtSaida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                txtSaida.BackColor = Color.Red;
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
                txtSaida.BackColor = SystemColors.ActiveCaption;
            }
        }
        #endregion
        #region "Restringindo txtEntrada"
        private void txtEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                txtEntrada.BackColor = Color.Red;
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
                txtEntrada.BackColor = SystemColors.ActiveCaption;

            }
        }
        #endregion
        #region "Validando txtPreco"
        private void txtPreco_Leave(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtPreco.Text.Trim(), out decimal preco) || preco <= 0)
            {
                txtPreco.BackColor = Color.Red;
                MessageBox.Show("Preço inválido. Por favor, insira um valor numérico maior que 0");
            }
            else
            {
                txtPreco.BackColor = SystemColors.ActiveCaption;
            }
        }
        #endregion
        #region "Restingindo txtQtdDisponivel"
        private void txtQtdDisponivel_Leave(object sender, EventArgs e)
        {
            if(!int.TryParse(txtQtdDisponivel.Text.Trim(), out int qtdDisponivel) || qtdDisponivel < 0)
            {
                txtQtdDisponivel.BackColor = Color.Red;
                MessageBox.Show("");
            }
        }
        #endregion
    }
}