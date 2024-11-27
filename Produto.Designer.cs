namespace OneGroup
{
    partial class Produto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSalvar = new Button();
            btnDeletar = new Button();
            btnNovo = new Button();
            btnVoltar = new Button();
            dataGridViewProd = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Preco = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Descricao = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Marca = new DataGridViewTextBoxColumn();
            IdEstoque = new DataGridViewTextBoxColumn();
            DtEntrada = new DataGridViewTextBoxColumn();
            DtVenda = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            btnExibir = new Button();
            txtPesquisa = new TextBox();
            btnPesquisar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProd).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Turquoise;
            btnSalvar.Location = new Point(225, 144);
            btnSalvar.Margin = new Padding(2);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 29);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.BackColor = Color.Red;
            btnDeletar.Location = new Point(74, 144);
            btnDeletar.Margin = new Padding(2);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(75, 29);
            btnDeletar.TabIndex = 1;
            btnDeletar.Text = "DELETAR";
            btnDeletar.UseVisualStyleBackColor = false;
            btnDeletar.Click += btnDeletarProd_Click;
            // 
            // btnNovo
            // 
            btnNovo.BackColor = Color.GreenYellow;
            btnNovo.Location = new Point(371, 144);
            btnNovo.Margin = new Padding(2);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(75, 29);
            btnNovo.TabIndex = 2;
            btnNovo.Text = "NOVO";
            btnNovo.UseVisualStyleBackColor = false;
            btnNovo.Click += btnNovoProd_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Orange;
            btnVoltar.Location = new Point(523, 144);
            btnVoltar.Margin = new Padding(2);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 29);
            btnVoltar.TabIndex = 3;
            btnVoltar.Text = "VOLTAR";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // dataGridViewProd
            // 
            dataGridViewProd.AllowUserToResizeColumns = false;
            dataGridViewProd.AllowUserToResizeRows = false;
            dataGridViewProd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProd.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewProd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProd.Columns.AddRange(new DataGridViewColumn[] { Id, Preco, Nome, Descricao, Categoria, Marca, IdEstoque, DtEntrada, DtVenda });
            dataGridViewProd.Location = new Point(9, 35);
            dataGridViewProd.Margin = new Padding(2);
            dataGridViewProd.Name = "dataGridViewProd";
            dataGridViewProd.RowHeadersWidth = 62;
            dataGridViewProd.Size = new Size(731, 105);
            dataGridViewProd.TabIndex = 4;
            dataGridViewProd.CellValueChanged += dataGridViewProd_CellValueChanged;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "ID";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Preco
            // 
            Preco.DataPropertyName = "Preco";
            Preco.HeaderText = "Preço";
            Preco.MinimumWidth = 8;
            Preco.Name = "Preco";
            // 
            // Nome
            // 
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "Nome";
            Nome.MinimumWidth = 8;
            Nome.Name = "Nome";
            // 
            // Descricao
            // 
            Descricao.DataPropertyName = "Descricao";
            Descricao.HeaderText = "Desc";
            Descricao.MinimumWidth = 8;
            Descricao.Name = "Descricao";
            // 
            // Categoria
            // 
            Categoria.DataPropertyName = "Categoria";
            Categoria.HeaderText = "Categ";
            Categoria.MinimumWidth = 8;
            Categoria.Name = "Categoria";
            // 
            // Marca
            // 
            Marca.DataPropertyName = "Marca";
            Marca.HeaderText = "Marca";
            Marca.MinimumWidth = 8;
            Marca.Name = "Marca";
            // 
            // IdEstoque
            // 
            IdEstoque.DataPropertyName = "IdEstoque";
            IdEstoque.HeaderText = "CódEstoque";
            IdEstoque.MinimumWidth = 8;
            IdEstoque.Name = "IdEstoque";
            // 
            // DtEntrada
            // 
            DtEntrada.DataPropertyName = "DtEntrada";
            DtEntrada.HeaderText = "DtEntrada";
            DtEntrada.MinimumWidth = 8;
            DtEntrada.Name = "DtEntrada";
            // 
            // DtVenda
            // 
            DtVenda.DataPropertyName = "DtVenda";
            DtVenda.HeaderText = "DtVenda";
            DtVenda.MinimumWidth = 8;
            DtVenda.Name = "DtVenda";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnExibir);
            panel1.Controls.Add(txtPesquisa);
            panel1.Controls.Add(btnPesquisar);
            panel1.Controls.Add(btnSalvar);
            panel1.Controls.Add(dataGridViewProd);
            panel1.Controls.Add(btnDeletar);
            panel1.Controls.Add(btnVoltar);
            panel1.Controls.Add(btnNovo);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(747, 187);
            panel1.TabIndex = 5;
            // 
            // btnExibir
            // 
            btnExibir.BackColor = Color.Firebrick;
            btnExibir.Location = new Point(517, 1);
            btnExibir.Margin = new Padding(2);
            btnExibir.Name = "btnExibir";
            btnExibir.Size = new Size(105, 29);
            btnExibir.TabIndex = 7;
            btnExibir.Text = "EXIBIR TODOS";
            btnExibir.UseVisualStyleBackColor = false;
            btnExibir.Click += btnExibir_Click;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(180, 5);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.PlaceholderText = "Código ou Nome do Produto";
            txtPesquisa.Size = new Size(184, 26);
            txtPesquisa.TabIndex = 6;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.RosyBrown;
            btnPesquisar.Location = new Point(407, 1);
            btnPesquisar.Margin = new Padding(2);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(92, 29);
            btnPesquisar.TabIndex = 5;
            btnPesquisar.Text = "BUSCAR";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // Produto
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 206);
            Controls.Add(panel1);
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "Produto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Produtos";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProd).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSalvar;
        private Button btnDeletar;
        private Button btnNovo;
        private Button btnVoltar;
        private DataGridView dataGridViewProd;
        private Panel panel1;
        private TextBox txtPesquisa;
        private Button btnPesquisar;
        private Button btnExibir;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Preco;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Descricao;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn IdEstoque;
        private DataGridViewTextBoxColumn DtEntrada;
        private DataGridViewTextBoxColumn DtVenda;
    }
}