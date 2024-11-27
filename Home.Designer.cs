namespace OneGroup
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            picbGestaoVenda = new PictureBox();
            picbSair = new PictureBox();
            picbEstoque = new PictureBox();
            picbProduto = new PictureBox();
            picbSignInUser = new PictureBox();
            panel1 = new Panel();
            label6 = new Label();
            picbFornecedor = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)picbGestaoVenda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picbSair).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picbEstoque).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picbProduto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picbSignInUser).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picbFornecedor).BeginInit();
            SuspendLayout();
            // 
            // picbGestaoVenda
            // 
            picbGestaoVenda.Image = Properties.Resources.vendas;
            picbGestaoVenda.Location = new Point(296, 110);
            picbGestaoVenda.Margin = new Padding(2, 3, 2, 3);
            picbGestaoVenda.Name = "picbGestaoVenda";
            picbGestaoVenda.Size = new Size(101, 60);
            picbGestaoVenda.SizeMode = PictureBoxSizeMode.StretchImage;
            picbGestaoVenda.TabIndex = 0;
            picbGestaoVenda.TabStop = false;
            picbGestaoVenda.Click += picbGestaoVenda_Click;
            // 
            // picbSair
            // 
            picbSair.Image = Properties.Resources.sair;
            picbSair.Location = new Point(296, 22);
            picbSair.Margin = new Padding(2, 3, 2, 3);
            picbSair.Name = "picbSair";
            picbSair.Size = new Size(101, 60);
            picbSair.SizeMode = PictureBoxSizeMode.StretchImage;
            picbSair.TabIndex = 1;
            picbSair.TabStop = false;
            picbSair.Click += picbSair_Click;
            // 
            // picbEstoque
            // 
            picbEstoque.Image = Properties.Resources.estoque;
            picbEstoque.Location = new Point(163, 110);
            picbEstoque.Margin = new Padding(2, 3, 2, 3);
            picbEstoque.Name = "picbEstoque";
            picbEstoque.Size = new Size(101, 60);
            picbEstoque.SizeMode = PictureBoxSizeMode.StretchImage;
            picbEstoque.TabIndex = 2;
            picbEstoque.TabStop = false;
            picbEstoque.Click += picbEstoque_Click;
            // 
            // picbProduto
            // 
            picbProduto.Image = Properties.Resources.produto;
            picbProduto.Location = new Point(26, 110);
            picbProduto.Margin = new Padding(2, 3, 2, 3);
            picbProduto.Name = "picbProduto";
            picbProduto.Size = new Size(101, 60);
            picbProduto.SizeMode = PictureBoxSizeMode.StretchImage;
            picbProduto.TabIndex = 3;
            picbProduto.TabStop = false;
            picbProduto.Click += picbProduto_Click;
            // 
            // picbSignInUser
            // 
            picbSignInUser.Image = Properties.Resources.func;
            picbSignInUser.Location = new Point(26, 22);
            picbSignInUser.Margin = new Padding(2, 3, 2, 3);
            picbSignInUser.Name = "picbSignInUser";
            picbSignInUser.Size = new Size(101, 60);
            picbSignInUser.SizeMode = PictureBoxSizeMode.StretchImage;
            picbSignInUser.TabIndex = 5;
            picbSignInUser.TabStop = false;
            picbSignInUser.Click += picbSignInUser_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(picbFornecedor);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(picbSair);
            panel1.Controls.Add(picbProduto);
            panel1.Controls.Add(picbSignInUser);
            panel1.Controls.Add(picbGestaoVenda);
            panel1.Controls.Add(picbEstoque);
            panel1.Location = new Point(14, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(442, 203);
            panel1.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F);
            label6.Location = new Point(167, 82);
            label6.Name = "label6";
            label6.Size = new Size(80, 19);
            label6.TabIndex = 12;
            label6.Text = "Fornecedor";
            // 
            // picbFornecedor
            // 
            picbFornecedor.Image = (Image)resources.GetObject("picbFornecedor.Image");
            picbFornecedor.Location = new Point(163, 22);
            picbFornecedor.Margin = new Padding(2, 3, 2, 3);
            picbFornecedor.Name = "picbFornecedor";
            picbFornecedor.Size = new Size(101, 60);
            picbFornecedor.SizeMode = PictureBoxSizeMode.StretchImage;
            picbFornecedor.TabIndex = 11;
            picbFornecedor.TabStop = false;
            picbFornecedor.Click += picbFornecedor_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F);
            label5.Location = new Point(18, 84);
            label5.Name = "label5";
            label5.Size = new Size(95, 19);
            label5.TabIndex = 10;
            label5.Text = "Novo Usuário";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F);
            label4.Location = new Point(177, 172);
            label4.Name = "label4";
            label4.Size = new Size(58, 19);
            label4.TabIndex = 9;
            label4.Text = "Estoque";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F);
            label3.Location = new Point(25, 172);
            label3.Name = "label3";
            label3.Size = new Size(64, 19);
            label3.TabIndex = 8;
            label3.Text = "Produtos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(283, 172);
            label2.Name = "label2";
            label2.Size = new Size(119, 19);
            label2.TabIndex = 7;
            label2.Text = "Gestão de Vendas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F);
            label1.Location = new Point(325, 84);
            label1.Name = "label1";
            label1.Size = new Size(33, 19);
            label1.TabIndex = 6;
            label1.Text = "Sair";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 229);
            Controls.Add(panel1);
            Margin = new Padding(2, 3, 2, 3);
            MaximizeBox = false;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)picbGestaoVenda).EndInit();
            ((System.ComponentModel.ISupportInitialize)picbSair).EndInit();
            ((System.ComponentModel.ISupportInitialize)picbEstoque).EndInit();
            ((System.ComponentModel.ISupportInitialize)picbProduto).EndInit();
            ((System.ComponentModel.ISupportInitialize)picbSignInUser).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picbFornecedor).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picbGestaoVenda;
        private PictureBox picbSair;
        private PictureBox picbEstoque;
        private PictureBox picbProduto;
        private PictureBox picbSignInUser;
        private Panel panel1;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label6;
        private PictureBox picbFornecedor;
    }
}