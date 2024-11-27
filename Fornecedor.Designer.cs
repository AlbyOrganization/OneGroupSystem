namespace OneGroup
{
    partial class Fornecedor
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
            dataGridViewFornec = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            CNPJ = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Telefone = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            btnVoltar = new Button();
            btnNovo = new Button();
            btnDeletar = new Button();
            panel1 = new Panel();
            btnSalvar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFornec).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewFornec
            // 
            dataGridViewFornec.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewFornec.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewFornec.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFornec.Columns.AddRange(new DataGridViewColumn[] { ID, CNPJ, Email, Telefone, Nome });
            dataGridViewFornec.Location = new Point(3, 23);
            dataGridViewFornec.Name = "dataGridViewFornec";
            dataGridViewFornec.Size = new Size(608, 87);
            dataGridViewFornec.TabIndex = 0;
            dataGridViewFornec.CellValueChanged += dataGridViewFornec_CellValueChanged;
            // 
            // ID
            // 
            ID.DataPropertyName = "Id";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // CNPJ
            // 
            CNPJ.DataPropertyName = "Cnpj";
            CNPJ.HeaderText = "CNPJ";
            CNPJ.Name = "CNPJ";
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.Name = "Email";
            // 
            // Telefone
            // 
            Telefone.DataPropertyName = "Telefone";
            Telefone.HeaderText = "Telefone";
            Telefone.Name = "Telefone";
            // 
            // Nome
            // 
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Orange;
            btnVoltar.Location = new Point(447, 116);
            btnVoltar.Margin = new Padding(2, 3, 2, 3);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 29);
            btnVoltar.TabIndex = 6;
            btnVoltar.Text = "VOLTAR";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnNovo
            // 
            btnNovo.BackColor = Color.GreenYellow;
            btnNovo.Location = new Point(343, 116);
            btnNovo.Margin = new Padding(2, 3, 2, 3);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(75, 29);
            btnNovo.TabIndex = 9;
            btnNovo.Text = "NOVO";
            btnNovo.UseVisualStyleBackColor = false;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.BackColor = Color.Red;
            btnDeletar.Location = new Point(30, 116);
            btnDeletar.Margin = new Padding(2, 3, 2, 3);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(75, 29);
            btnDeletar.TabIndex = 8;
            btnDeletar.Text = "DELETAR";
            btnDeletar.UseVisualStyleBackColor = false;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnSalvar);
            panel1.Controls.Add(dataGridViewFornec);
            panel1.Controls.Add(btnVoltar);
            panel1.Controls.Add(btnDeletar);
            panel1.Controls.Add(btnNovo);
            panel1.Location = new Point(14, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(615, 165);
            panel1.TabIndex = 10;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Turquoise;
            btnSalvar.Location = new Point(179, 116);
            btnSalvar.Margin = new Padding(2, 3, 2, 3);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 29);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // Fornecedor
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 194);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "Fornecedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fornecedor";
            ((System.ComponentModel.ISupportInitialize)dataGridViewFornec).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewFornec;
        private Button btnVoltar;
        private Button btnNovo;
        private Button btnDeletar;
        private Panel panel1;
        private Button btnSalvar;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn CNPJ;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Telefone;
        private DataGridViewTextBoxColumn Nome;
    }
}