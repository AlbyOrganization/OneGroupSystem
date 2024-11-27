namespace OneGroup
{
    partial class GestaoVenda
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
            btnVoltar = new Button();
            dataGridViewProd = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Preco = new DataGridViewTextBoxColumn();
            DtEntrada = new DataGridViewTextBoxColumn();
            DtVenda = new DataGridViewTextBoxColumn();
            btnDeletarGestaoVenda = new Button();
            btnSalvar = new Button();
            panel1 = new Panel();
            dataGridViewEstoque = new DataGridView();
            btnVendas = new Button();
            IdEstoque = new DataGridViewTextBoxColumn();
            DataAtualizacao = new DataGridViewTextBoxColumn();
            QtdDisponivel = new DataGridViewTextBoxColumn();
            QntVenda = new DataGridViewTextBoxColumn();
            Entrada = new DataGridViewTextBoxColumn();
            Saida = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProd).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEstoque).BeginInit();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Orange;
            btnVoltar.Location = new Point(538, 239);
            btnVoltar.Margin = new Padding(2, 3, 2, 3);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 29);
            btnVoltar.TabIndex = 0;
            btnVoltar.Text = "VOLTAR";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // dataGridViewProd
            // 
            dataGridViewProd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProd.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewProd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProd.Columns.AddRange(new DataGridViewColumn[] { Id, Nome, Preco, DtEntrada, DtVenda });
            dataGridViewProd.Location = new Point(22, 16);
            dataGridViewProd.Margin = new Padding(2, 3, 2, 3);
            dataGridViewProd.Name = "dataGridViewProd";
            dataGridViewProd.RowHeadersWidth = 62;
            dataGridViewProd.Size = new Size(650, 83);
            dataGridViewProd.TabIndex = 2;
            dataGridViewProd.CellBeginEdit += dataGridViewVendas_CellBeginEdit;
            dataGridViewProd.CellValueChanged += dataGridViewVendas_CellValueChanged;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "IdProd";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Nome
            // 
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "Nome";
            Nome.MinimumWidth = 8;
            Nome.Name = "Nome";
            // 
            // Preco
            // 
            Preco.DataPropertyName = "Preco";
            Preco.HeaderText = "Preco";
            Preco.MinimumWidth = 8;
            Preco.Name = "Preco";
            // 
            // DtEntrada
            // 
            DtEntrada.DataPropertyName = "DtEntrada";
            DtEntrada.HeaderText = "DtEntrada";
            DtEntrada.Name = "DtEntrada";
            // 
            // DtVenda
            // 
            DtVenda.DataPropertyName = "DtVenda";
            DtVenda.HeaderText = "DtVenda";
            DtVenda.Name = "DtVenda";
            // 
            // btnDeletarGestaoVenda
            // 
            btnDeletarGestaoVenda.BackColor = Color.Red;
            btnDeletarGestaoVenda.Location = new Point(109, 239);
            btnDeletarGestaoVenda.Margin = new Padding(2, 3, 2, 3);
            btnDeletarGestaoVenda.Name = "btnDeletarGestaoVenda";
            btnDeletarGestaoVenda.Size = new Size(75, 29);
            btnDeletarGestaoVenda.TabIndex = 4;
            btnDeletarGestaoVenda.Text = "DELETAR";
            btnDeletarGestaoVenda.UseVisualStyleBackColor = false;
            btnDeletarGestaoVenda.Click += btnDeletarGestaoVenda_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Turquoise;
            btnSalvar.Location = new Point(238, 239);
            btnSalvar.Margin = new Padding(2, 3, 2, 3);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 29);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(dataGridViewEstoque);
            panel1.Controls.Add(btnVendas);
            panel1.Controls.Add(dataGridViewProd);
            panel1.Controls.Add(btnVoltar);
            panel1.Controls.Add(btnSalvar);
            panel1.Controls.Add(btnDeletarGestaoVenda);
            panel1.Location = new Point(12, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(690, 290);
            panel1.TabIndex = 6;
            // 
            // dataGridViewEstoque
            // 
            dataGridViewEstoque.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEstoque.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEstoque.Columns.AddRange(new DataGridViewColumn[] { IdEstoque, DataAtualizacao, QtdDisponivel, QntVenda, Entrada, Saida });
            dataGridViewEstoque.Location = new Point(22, 114);
            dataGridViewEstoque.Margin = new Padding(2, 3, 2, 3);
            dataGridViewEstoque.Name = "dataGridViewEstoque";
            dataGridViewEstoque.RowHeadersWidth = 62;
            dataGridViewEstoque.Size = new Size(650, 83);
            dataGridViewEstoque.TabIndex = 11;
            dataGridViewEstoque.CellBeginEdit += dataGridViewEstoque_CellBeginEdit;
            dataGridViewEstoque.CellValueChanged += dataGridViewEstoque_CellValueChanged;
            // 
            // btnVendas
            // 
            btnVendas.BackColor = Color.GreenYellow;
            btnVendas.Location = new Point(389, 239);
            btnVendas.Margin = new Padding(2, 3, 2, 3);
            btnVendas.Name = "btnVendas";
            btnVendas.Size = new Size(75, 29);
            btnVendas.TabIndex = 10;
            btnVendas.Text = "VENDER";
            btnVendas.UseVisualStyleBackColor = false;
            btnVendas.Click += btnVendas_Click;
            // 
            // IdEstoque
            // 
            IdEstoque.DataPropertyName = "IdEstoque";
            IdEstoque.HeaderText = "IdEstoque";
            IdEstoque.MinimumWidth = 8;
            IdEstoque.Name = "IdEstoque";
            IdEstoque.ReadOnly = true;
            // 
            // DataAtualizacao
            // 
            DataAtualizacao.DataPropertyName = "DataAtualizacao";
            DataAtualizacao.HeaderText = "DtAtualizacao";
            DataAtualizacao.Name = "DataAtualizacao";
            // 
            // QtdDisponivel
            // 
            QtdDisponivel.DataPropertyName = "QtdDisponivel";
            QtdDisponivel.HeaderText = "QtdDisponivel";
            QtdDisponivel.Name = "QtdDisponivel";
            // 
            // QntVenda
            // 
            QntVenda.DataPropertyName = "QntVenda";
            QntVenda.HeaderText = "QtdVendida";
            QntVenda.Name = "QntVenda";
            // 
            // Entrada
            // 
            Entrada.DataPropertyName = "Entrada";
            Entrada.HeaderText = "Entrada";
            Entrada.Name = "Entrada";
            // 
            // Saida
            // 
            Saida.DataPropertyName = "Saida";
            Saida.HeaderText = "Saida";
            Saida.Name = "Saida";
            // 
            // GestaoVenda
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 333);
            Controls.Add(panel1);
            Margin = new Padding(2, 3, 2, 3);
            MaximizeBox = false;
            Name = "GestaoVenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestão de Vendas";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProd).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewEstoque).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnVoltar;
        private DataGridView dataGridViewProd;
        private Button btnDeletarGestaoVenda;
        private Button btnSalvar;
        private Panel panel1;
        private Button btnVendas;
        private DataGridView dataGridViewEstoque;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Preco;
        private DataGridViewTextBoxColumn DtEntrada;
        private DataGridViewTextBoxColumn DtVenda;
        private DataGridViewTextBoxColumn IdEstoque;
        private DataGridViewTextBoxColumn DataAtualizacao;
        private DataGridViewTextBoxColumn QtdDisponivel;
        private DataGridViewTextBoxColumn QntVenda;
        private DataGridViewTextBoxColumn Entrada;
        private DataGridViewTextBoxColumn Saida;
    }
}