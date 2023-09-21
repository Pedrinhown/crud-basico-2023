namespace crud_basico.View
{
    partial class frmPesquisaCliente
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
            lblNomePesquisa = new Label();
            txtNome = new TextBox();
            btnPesquisar = new Button();
            btnNovoCliente = new Button();
            dgvClientes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // lblNomePesquisa
            // 
            lblNomePesquisa.AutoSize = true;
            lblNomePesquisa.Location = new Point(42, 28);
            lblNomePesquisa.Name = "lblNomePesquisa";
            lblNomePesquisa.Size = new Size(40, 15);
            lblNomePesquisa.TabIndex = 0;
            lblNomePesquisa.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(88, 25);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(247, 23);
            txtNome.TabIndex = 9;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(527, 25);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(75, 23);
            btnPesquisar.TabIndex = 10;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnNovoCliente
            // 
            btnNovoCliente.Location = new Point(446, 25);
            btnNovoCliente.Name = "btnNovoCliente";
            btnNovoCliente.Size = new Size(75, 23);
            btnNovoCliente.TabIndex = 11;
            btnNovoCliente.Text = "Novo";
            btnNovoCliente.UseVisualStyleBackColor = true;
            btnNovoCliente.Click += btnNovoCliente_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(42, 133);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowTemplate.Height = 25;
            dgvClientes.Size = new Size(560, 150);
            dgvClientes.TabIndex = 12;
            dgvClientes.CellDoubleClick += dgvClientes_CellDoubleClick;
            // 
            // frmPesquisaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 304);
            Controls.Add(dgvClientes);
            Controls.Add(btnNovoCliente);
            Controls.Add(btnPesquisar);
            Controls.Add(txtNome);
            Controls.Add(lblNomePesquisa);
            Name = "frmPesquisaCliente";
            Text = "Pesquisa de Cliente";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomePesquisa;
        private TextBox txtNome;
        private Button btnPesquisar;
        private Button btnNovoCliente;
        private DataGridView dgvClientes;
    }
}