namespace crud_basico.View
{
    partial class frmProduto
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
            txtValor = new TextBox();
            lblValor = new Label();
            txtDtCadastro = new TextBox();
            lblDataCadastro = new Label();
            txtDescricao = new TextBox();
            lblDescricao = new Label();
            txtId = new TextBox();
            lblId = new Label();
            btnExcluir = new Button();
            btnGravarCliente = new Button();
            SuspendLayout();
            // 
            // txtValor
            // 
            txtValor.Location = new Point(176, 124);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(175, 23);
            txtValor.TabIndex = 22;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(56, 132);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(33, 15);
            lblValor.TabIndex = 21;
            lblValor.Text = "Valor";
            // 
            // txtDtCadastro
            // 
            txtDtCadastro.Location = new Point(176, 95);
            txtDtCadastro.Name = "txtDtCadastro";
            txtDtCadastro.Size = new Size(175, 23);
            txtDtCadastro.TabIndex = 20;
            // 
            // lblDataCadastro
            // 
            lblDataCadastro.AutoSize = true;
            lblDataCadastro.Location = new Point(56, 103);
            lblDataCadastro.Name = "lblDataCadastro";
            lblDataCadastro.Size = new Size(81, 15);
            lblDataCadastro.TabIndex = 19;
            lblDataCadastro.Text = "Data Cadastro";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(176, 65);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(175, 23);
            txtDescricao.TabIndex = 18;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(56, 73);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(58, 15);
            lblDescricao.TabIndex = 17;
            lblDescricao.Text = "Descrição";
            // 
            // txtId
            // 
            txtId.Location = new Point(176, 36);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(175, 23);
            txtId.TabIndex = 16;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(56, 36);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 15;
            lblId.Text = "ID";
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(116, 194);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 24;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnGravarCliente
            // 
            btnGravarCliente.Location = new Point(216, 194);
            btnGravarCliente.Name = "btnGravarCliente";
            btnGravarCliente.Size = new Size(75, 23);
            btnGravarCliente.TabIndex = 23;
            btnGravarCliente.Text = "Gravar";
            btnGravarCliente.UseVisualStyleBackColor = true;
            btnGravarCliente.Click += btnGravarCliente_Click;
            // 
            // frmProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 264);
            Controls.Add(btnExcluir);
            Controls.Add(btnGravarCliente);
            Controls.Add(txtValor);
            Controls.Add(lblValor);
            Controls.Add(txtDtCadastro);
            Controls.Add(lblDataCadastro);
            Controls.Add(txtDescricao);
            Controls.Add(lblDescricao);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Name = "frmProduto";
            Text = "frmProduto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtValor;
        private Label lblValor;
        private TextBox txtDtCadastro;
        private Label lblDataCadastro;
        private TextBox txtDescricao;
        private Label lblDescricao;
        private TextBox txtId;
        private Label lblId;
        private Button btnExcluir;
        private Button btnGravarCliente;
    }
}