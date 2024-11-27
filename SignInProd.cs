using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flunt.Br;
using OneGroup.Class;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace OneGroup
{
    public partial class SignInProd : Form
    {
        public SignInProd()
        {
            InitializeComponent();
        }
        #region "Cadastrar Produto"
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                int qtdDisponivel;
                decimal preco;
                if (!decimal.TryParse(txtPreco.Text.Trim(), out preco))
                {
                    MessageBox.Show("Preço inválido. Por favor, insira um valor numérico válido.");
                    txtPreco.BackColor = Color.Red;
                    txtPreco.Focus();
                    return;
                }

                if (preco <= 0) 
                {
                    MessageBox.Show("O preço deve ser maior que zero.");
                    txtPreco.BackColor = Color.Red;
                    txtPreco.Focus();
                    return;
                }

                string nome = txtNome.Text.Trim();
                preco = decimal.Parse(txtPreco.Text.Trim());
                string descricao = txtDesc.Text.Trim();
                string categoria = txtCategoria.Text.Trim();
                string marca = txtMarca.Text.Trim();
                DateTime dtEntrada = dtpEntrada.Value;
                DateTime dtVenda = dtpVenda.Value;
                string localizacao = cmbLocal.Text.Trim();
                string motivoEntrada = txtMotivoEntrada.Text.Trim();
                string motivoSaida = txtMotivoSaida.Text.Trim();
                qtdDisponivel = Convert.ToInt32(txtQtdDisponivel.Text.Trim());

                int entrada = string.IsNullOrEmpty(txtEntrada.Text.Trim()) ? 0 : Convert.ToInt32(txtEntrada.Text.Trim());
                int saida = string.IsNullOrEmpty(txtSaida.Text.Trim()) ? 0 : Convert.ToInt32(txtSaida.Text.Trim());

                ValidarCadastro(nome, preco, categoria, marca, descricao, dtEntrada, dtVenda, localizacao, motivoEntrada, motivoSaida, qtdDisponivel, entrada, saida);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar produto: " + ex);
            }
        }
        #endregion

        #region "Validar Cadastro"
        private void ValidarCadastro(string nome, decimal preco, string categoria, string marca, string descricao, DateTime dtEntrada, DateTime dtVenda, string localizacao, string motivoEntrada, string motivoSaida, int qtdDisponivel, int entrada, int saida)
        {
            //try
            //{
                //var contract = new Contract();

                //contract.IsNullOrEmpty(nome, "Nome", "O campo nome deve ser preenchido.");
                //contract.IsLowerThan(preco, 0, "Preço", "O preço deve ser maior que zero.");
                //contract.IsNullOrEmpty(categoria, "Categoria", "O campo categoria deve ser preenchido.");
                //contract.IsNullOrEmpty(dtEntrada.ToString(), "Data Entrada", "O campo data entrada deve ser preenchido.");
                //contract.IsNullOrEmpty(localizacao, "Localização", "O campo localização deve ser preenchido.");
                //contract.IsNullOrEmpty(motivoEntrada, "Motivo Entrada", "O campo motivo entrada deve ser preenchido.");
                //contract.IsNullOrEmpty(qtdDisponivel.ToString(), "Quantidade Disponível", "O campo quantidade disponível deve ser preenchido.");

                ////var validarCamposNaoObrigatorios = ValidarCamposNaoObrigatorios(marca, descricao, dtEntrada, dtVenda, motivoSaida, entrada, saida);

                ////if (contract.IsValid && validarCamposNaoObrigatorios)
                //if(contract.IsValid)
                //{
                    //AddingColorsToTxtBoxes();
                    var newEstoque = new EstoqueModel(localizacao, saida, entrada, motivoEntrada, motivoSaida, qtdDisponivel);
                    var newProd = new ProdutoModel(nome, preco, descricao, categoria, marca, dtEntrada, dtVenda);
                    DataStore.Produtos.Add(newProd);
                    DataStore.Estoques.Add(newEstoque);  

                    MessageBox.Show("Cadastro realizado com sucesso!");
                    ClearInputs();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Deu erro");
            //        //ExibirErros(contract);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Erro de cadastro: " + ex);
            //}
        }
        #endregion
        
        //#region "Validar Campos Não Obrigatórios"
        //public bool ValidarCamposNaoObrigatorios(string marca, string desc, DateTime dtEntrada, DateTime dtVenda, string motivoSaida, int entrada, int saida)
        //{
        //    bool isValid = true;
        //    bool validationDate = dtVenda >= dtEntrada;  

        //    if (!string.IsNullOrEmpty(marca) && marca.Length > 40)
        //    {
        //        txtMarca.BackColor = Color.Red;
        //        txtMarca.Focus();
        //        MessageBox.Show("A marca não pode conter mais de 40 caracteres.");
        //        isValid = false;
        //    }

        //    if (!string.IsNullOrEmpty(desc) && desc.Length > 150)
        //    {
        //        txtDesc.BackColor = Color.Red;
        //        txtDesc.Focus();
        //        MessageBox.Show("A descrição não pode conter mais de 150 caracteres.");
        //        isValid = false;
        //    }

        //    if (!validationDate)
        //    {
        //        MessageBox.Show("A data de venda não pode ser anterior à data de entrada.");
        //        isValid = false;
        //    }

        //    if (!string.IsNullOrEmpty(motivoSaida) && motivoSaida.Length > 40)
        //    {
        //        txtMotivoSaida.BackColor = Color.Red;
        //        txtMotivoSaida.Focus();
        //        MessageBox.Show("O motivo de saída não pode conter mais de 40 caracteres.");
        //        isValid = false;
        //    }

        //    if (entrada < 0)
        //    {
        //        txtEntrada.BackColor = Color.Red;
        //        txtEntrada.Focus();
        //        MessageBox.Show("A entrada não pode ser negativa.");
        //        isValid = false;
        //    }

        //    if (saida < 0)
        //    {
        //        txtSaida.BackColor = Color.Red;
        //        txtSaida.Focus();
        //        MessageBox.Show("A saída não pode ser negativa.");
        //        isValid = false;
        //    }

        //    return isValid;
        //}
        //#endregion

        #region "Limpar Campos"
        private void ClearInputs()
        {
            cmbLocal.Items.Clear();
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

            dtpEntrada.Format = DateTimePickerFormat.Custom;
            dtpEntrada.CustomFormat = " ";
            dtpEntrada.Value = DateTime.Now;

            dtpVenda.Format = DateTimePickerFormat.Custom;
            dtpVenda.CustomFormat = " ";
            dtpVenda.Value = DateTime.Now;  
        }
        #endregion
        #region "Voltar para Home"
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var fornec = new Fornecedor();
            fornec.Show();
            this.Close();
        }
        #endregion
        //#region "Exibir Erros"
        //private void ExibirErros(Contract contract)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    foreach (var notification in contract.Notifications)
        //    {
        //        sb.AppendLine(notification.Message);  // Adiciona todos os erros
        //    }

        //    MessageBox.Show(sb.ToString(), "Erros de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //}
        //#endregion

        #region "Adicionar Cores aos TextBoxes"
        private void AddingColorsToTxtBoxes()
        {
            txtCategoria.BackColor = SystemColors.ActiveCaption;
            txtDesc.BackColor = SystemColors.ActiveCaption;
            txtEntrada.BackColor = SystemColors.ActiveCaption;
            txtLocal.BackColor = SystemColors.ActiveCaption;
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
                txtPreco.Focus();
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
                txtQtdDisponivel.Focus();
                e.Handled = true;
            }
        }
        #endregion

        private void txtSaida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                txtSaida.BackColor = Color.Red;
                txtSaida.Focus();
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
                txtSaida.BackColor = SystemColors.ActiveCaption;
            }
        }

        private void txtEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            { 
                txtEntrada.BackColor = Color.Red;
                txtEntrada.Focus();
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
                txtEntrada.BackColor = SystemColors.ActiveCaption;
            }
        }
    }
}
