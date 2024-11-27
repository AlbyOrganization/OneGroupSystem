using OneGroup.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flunt.Br;
using Contract = Flunt.Br.Contract;
using Flunt.Br.Extensions;

namespace OneGroup
{
    public partial class SignInFunc : Form
    {
        public SignInFunc()
        {
            InitializeComponent();
        }
        #region "Cadastrar Usuário"
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmail.Text.Trim();
                string senha = txtSenha.Text.Trim();
                string confirmSenha = txtConfirmSenha.Text.Trim();

                ValidarCadastro(email, senha, confirmSenha);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro encontrado: {ex}");

            }
        }
        #endregion
        #region "Validando Cadastro"
        private void ValidarCadastro(string email, string senha, string confirmSenha)
        {
            try
            {
                var contract = new Contract();
                bool validarSenha;
                contract.IsNotNullOrEmpty(senha, "Senha", "O campo senha deve ser preenchido");
                contract.IsNotNullOrEmpty(confirmSenha, "Confirmar Senha", "O campo confirmar senha deve ser preenchido");
                contract.IsEmail(email, "Email", "Email não existe ou não está correto.");

                validarSenha = ValidarSenha(senha, confirmSenha);

                if(validarSenha is false)
                {
                    return;
                }else if (contract.IsValid && validarSenha is true)
                {
                    AdicionandoCorDosCampos();

                    var newFunc = new FuncModel(email, senha);
                    DataStore.Funcs.Add(newFunc);
                    ClearInputs();
                    MessageBox.Show("Cadastro realizado com sucesso!");
                } else
                {
                    foreach(var notification in contract.Notifications)
                    {
                        switch (notification.Key)
                        {
                            case "Senha":
                                txtSenha.BackColor = Color.Red;
                                txtSenha.Focus();
                                MessageBox.Show("Senha inválida.");
                                break;
                            case "Confimar Senha":
                                txtConfirmSenha.BackColor = Color.Red;
                                txtConfirmSenha.Focus();
                                MessageBox.Show("Confirmar Senha inválida.");
                                break;
                            case "Email":
                                txtEmail.BackColor = Color.Red;
                                txtEmail.Focus();
                                MessageBox.Show("Email inválido.");
                                break;
                            default:
                                MessageBox.Show("Não foi possível cadastrar o usuário devido há campos inválidos");
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro encontrado " + ex);
            }
        }
        #endregion
        #region "Validando Senha"
        private bool ValidarSenha(string senha, string confirmSenha)
        {
            if (senha.Equals(confirmSenha))
            {
                txtEmail.BackColor = SystemColors.ActiveCaption;
                return true;
            }
            else
            {
                txtEmail.ForeColor = Color.Red;
                txtEmail.Focus();
                MessageBox.Show("O campo senha e confimar senha precisam ser iguais!");
                return false;
            }
        }
        #endregion
        #region "Limpar Campos"
        public void ClearInputs()
        {
            txtEmail.Clear();
            txtSenha.Clear();
            txtConfirmSenha.Clear();
        }
        #endregion
        #region "Navegar para a tela de Home"
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var home = new Home();
            home.Show();
            this.Close();
        }
        #endregion
        #region "Output txtEmail"
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            if(email.Length > 80)
            {
                txtEmail.BackColor = Color.Red;
                txtEmail.Text = email.Substring(0, 80);
                txtEmail.Focus();
                MessageBox.Show("O email não pode conter mais de 80 caracteres.");
                return;
            }
        }
        #endregion
        #region "Adicionando cor natural dos TextBox"
        private void AdicionandoCorDosCampos()
        {
            txtEmail.BackColor = SystemColors.ActiveCaption;
            txtSenha.BackColor = SystemColors.ActiveCaption;
            txtConfirmSenha.BackColor= SystemColors.ActiveCaption;
        }
        #endregion
    }
}
