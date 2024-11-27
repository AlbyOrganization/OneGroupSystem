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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        #region Navegar para a página Gestão de Vendas"
        private void picbGestaoVenda_Click(object sender, EventArgs e)
        {
            var gestVenda = new GestaoVenda();
            gestVenda.Show();
            this.Hide();
        }
        #endregion
        #region "Navegar para a página Login"
        private void picbSair_Click(object sender, EventArgs e)
        {
            var login = new Login();
            login.Show();
            this.Close();
        }
        #endregion
        #region "Navegar para a página Estoque"

        private void picbEstoque_Click(object sender, EventArgs e)
        {
            var estoque = new Estoque();
            estoque.Show();
            this.Hide();
        }
        #endregion
        #region "Navegar para a página Produto"
        private void picbProduto_Click(object sender, EventArgs e)
        {
            var produto = new Produto();
            produto.Show();
            this.Hide();
        }
        #endregion
        #region "Cadastrar Usuário"
        private void picbSignInUser_Click(object sender, EventArgs e)
        {
            var signInUser = new SignInFunc();
            signInUser.Show();
            this.Hide();
        }
        #endregion
        #region "Navegar para a página Fornecedor"
        private void picbFornecedor_Click(object sender, EventArgs e)
        {
            var fornec = new Fornecedor();
            fornec.Show();
            this.Hide();
        }
        #endregion
    }
}
