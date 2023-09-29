namespace crud_basico.View
{
    partial class frmPesquisaProduto
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
            btnNovoProduto = new Button();
            btnPesquisarProduto = new Button();
            dgvProdutos = new DataGridView();
            txtNome = new TextBox();
            lblDescricaoPesquisa = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // btnNovoProduto
            // 
            btnNovoProduto.Location = new Point(392, 33);
            btnNovoProduto.Name = "btnNovoProduto";
            btnNovoProduto.Size = new Size(75, 23);
            btnNovoProduto.TabIndex = 13;
            btnNovoProduto.Text = "Novo";
            btnNovoProduto.UseVisualStyleBackColor = true;
            btnNovoProduto.Click += btnNovoProduto_Click;
            // 
            // btnPesquisarProduto
            // 
            btnPesquisarProduto.Location = new Point(473, 33);
            btnPesquisarProduto.Name = "btnPesquisarProduto";
            btnPesquisarProduto.Size = new Size(75, 23);
            btnPesquisarProduto.TabIndex = 12;
            btnPesquisarProduto.Text = "Pesquisar";
            btnPesquisarProduto.UseVisualStyleBackColor = true;
            btnPesquisarProduto.Click += btnPesquisarProduto_Click;
            // 
            // dgvProdutos
            // 
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Location = new Point(3, 67);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.RowTemplate.Height = 25;
            dgvProdutos.Size = new Size(560, 150);
            dgvProdutos.TabIndex = 14;
            dgvProdutos.CellDoubleClick += dgvProdutos_CellDoubleClick;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(96, 34);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(247, 23);
            txtNome.TabIndex = 16;
            // 
            // lblDescricaoPesquisa
            // 
            lblDescricaoPesquisa.AutoSize = true;
            lblDescricaoPesquisa.Location = new Point(8, 37);
            lblDescricaoPesquisa.Name = "lblDescricaoPesquisa";
            lblDescricaoPesquisa.Size = new Size(58, 15);
            lblDescricaoPesquisa.TabIndex = 15;
            lblDescricaoPesquisa.Text = "Descrição";
            // 
            // frmPesquisaProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 284);
            Controls.Add(txtNome);
            Controls.Add(lblDescricaoPesquisa);
            Controls.Add(dgvProdutos);
            Controls.Add(btnNovoProduto);
            Controls.Add(btnPesquisarProduto);
            Name = "frmPesquisaProduto";
            Text = "frmPesquisaProduto";
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNovoProduto;
        private Button btnPesquisarProduto;
        private DataGridView dgvProdutos;
        private TextBox txtNome;
        private Label lblDescricaoPesquisa;
    }
}