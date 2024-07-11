namespace Projeto2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            cbPrioridade = new ComboBox();
            txtAssunto = new TextBox();
            txtInformacoes = new RichTextBox();
            txtNome = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            cbCategoria = new ComboBox();
            label6 = new Label();
            dgvDados = new DataGridView();
            label7 = new Label();
            btnGravar = new Button();
            btnDeletar = new Button();
            btnLimpar = new Button();
            btnAtualizar = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDados).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 218);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Assunto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 31);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 1;
            label2.Text = "Requisitante";
            // 
            // cbPrioridade
            // 
            cbPrioridade.FormattingEnabled = true;
            cbPrioridade.Items.AddRange(new object[] { "Baixa (10-15 Dias)", "Moderada (5-10 Dias)", "Alta (2-4 Dias)", "Urgente (24 Horas)" });
            cbPrioridade.Location = new Point(42, 188);
            cbPrioridade.Name = "cbPrioridade";
            cbPrioridade.Size = new Size(208, 23);
            cbPrioridade.TabIndex = 2;
            // 
            // txtAssunto
            // 
            txtAssunto.Location = new Point(41, 236);
            txtAssunto.Name = "txtAssunto";
            txtAssunto.Size = new Size(209, 23);
            txtAssunto.TabIndex = 3;
            // 
            // txtInformacoes
            // 
            txtInformacoes.Location = new Point(41, 280);
            txtInformacoes.Name = "txtInformacoes";
            txtInformacoes.Size = new Size(209, 104);
            txtInformacoes.TabIndex = 4;
            txtInformacoes.Text = "";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(42, 49);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(208, 23);
            txtNome.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 170);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 6;
            label4.Text = "Prioridade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 81);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 7;
            label3.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(42, 99);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(208, 23);
            txtEmail.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 125);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 9;
            label5.Text = "Categoria";
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Items.AddRange(new object[] { "Suprimentos", "Banco de dados", "Servidor", "Redes", "Software", "Hardware", "Vírus", "Segurança", "Suporte Técnico em Geral" });
            cbCategoria.Location = new Point(42, 143);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(208, 23);
            cbCategoria.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 262);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 11;
            label6.Text = "Informações";
            // 
            // dgvDados
            // 
            dgvDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDados.Location = new Point(271, 19);
            dgvDados.Name = "dgvDados";
            dgvDados.RowTemplate.Height = 25;
            dgvDados.Size = new Size(569, 365);
            dgvDados.TabIndex = 12;
            dgvDados.CellContentClick += dgvDados_CellContentClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 411);
            label7.Name = "label7";
            label7.Size = new Size(239, 30);
            label7.TabIndex = 13;
            label7.Text = "Quanto mais específico seu pedido for,\r\nmais nossos funcionários poderão te ajudar.";
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(64, 385);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 23);
            btnGravar.TabIndex = 14;
            btnGravar.Text = "Enviar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btn_Gravar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(446, 390);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(75, 23);
            btnDeletar.TabIndex = 15;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(145, 385);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 16;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(527, 390);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 23);
            btnAtualizar.TabIndex = 17;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // button5
            // 
            button5.Location = new Point(608, 390);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 18;
            button5.Text = "Fechar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += btnFechar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 450);
            Controls.Add(button5);
            Controls.Add(btnAtualizar);
            Controls.Add(btnLimpar);
            Controls.Add(btnDeletar);
            Controls.Add(btnGravar);
            Controls.Add(label7);
            Controls.Add(dgvDados);
            Controls.Add(label6);
            Controls.Add(cbCategoria);
            Controls.Add(label5);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txtNome);
            Controls.Add(txtInformacoes);
            Controls.Add(txtAssunto);
            Controls.Add(cbPrioridade);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Cadastro de Chamado";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label1;
        private Label label2;
        private ComboBox cbPrioridade;
        private TextBox txtAssunto;
        private RichTextBox txtInformacoes;
        private TextBox txtNome;
        private Label label4;
        private TextBox txtEmail;
        private Label label5;
        private ComboBox cbCategoria;
        private Label label6;
        private DataGridView dgvDados;
        private Label label7;
        private Button btnGravar;
        private Button btnDeletar;
        private Button btnLimpar;
        private Button btnAtualizar;
        private Button button5;
    }
}