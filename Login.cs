using OneGroup.Class;

namespace OneGroup
{
    public partial class Login : Form
    {
        FuncModel func;

        public Login()
        {
            InitializeComponent();
        }

        #region "Limpar Campos"
        public void ClearInputs()
        {
            txtEmail.Clear();
            txtSenha.Clear();
        }
        #endregion
        #region "Login"
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string inputEmail = txtEmail.Text.Trim();
                string inputPassword = txtSenha.Text.Trim();

                func = DataStore.Funcs.FirstOrDefault(func => func.Email.Equals(inputEmail, StringComparison.OrdinalIgnoreCase) && func.Senha == inputPassword);

                if (func != null)
                {
                    var home = new Home();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Código ou senha inválidos. Tente Novamente.");
                    ClearInputs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro encontrado " + ex.Message);
            }
        }
        #endregion
        #region "Logoff"
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}