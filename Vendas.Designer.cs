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
            btnVender = new Button();
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
            panel1.Controls.Add(btnVender);
            panel1.Controls.Add(btnVoltar);
            panel1.Location = new Point(10, 9);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(416, 130);
            panel1.TabIndex = 8;
            // 
            // lblDisponivel
            // 
            lblDisponivel.AutoSize = true;
            lblDisponivel.Location = new Point(380, 12);
            lblDisponivel.Name = "lblDisponivel";
            lblDisponivel.Size = new Size(10, 15);
            lblDisponivel.TabIndex = 9;
            lblDisponivel.Text = ".";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(242, 12);
            label1.Name = "label1";
            label1.Size = new Size(130, 15);
            label1.TabIndex = 8;
            label1.Text = "Quantidade Disponível:";
            // 
            // txtQntVendida
            // 
            txtQntVendida.BackColor = SystemColors.ActiveCaption;
            txtQntVendida.Location = new Point(22, 46);
            txtQntVendida.Margin = new Padding(2, 2, 2, 2);
            txtQntVendida.Name = "txtQntVendida";
            txtQntVendida.PlaceholderText = "Quantidade Vendida";
            txtQntVendida.Size = new Size(203, 23);
            txtQntVendida.TabIndex = 7;
            txtQntVendida.KeyPress += txtQntVendida_KeyPress;
            txtQntVendida.Leave += txtQntVendida_Leave;
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.ActiveCaption;
            txtId.Location = new Point(22, 9);
            txtId.Margin = new Padding(2, 2, 2, 2);
            txtId.Name = "txtId";
            txtId.PlaceholderText = "Código do Produto";
            txtId.Size = new Size(203, 23);
            txtId.TabIndex = 0;
            txtId.KeyPress += txtId_KeyPress;
            txtId.Leave += txtId_Leave;
            // 
            // btnVender
            // 
            btnVender.BackColor = Color.Cyan;
            btnVender.Location = new Point(22, 90);
            btnVender.Margin = new Padding(2, 2, 2, 2);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(84, 28);
            btnVender.TabIndex = 6;
            btnVender.Text = "VENDER";
            btnVender.UseVisualStyleBackColor = false;
            btnVender.Click += btnVender_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Red;
            btnVoltar.Location = new Point(140, 90);
            btnVoltar.Margin = new Padding(2, 2, 2, 2);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(84, 28);
            btnVoltar.TabIndex = 5;
            btnVoltar.Text = "VOLTAR";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // Vendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 148);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
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
        private Button btnVender;
        private Button btnVoltar;
        private Label label1;
        private Label lblDisponivel;
    }
}