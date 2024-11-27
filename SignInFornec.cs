using Flunt.Br;
using Flunt.Br.Extensions;
using OneGroup.Class;
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

namespace OneGroup
{
    public partial class SignInFornec : Form
    {
        public SignInFornec()
        {
            InitializeComponent();
        }
        #region "Cadastrar Fornecedor"
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNome.Text.Trim();
                string email = txtEmail.Text.Trim();
                string cnpj = txtCnpj.Text.Trim();
                string fone = txtFone.Text.Trim();

                ValidarCadastro(nome, email, fone, cnpj);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar fornecedor: " + ex);
            }

        }
        #endregion
        #region "Validar Cadastro"
        private void ValidarCadastro(string nome, string fone, string email, string cnpj)
        {
            try
            {
                var contract = new Contract();
                contract.IsNotNullOrEmpty(nome, "Nome", "O campo nome deve ser preenchido.");
                contract.IsNotNullOrEmpty(fone, "Telefone", "O campo telefone deve ser preenchido.");
                contract.IsNotNullOrEmpty(email, "Email", "O campo email deve ser preenchido.");
                contract.IsNotNullOrEmpty(cnpj, "Cnpj", "O campo cnpj deve ser preenchido.");

                cnpj = Regex.Replace(cnpj, @"[^\d]", ""); 


                //contract.IsEmail(email, "Email", "Email não existe ou está incorreto.");
                //contract.IsCnpj(cnpj, "Cnpj", "CNPJ não existe ou está incorreto.");

                if (contract.IsValid)
                {
                    MessageBox.Show("Cadastro realizado com sucesso!");
                    var newFornec = new FornecedorModel(nome, email, cnpj, fone);
                    DataStore.Fornecedores.Add(newFornec);
                    AddingColorsToTxtBoxes();
                    ClearInputs();
                } else
                {
                    ResetColors();

                    foreach (var notification in contract.Notifications)
                    {
                        switch (notification.Key)
                        {
                            case "Nome":
                                txtNome.BackColor = Color.Red;
                                txtNome.Focus();
                                MessageBox.Show("Nome inválido.");
                                break;
                            case "Telefone":
                                txtFone.BackColor = Color.Red;
                                txtFone.Focus();
                                MessageBox.Show("Telefone inválido.");
                                break;
                            case "Email":
                                txtEmail.BackColor = Color.Red;
                                txtEmail.Focus();
                                MessageBox.Show("Email inválido.");
                                break;
                            case "Cnpj":
                                txtCnpj.BackColor = Color.Red;
                                txtCnpj.Focus();
                                MessageBox.Show("Cnpj inválido.");
                                break;
                            default:
                                MessageBox.Show("Não foi possível cadastrar o fornecedor devido há campos inválidos");
                                break;
                        }

                        MessageBox.Show(notification.Message);
                    }
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar validar cadastro: " + ex);
            }
        }
        #endregion
        #region "Validando txtFone"
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            string pattern = @"^(\(?[0-9]{2}\)?)? ?([0-9]{4,5})-?([0-9]{4})$";
            return Regex.IsMatch(phoneNumber, pattern);
        }
        #endregion
        #region "Limpar Campos"
        private void ClearInputs()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtCnpj.Clear();
            txtFone.Clear();
        }
        #endregion
        #region "Navegar para a página de Gestão de Vendas"
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var fornec = new Fornecedor();
            fornec.Show();
            this.Close();
        }
        #endregion
        #region "Restringindo Caracteres em txtFone"
        private void txtFone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                txtFone.BackColor = Color.Red;
                txtFone.Focus();
                e.Handled = true;
            }
            else
            {
                txtFone.BackColor = SystemColors.ActiveCaption;
            }
        }
        #endregion
        #region "Output de txtFone"
        private void txtFone_Leave(object sender, EventArgs e)
        {
            string fone = txtFone.Text.Trim();

            try
            {
                txtFone.Text = FormatarFone(fone);
            }  catch (Exception ex)
            {
                txtFone.Text = FormatarFone(fone);
                txtFone.BackColor = Color.Red;
                txtFone.Focus();
                MessageBox.Show(ex.Message);
                return;
            }
            if (!IsValidPhoneNumber(fone))
            {
                txtFone.BackColor = Color.Red;
                txtFone.Focus();
                MessageBox.Show("Número de telefone inválido.");
            }
            else
            {
                txtFone.BackColor = SystemColors.ActiveCaption;
            }

        }
        #endregion
        #region "Formatar Telefone"
        private string FormatarFone(string phoneNumber)
        {
            phoneNumber = Regex.Replace(phoneNumber, @"[^\d]", "");

            if (phoneNumber.Length == 10)
            {
                return $"({phoneNumber.Substring(0, 2)}) {phoneNumber.Substring(2, 4)}-{phoneNumber.Substring(6)}";
            }
            else if (phoneNumber.Length == 11)
            {
                return $"({phoneNumber.Substring(0, 2)}) {phoneNumber.Substring(2, 5)}-{phoneNumber.Substring(7)}";
            }
            else
            {
                MessageBox.Show("Número de telefone deve ter 10 ou 11 dígitos.");
                return phoneNumber;
            }
        }
        #endregion
        #region "Resetar Cores"
        private void ResetColors()
        {
            txtNome.BackColor = SystemColors.ActiveCaption;
            txtFone.BackColor = SystemColors.ActiveCaption;
            txtEmail.BackColor = SystemColors.ActiveCaption;
            txtCnpj.BackColor = SystemColors.ActiveCaption;
        }
        #endregion
        #region "Adicionando Cor Natural aos TextBoxes"

        private void AddingColorsToTxtBoxes()
        {
            txtNome.ForeColor = SystemColors.ActiveCaption;
            txtFone.ForeColor = SystemColors.ActiveCaption;
            txtEmail.ForeColor = SystemColors.ActiveCaption;
            txtCnpj.ForeColor = SystemColors.ActiveCaption;
        }
        #endregion
        #region "Restringindo Caracteres em txtNome"
        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                txtNome.BackColor = Color.Red;
                txtNome.Focus();
                e.Handled = true;
            }
            else
            {
                txtNome.BackColor = SystemColors.ActiveCaption;
            }
        }
        #endregion
        #region "Output de CNPJ"
        private void txtCnpj_Leave(object sender, EventArgs e)
        {
            string cnpj = txtCnpj.Text.Trim();
            FormatarCnpj(cnpj);
        }
        #endregion
        #region "Restringindo Caracteres em txtCnpj"
        private void txtCnpj_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                txtCnpj.BackColor = Color.Red;
                txtCnpj.Focus();
                e.Handled = true;
            }
            else
            {
                txtCnpj.BackColor= SystemColors.ActiveCaption;
            }
        }
        #endregion
        #region "Formatar CNPJ"
        private void FormatarCnpj(string cnpj)
        {
            cnpj = Regex.Replace(cnpj, @"[^\d]", "");
            if (cnpj.Length == 14)
            {
                txtCnpj.BackColor = SystemColors.ActiveCaption;
                txtCnpj.Text = Regex.Replace(cnpj, @"(\d{2})(\d{3})(\d{3})(\d{4})(\d{2})", "$1.$2.$3/$4-$5");
            }
            else
            {
                txtCnpj.BackColor = Color.Red;
                txtCnpj.Focus();
                MessageBox.Show("CNPJ deve ter 14 dígitos");
            }
        }
        #endregion
        #region "Output do txtEmail"
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();

            if (email.Length > 80)
            {
                txtEmail.Text = email.Substring(0, 80);
                txtEmail.Focus();
                MessageBox.Show("O email não pode ter mais de 80 caracteres.");
                return;
            }
        }
        #endregion
        #region "Output txtNome"
        private void txtNome_Leave(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            if(nome.Length > 100)
            {
                MessageBox.Show("O nome não pode conter mais de 100 caracteres.");
                txtNome.Text = nome.Substring(0, 100);
                txtNome.Focus();
                return;
            }
        }
        #endregion
    }
}
