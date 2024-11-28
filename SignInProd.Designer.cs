namespace OneGroup
{
    partial class SignInProd
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
            txtNome = new TextBox();
            txtPreco = new TextBox();
            txtDesc = new TextBox();
            txtCategoria = new TextBox();
            txtMarca = new TextBox();
            btnCadastrar = new Button();
            btnVoltar = new Button();
            dtpEntrada = new DateTimePicker();
            dtpVenda = new DateTimePicker();
            panel1 = new Panel();
            label11 = new Label();
            label10 = new Label();
            txtQtdDisponivel = new TextBox();
            label9 = new Label();
            cmbLocal = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtMotivoSaida = new TextBox();
            txtEntrada = new TextBox();
            txtSaida = new TextBox();
            txtMotivoEntrada = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.BackColor = SystemColors.ActiveCaption;
            txtNome.Location = new Point(7, 13);
            txtNome.Margin = new Padding(2, 3, 2, 3);
            txtNome.Multiline = true;
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome produto";
            txtNome.Size = new Size(101, 24);
            txtNome.TabIndex = 0;
            txtNome.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPreco
            // 
            txtPreco.BackColor = SystemColors.ActiveCaption;
            txtPreco.Location = new Point(176, 13);
            txtPreco.Margin = new Padding(2, 3, 2, 3);
            txtPreco.Multiline = true;
            txtPreco.Name = "txtPreco";
            txtPreco.PlaceholderText = "Preço";
            txtPreco.Size = new Size(101, 24);
            txtPreco.TabIndex = 1;
            txtPreco.TextAlign = HorizontalAlignment.Center;
            txtPreco.Leave += txtPreco_Leave;
            // 
            // txtDesc
            // 
            txtDesc.BackColor = SystemColors.ActiveCaption;
            txtDesc.Location = new Point(7, 98);
            txtDesc.Margin = new Padding(2, 3, 2, 3);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.PlaceholderText = "Descrição";
            txtDesc.Size = new Size(101, 26);
            txtDesc.TabIndex = 2;
            txtDesc.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCategoria
            // 
            txtCategoria.BackColor = SystemColors.ActiveCaption;
            txtCategoria.Location = new Point(7, 57);
            txtCategoria.Margin = new Padding(2, 3, 2, 3);
            txtCategoria.Multiline = true;
            txtCategoria.Name = "txtCategoria";
            txtCategoria.PlaceholderText = "Categoria";
            txtCategoria.Size = new Size(101, 24);
            txtCategoria.TabIndex = 3;
            txtCategoria.TextAlign = HorizontalAlignment.Center;
            // 
            // txtMarca
            // 
            txtMarca.BackColor = SystemColors.ActiveCaption;
            txtMarca.Location = new Point(176, 57);
            txtMarca.Margin = new Padding(2, 3, 2, 3);
            txtMarca.Multiline = true;
            txtMarca.Name = "txtMarca";
            txtMarca.PlaceholderText = "Marca";
            txtMarca.Size = new Size(101, 24);
            txtMarca.TabIndex = 4;
            txtMarca.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.Cyan;
            btnCadastrar.Location = new Point(11, 178);
            btnCadastrar.Margin = new Padding(2, 3, 2, 3);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(97, 28);
            btnCadastrar.TabIndex = 7;
            btnCadastrar.Text = "CADASTRAR";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Red;
            btnVoltar.Location = new Point(480, 178);
            btnVoltar.Margin = new Padding(2, 3, 2, 3);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(97, 28);
            btnVoltar.TabIndex = 8;
            btnVoltar.Text = "VOLTAR";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // dtpEntrada
            // 
            dtpEntrada.CalendarMonthBackground = SystemColors.ActiveCaption;
            dtpEntrada.CustomFormat = "yyyy-MM-dd";
            dtpEntrada.Location = new Point(175, 140);
            dtpEntrada.Margin = new Padding(3, 4, 3, 4);
            dtpEntrada.Name = "dtpEntrada";
            dtpEntrada.Size = new Size(101, 26);
            dtpEntrada.TabIndex = 9;
            dtpEntrada.Value = new DateTime(2024, 11, 23, 0, 0, 0, 0);
            // 
            // dtpVenda
            // 
            dtpVenda.CalendarMonthBackground = SystemColors.ActiveCaption;
            dtpVenda.CustomFormat = "yyyy-MM-dd";
            dtpVenda.Location = new Point(451, 140);
            dtpVenda.Margin = new Padding(3, 4, 3, 4);
            dtpVenda.Name = "dtpVenda";
            dtpVenda.Size = new Size(101, 26);
            dtpVenda.TabIndex = 10;
            dtpVenda.Value = new DateTime(2024, 11, 23, 0, 0, 0, 0);
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GrayText;
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(txtQtdDisponivel);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(cmbLocal);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtMotivoSaida);
            panel1.Controls.Add(txtEntrada);
            panel1.Controls.Add(txtSaida);
            panel1.Controls.Add(txtMotivoEntrada);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(btnVoltar);
            panel1.Controls.Add(dtpVenda);
            panel1.Controls.Add(txtPreco);
            panel1.Controls.Add(dtpEntrada);
            panel1.Controls.Add(txtCategoria);
            panel1.Controls.Add(txtDesc);
            panel1.Controls.Add(txtMarca);
            panel1.Controls.Add(btnCadastrar);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(617, 211);
            panel1.TabIndex = 11;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(362, 144);
            label11.Name = "label11";
            label11.Size = new Size(83, 19);
            label11.TabIndex = 32;
            label11.Text = "Data Venda:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(63, 144);
            label10.Name = "label10";
            label10.Size = new Size(92, 19);
            label10.TabIndex = 31;
            label10.Text = "Data Entrada:";
            // 
            // txtQtdDisponivel
            // 
            txtQtdDisponivel.BackColor = SystemColors.ActiveCaption;
            txtQtdDisponivel.Location = new Point(317, 100);
            txtQtdDisponivel.Margin = new Padding(2, 3, 2, 3);
            txtQtdDisponivel.Multiline = true;
            txtQtdDisponivel.Name = "txtQtdDisponivel";
            txtQtdDisponivel.PlaceholderText = "Qnt Disponivel";
            txtQtdDisponivel.Size = new Size(101, 24);
            txtQtdDisponivel.TabIndex = 30;
            txtQtdDisponivel.TextAlign = HorizontalAlignment.Center;
            txtQtdDisponivel.KeyPress += txtQtdDisponivel_KeyPress;
            txtQtdDisponivel.Leave += txtQtdDisponivel_Leave;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(423, 84);
            label9.Name = "label9";
            label9.Size = new Size(22, 30);
            label9.TabIndex = 26;
            label9.Text = "*";
            // 
            // cmbLocal
            // 
            cmbLocal.BackColor = SystemColors.ActiveCaption;
            cmbLocal.FormattingEnabled = true;
            cmbLocal.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cmbLocal.Location = new Point(176, 97);
            cmbLocal.Name = "cmbLocal";
            cmbLocal.Size = new Size(101, 27);
            cmbLocal.TabIndex = 24;
            cmbLocal.Text = "Localização";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(423, -3);
            label7.Name = "label7";
            label7.Size = new Size(22, 30);
            label7.TabIndex = 23;
            label7.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(282, 84);
            label6.Name = "label6";
            label6.Size = new Size(22, 30);
            label6.TabIndex = 22;
            label6.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(282, 133);
            label5.Name = "label5";
            label5.Size = new Size(22, 30);
            label5.TabIndex = 21;
            label5.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(282, 41);
            label4.Name = "label4";
            label4.Size = new Size(22, 30);
            label4.TabIndex = 20;
            label4.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(282, 0);
            label3.Name = "label3";
            label3.Size = new Size(22, 30);
            label3.TabIndex = 19;
            label3.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(113, 41);
            label2.Name = "label2";
            label2.Size = new Size(22, 30);
            label2.TabIndex = 18;
            label2.Text = "*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(113, 0);
            label1.Name = "label1";
            label1.Size = new Size(22, 30);
            label1.TabIndex = 17;
            label1.Text = "*";
            // 
            // txtMotivoSaida
            // 
            txtMotivoSaida.BackColor = SystemColors.ActiveCaption;
            txtMotivoSaida.Location = new Point(317, 57);
            txtMotivoSaida.Margin = new Padding(2, 3, 2, 3);
            txtMotivoSaida.Multiline = true;
            txtMotivoSaida.Name = "txtMotivoSaida";
            txtMotivoSaida.PlaceholderText = "Motivo Saída";
            txtMotivoSaida.Size = new Size(101, 24);
            txtMotivoSaida.TabIndex = 16;
            txtMotivoSaida.TextAlign = HorizontalAlignment.Center;
            // 
            // txtEntrada
            // 
            txtEntrada.BackColor = SystemColors.ActiveCaption;
            txtEntrada.Location = new Point(476, 13);
            txtEntrada.Margin = new Padding(2, 3, 2, 3);
            txtEntrada.Multiline = true;
            txtEntrada.Name = "txtEntrada";
            txtEntrada.PlaceholderText = "Entrada";
            txtEntrada.Size = new Size(101, 24);
            txtEntrada.TabIndex = 13;
            txtEntrada.TextAlign = HorizontalAlignment.Center;
            txtEntrada.KeyPress += txtEntrada_KeyPress;
            // 
            // txtSaida
            // 
            txtSaida.BackColor = SystemColors.ActiveCaption;
            txtSaida.Location = new Point(476, 57);
            txtSaida.Margin = new Padding(2, 3, 2, 3);
            txtSaida.Multiline = true;
            txtSaida.Name = "txtSaida";
            txtSaida.PlaceholderText = "Saída";
            txtSaida.Size = new Size(101, 24);
            txtSaida.TabIndex = 15;
            txtSaida.TextAlign = HorizontalAlignment.Center;
            txtSaida.KeyPress += txtSaida_KeyPress;
            // 
            // txtMotivoEntrada
            // 
            txtMotivoEntrada.BackColor = SystemColors.ActiveCaption;
            txtMotivoEntrada.Location = new Point(317, 13);
            txtMotivoEntrada.Margin = new Padding(2, 3, 2, 3);
            txtMotivoEntrada.Multiline = true;
            txtMotivoEntrada.Name = "txtMotivoEntrada";
            txtMotivoEntrada.PlaceholderText = "Motivo Entrada";
            txtMotivoEntrada.Size = new Size(101, 26);
            txtMotivoEntrada.TabIndex = 14;
            txtMotivoEntrada.TextAlign = HorizontalAlignment.Center;
            // 
            // SignInProd
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 235);
            Controls.Add(panel1);
            Margin = new Padding(2, 3, 2, 3);
            MaximizeBox = false;
            Name = "SignInProd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Produto";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtPreco;
        private TextBox txtDesc;
        private TextBox txtCategoria;
        private TextBox txtMarca;
        private Button btnCadastrar;
        private Button btnVoltar;
        private DateTimePicker dtpEntrada;
        private DateTimePicker dtpVenda;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtMotivoSaida;
        private TextBox txtLocal;
        private TextBox txtEntrada;
        private TextBox txtSaida;
        private TextBox txtMotivoEntrada;
        private Label label5;
        private Label label7;
        private Label label6;
        private ComboBox cmbLocal;
        private Label label9;
        private TextBox txtQtdDisponivel;
        private Label label11;
        private Label label10;
    }
}