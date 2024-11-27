namespace OneGroup
{
    partial class Estoque
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
            dataGridViewEstoque = new DataGridView();
            IdEstoque = new DataGridViewTextBoxColumn();
            Localizacao = new DataGridViewTextBoxColumn();
            MotivoEntrada = new DataGridViewTextBoxColumn();
            MotivoSaida = new DataGridViewTextBoxColumn();
            DataAtualizacao = new DataGridViewTextBoxColumn();
            QtdDisponivel = new DataGridViewTextBoxColumn();
            Entrada = new DataGridViewTextBoxColumn();
            Saida = new DataGridViewTextBoxColumn();
            btnVoltar = new Button();
            btnDeletar = new Button();
            btnSalvar = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEstoque).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewEstoque
            // 
            dataGridViewEstoque.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewEstoque.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEstoque.Columns.AddRange(new DataGridViewColumn[] { IdEstoque, Localizacao, MotivoEntrada, MotivoSaida, DataAtualizacao, QtdDisponivel, Entrada, Saida });
            dataGridViewEstoque.Location = new Point(21, 10);
            dataGridViewEstoque.Margin = new Padding(2, 2, 2, 2);
            dataGridViewEstoque.Name = "dataGridViewEstoque";
            dataGridViewEstoque.RowHeadersWidth = 62;
            dataGridViewEstoque.Size = new Size(740, 80);
            dataGridViewEstoque.TabIndex = 0;
            dataGridViewEstoque.CellValueChanged += dataGridViewEstoque_CellValueChanged;
            // 
            // IdEstoque
            // 
            IdEstoque.DataPropertyName = "IdEstoque";
            IdEstoque.HeaderText = "ID";
            IdEstoque.MinimumWidth = 8;
            IdEstoque.Name = "IdEstoque";
            IdEstoque.ReadOnly = true;
            IdEstoque.Width = 43;
            // 
            // Localizacao
            // 
            Localizacao.DataPropertyName = "Localizacao";
            Localizacao.HeaderText = "Local";
            Localizacao.MinimumWidth = 8;
            Localizacao.Name = "Localizacao";
            Localizacao.Width = 60;
            // 
            // MotivoEntrada
            // 
            MotivoEntrada.DataPropertyName = "MotivoEntrada";
            MotivoEntrada.HeaderText = "MotivoEntrada";
            MotivoEntrada.MinimumWidth = 8;
            MotivoEntrada.Name = "MotivoEntrada";
            MotivoEntrada.Width = 110;
            // 
            // MotivoSaida
            // 
            MotivoSaida.DataPropertyName = "MotivoSaida";
            MotivoSaida.HeaderText = "MotivoSaida";
            MotivoSaida.MinimumWidth = 8;
            MotivoSaida.Name = "MotivoSaida";
            MotivoSaida.Width = 98;
            // 
            // DataAtualizacao
            // 
            DataAtualizacao.DataPropertyName = "DataAtualizacao";
            DataAtualizacao.HeaderText = "DtAtualizacao";
            DataAtualizacao.MinimumWidth = 8;
            DataAtualizacao.Name = "DataAtualizacao";
            DataAtualizacao.Width = 105;
            // 
            // QtdDisponivel
            // 
            QtdDisponivel.DataPropertyName = "QtdDisponivel";
            QtdDisponivel.HeaderText = "QtdDisponivel";
            QtdDisponivel.MinimumWidth = 8;
            QtdDisponivel.Name = "QtdDisponivel";
            QtdDisponivel.Width = 107;
            // 
            // Entrada
            // 
            Entrada.DataPropertyName = "Entrada";
            Entrada.HeaderText = "QtdEntrada";
            Entrada.MinimumWidth = 8;
            Entrada.Name = "Entrada";
            Entrada.Width = 92;
            // 
            // Saida
            // 
            Saida.DataPropertyName = "Saida";
            Saida.HeaderText = "QtdSaida";
            Saida.MinimumWidth = 8;
            Saida.Name = "Saida";
            Saida.Width = 80;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Orange;
            btnVoltar.Location = new Point(606, 99);
            btnVoltar.Margin = new Padding(2, 2, 2, 2);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(66, 23);
            btnVoltar.TabIndex = 1;
            btnVoltar.Text = "VOLTAR";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.BackColor = Color.Red;
            btnDeletar.Location = new Point(147, 99);
            btnDeletar.Margin = new Padding(2, 2, 2, 2);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(66, 23);
            btnDeletar.TabIndex = 4;
            btnDeletar.Text = "DELETAR";
            btnDeletar.UseVisualStyleBackColor = false;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Turquoise;
            btnSalvar.Location = new Point(376, 99);
            btnSalvar.Margin = new Padding(2, 2, 2, 2);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(66, 23);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(dataGridViewEstoque);
            panel1.Controls.Add(btnVoltar);
            panel1.Controls.Add(btnSalvar);
            panel1.Controls.Add(btnDeletar);
            panel1.Location = new Point(12, 11);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(785, 131);
            panel1.TabIndex = 6;
            // 
            // Estoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(808, 153);
            Controls.Add(panel1);
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            Name = "Estoque";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estoque";
            ((System.ComponentModel.ISupportInitialize)dataGridViewEstoque).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewEstoque;
        private Button btnVoltar;
        private Button btnDeletar;
        private Button btnSalvar;
        private Panel panel1;
        private DataGridViewTextBoxColumn IdEstoque;
        private DataGridViewTextBoxColumn Localizacao;
        private DataGridViewTextBoxColumn MotivoEntrada;
        private DataGridViewTextBoxColumn MotivoSaida;
        private DataGridViewTextBoxColumn DataAtualizacao;
        private DataGridViewTextBoxColumn QtdDisponivel;
        private DataGridViewTextBoxColumn Entrada;
        private DataGridViewTextBoxColumn Saida;
    }
}