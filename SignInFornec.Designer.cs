namespace OneGroup
{
    partial class SignInFornec
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
            components = new System.ComponentModel.Container();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtCnpj = new TextBox();
            txtFone = new TextBox();
            btnVoltar = new Button();
            btnCadastrar = new Button();
            panel1 = new Panel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.BackColor = SystemColors.ActiveCaption;
            txtNome.Location = new Point(37, 12);
            txtNome.Margin = new Padding(2, 3, 2, 3);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome";
            txtNome.Size = new Size(231, 26);
            txtNome.TabIndex = 0;
            txtNome.KeyPress += txtNome_KeyPress;
            txtNome.Leave += txtNome_Leave;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.ActiveCaption;
            txtEmail.Location = new Point(37, 53);
            txtEmail.Margin = new Padding(2, 3, 2, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "E-mail";
            txtEmail.Size = new Size(231, 26);
            txtEmail.TabIndex = 1;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // txtCnpj
            // 
            txtCnpj.BackColor = SystemColors.ActiveCaption;
            txtCnpj.Location = new Point(37, 96);
            txtCnpj.Margin = new Padding(2, 3, 2, 3);
            txtCnpj.Name = "txtCnpj";
            txtCnpj.PlaceholderText = "CNPJ";
            txtCnpj.Size = new Size(231, 26);
            txtCnpj.TabIndex = 2;
            txtCnpj.KeyPress += txtCnpj_KeyPress;
            txtCnpj.Leave += txtCnpj_Leave;
            // 
            // txtFone
            // 
            txtFone.BackColor = SystemColors.ActiveCaption;
            txtFone.Location = new Point(37, 141);
            txtFone.Margin = new Padding(2, 3, 2, 3);
            txtFone.Name = "txtFone";
            txtFone.PlaceholderText = "Telefone";
            txtFone.Size = new Size(231, 26);
            txtFone.TabIndex = 4;
            txtFone.KeyPress += txtFone_KeyPress;
            txtFone.Leave += txtFone_Leave;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Red;
            btnVoltar.Location = new Point(158, 174);
            btnVoltar.Margin = new Padding(2, 3, 2, 3);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(96, 35);
            btnVoltar.TabIndex = 5;
            btnVoltar.Text = "VOLTAR";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.Cyan;
            btnCadastrar.Location = new Point(48, 174);
            btnCadastrar.Margin = new Padding(2, 3, 2, 3);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(96, 35);
            btnCadastrar.TabIndex = 6;
            btnCadastrar.Text = "CADASTRAR";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GrayText;
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(btnCadastrar);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(btnVoltar);
            panel1.Controls.Add(txtCnpj);
            panel1.Controls.Add(txtFone);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(309, 218);
            panel1.TabIndex = 7;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // SignInFornec
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 238);
            Controls.Add(panel1);
            Margin = new Padding(2, 3, 2, 3);
            MaximizeBox = false;
            Name = "SignInFornec";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Fornecedor";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtCnpj;
        private TextBox txtFone;
        private Button btnVoltar;
        private Button btnCadastrar;
        private Panel panel1;
        private ContextMenuStrip contextMenuStrip1;
    }
}