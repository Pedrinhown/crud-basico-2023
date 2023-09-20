namespace crud_basico.View
{
    partial class frmCliente
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
            txtCep = new TextBox();
            btnGravarCliente = new Button();
            lblId = new Label();
            txtId = new TextBox();
            lblNome = new Label();
            lblCep = new Label();
            txtNome = new TextBox();
            txtCpf = new TextBox();
            lblCpf = new Label();
            txtDtNascimento = new TextBox();
            lblDtNascimento = new Label();
            txtAltura = new TextBox();
            lblAltura = new Label();
            txtIdadePessoa = new TextBox();
            txtIdade = new Label();
            lblEndereco = new Label();
            txtEndereco = new TextBox();
            numEndereco = new Label();
            txtNumEnd = new TextBox();
            btnBuscaEndereco = new Button();
            SuspendLayout();
            // 
            // txtCep
            // 
            txtCep.Location = new Point(188, 242);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(175, 23);
            txtCep.TabIndex = 3;
            // 
            // btnGravarCliente
            // 
            btnGravarCliente.Location = new Point(288, 348);
            btnGravarCliente.Name = "btnGravarCliente";
            btnGravarCliente.Size = new Size(75, 23);
            btnGravarCliente.TabIndex = 2;
            btnGravarCliente.Text = "Gravar";
            btnGravarCliente.UseVisualStyleBackColor = true;
            btnGravarCliente.Click += btnGravarCliente_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(68, 68);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 4;
            lblId.Text = "ID";
            // 
            // txtId
            // 
            txtId.Location = new Point(188, 68);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(175, 23);
            txtId.TabIndex = 5;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(68, 105);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 6;
            lblNome.Text = "Nome";
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Location = new Point(68, 250);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(28, 15);
            lblCep.TabIndex = 7;
            lblCep.Text = "CEP";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(188, 97);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(175, 23);
            txtNome.TabIndex = 8;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(188, 126);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(175, 23);
            txtCpf.TabIndex = 10;
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(68, 134);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(28, 15);
            lblCpf.TabIndex = 9;
            lblCpf.Text = "CPF";
            // 
            // txtDtNascimento
            // 
            txtDtNascimento.Location = new Point(188, 155);
            txtDtNascimento.Name = "txtDtNascimento";
            txtDtNascimento.Size = new Size(175, 23);
            txtDtNascimento.TabIndex = 12;
            // 
            // lblDtNascimento
            // 
            lblDtNascimento.AutoSize = true;
            lblDtNascimento.Location = new Point(68, 163);
            lblDtNascimento.Name = "lblDtNascimento";
            lblDtNascimento.Size = new Size(114, 15);
            lblDtNascimento.TabIndex = 11;
            lblDtNascimento.Text = "Data de Nascimento";
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(188, 184);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(175, 23);
            txtAltura.TabIndex = 14;
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Location = new Point(68, 192);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(39, 15);
            lblAltura.TabIndex = 13;
            lblAltura.Text = "Altura";
            // 
            // txtIdadePessoa
            // 
            txtIdadePessoa.Location = new Point(188, 213);
            txtIdadePessoa.Name = "txtIdadePessoa";
            txtIdadePessoa.Size = new Size(175, 23);
            txtIdadePessoa.TabIndex = 16;
            // 
            // txtIdade
            // 
            txtIdade.AutoSize = true;
            txtIdade.Location = new Point(68, 221);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(36, 15);
            txtIdade.TabIndex = 15;
            txtIdade.Text = "Idade";
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Location = new Point(68, 279);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(56, 15);
            lblEndereco.TabIndex = 18;
            lblEndereco.Text = "Endereço";
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(188, 271);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.ReadOnly = true;
            txtEndereco.Size = new Size(175, 23);
            txtEndereco.TabIndex = 17;
            // 
            // numEndereco
            // 
            numEndereco.AutoSize = true;
            numEndereco.Location = new Point(68, 308);
            numEndereco.Name = "numEndereco";
            numEndereco.Size = new Size(21, 15);
            numEndereco.TabIndex = 20;
            numEndereco.Text = "Nº";
            // 
            // txtNumEnd
            // 
            txtNumEnd.Location = new Point(188, 300);
            txtNumEnd.Name = "txtNumEnd";
            txtNumEnd.Size = new Size(175, 23);
            txtNumEnd.TabIndex = 19;
            // 
            // btnBuscaEndereco
            // 
            btnBuscaEndereco.Location = new Point(369, 242);
            btnBuscaEndereco.Name = "btnBuscaEndereco";
            btnBuscaEndereco.Size = new Size(75, 23);
            btnBuscaEndereco.TabIndex = 21;
            btnBuscaEndereco.Text = "CEP";
            btnBuscaEndereco.UseVisualStyleBackColor = true;
            btnBuscaEndereco.Click += btnBuscaEndereco_Click;
            // 
            // frmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 409);
            Controls.Add(btnBuscaEndereco);
            Controls.Add(numEndereco);
            Controls.Add(txtNumEnd);
            Controls.Add(lblEndereco);
            Controls.Add(txtEndereco);
            Controls.Add(txtIdadePessoa);
            Controls.Add(txtIdade);
            Controls.Add(txtAltura);
            Controls.Add(lblAltura);
            Controls.Add(txtDtNascimento);
            Controls.Add(lblDtNascimento);
            Controls.Add(txtCpf);
            Controls.Add(lblCpf);
            Controls.Add(txtNome);
            Controls.Add(lblCep);
            Controls.Add(lblNome);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(txtCep);
            Controls.Add(btnGravarCliente);
            Name = "frmCliente";
            Text = "frmCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCep;
        private Button btnGravarCliente;
        private Label lblId;
        private TextBox txtId;
        private Label lblNome;
        private Label lblCep;
        private TextBox txtNome;
        private TextBox txtCpf;
        private Label lblCpf;
        private TextBox txtDtNascimento;
        private Label lblDtNascimento;
        private TextBox txtAltura;
        private Label lblAltura;
        private TextBox txtIdadePessoa;
        private Label txtIdade;
        private Label lblEndereco;
        private TextBox txtEndereco;
        private Label numEndereco;
        private TextBox txtNumEnd;
        private Button btnBuscaEndereco;
    }
}