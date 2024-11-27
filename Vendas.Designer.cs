namespace OneGroup
{
    partial class Vendas
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
            panel1 = new Panel();
            lblDisponivel = new Label();
            label1 = new Label();
            txtQntVendida = new TextBox();
            txtId = new TextBox();
            btnCadastrar = new Button();
            btnVoltar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GrayText;
            panel1.Controls.Add(lblDisponivel);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtQntVendida);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(btnCadastrar);
            panel1.Controls.Add(btnVoltar);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(476, 165);
            panel1.TabIndex = 8;
            // 
            // lblDisponivel
            // 
            lblDisponivel.AutoSize = true;
            lblDisponivel.Location = new Point(434, 15);
            lblDisponivel.Name = "lblDisponivel";
            lblDisponivel.Size = new Size(12, 19);
            lblDisponivel.TabIndex = 9;
            lblDisponivel.Text = ".";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(277, 15);
            label1.Name = "label1";
            label1.Size = new Size(151, 19);
            label1.TabIndex = 8;
            label1.Text = "Quantidade Disponível:";
            // 
            // txtQntVendida
            // 
            txtQntVendida.BackColor = SystemColors.ActiveCaption;
            txtQntVendida.Location = new Point(25, 58);
            txtQntVendida.Margin = new Padding(2, 3, 2, 3);
            txtQntVendida.Name = "txtQntVendida";
            txtQntVendida.PlaceholderText = "Quantidade Vendida";
            txtQntVendida.Size = new Size(231, 26);
            txtQntVendida.TabIndex = 7;
            txtQntVendida.KeyPress += txtQntVendida_KeyPress;
            txtQntVendida.Leave += txtQntVendida_Leave;
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.ActiveCaption;
            txtId.Location = new Point(25, 12);
            txtId.Margin = new Padding(2, 3, 2, 3);
            txtId.Name = "txtId";
            txtId.PlaceholderText = "Código do Produto";
            txtId.Size = new Size(231, 26);
            txtId.TabIndex = 0;
            txtId.KeyPress += txtId_KeyPress;
            txtId.Leave += txtId_Leave;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.Cyan;
            btnCadastrar.Location = new Point(25, 114);
            btnCadastrar.Margin = new Padding(2, 3, 2, 3);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(96, 35);
            btnCadastrar.TabIndex = 6;
            btnCadastrar.Text = "VENDER";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Red;
            btnVoltar.Location = new Point(160, 114);
            btnVoltar.Margin = new Padding(2, 3, 2, 3);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(96, 35);
            btnVoltar.TabIndex = 5;
            btnVoltar.Text = "VOLTAR";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // Vendas
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 187);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "Vendas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vendas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtQntVendida;
        private TextBox txtId;
        private Button btnCadastrar;
        private Button btnVoltar;
        private Label label1;
        private Label lblDisponivel;
    }
}