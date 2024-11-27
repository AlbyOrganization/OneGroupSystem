namespace OneGroup
{
    partial class SignInFunc
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
            txtEmail = new TextBox();
            btnVoltar = new Button();
            btnCadastrar = new Button();
            txtSenha = new TextBox();
            txtConfirmSenha = new TextBox();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.ActiveCaption;
            txtEmail.Location = new Point(41, 20);
            txtEmail.Margin = new Padding(2, 3, 2, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "E-mail";
            txtEmail.Size = new Size(200, 26);
            txtEmail.TabIndex = 2;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Red;
            btnVoltar.Location = new Point(157, 165);
            btnVoltar.Margin = new Padding(2, 3, 2, 3);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(99, 34);
            btnVoltar.TabIndex = 5;
            btnVoltar.Text = "VOLTAR";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.Cyan;
            btnCadastrar.Location = new Point(27, 165);
            btnCadastrar.Margin = new Padding(2, 3, 2, 3);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(99, 34);
            btnCadastrar.TabIndex = 6;
            btnCadastrar.Text = "CADASTRAR";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = SystemColors.ActiveCaption;
            txtSenha.Location = new Point(41, 67);
            txtSenha.Margin = new Padding(2, 3, 2, 3);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.PlaceholderText = "Senha";
            txtSenha.Size = new Size(200, 26);
            txtSenha.TabIndex = 7;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // txtConfirmSenha
            // 
            txtConfirmSenha.BackColor = SystemColors.ActiveCaption;
            txtConfirmSenha.Location = new Point(41, 113);
            txtConfirmSenha.Margin = new Padding(2, 3, 2, 3);
            txtConfirmSenha.Name = "txtConfirmSenha";
            txtConfirmSenha.PasswordChar = '*';
            txtConfirmSenha.PlaceholderText = "Confirmar Senha";
            txtConfirmSenha.Size = new Size(200, 26);
            txtConfirmSenha.TabIndex = 8;
            txtConfirmSenha.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GrayText;
            panel1.Controls.Add(btnCadastrar);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(txtConfirmSenha);
            panel1.Controls.Add(btnVoltar);
            panel1.Controls.Add(txtEmail);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(276, 208);
            panel1.TabIndex = 9;
            // 
            // SignInFunc
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(305, 231);
            Controls.Add(panel1);
            Margin = new Padding(2, 3, 2, 3);
            MaximizeBox = false;
            Name = "SignInFunc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Funcionários";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtEmail;
        private Button btnVoltar;
        private Button btnCadastrar;
        private TextBox txtSenha;
        private TextBox txtConfirmSenha;
        private Panel panel1;
    }
}