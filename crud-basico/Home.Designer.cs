namespace crud_basico
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
            btnCliente = new Button();
            btnAcaoDoBotao = new Button();
            txtTexto = new TextBox();
            lblTexto = new Label();
            SuspendLayout();
            // 
            // btnCliente
            // 
            btnCliente.Location = new Point(134, 36);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(75, 23);
            btnCliente.TabIndex = 0;
            btnCliente.Text = "Cliente";
            btnCliente.UseVisualStyleBackColor = true;
            btnCliente.Click += btnCliente_Click;
            // 
            // btnAcaoDoBotao
            // 
            btnAcaoDoBotao.Location = new Point(134, 77);
            btnAcaoDoBotao.Name = "btnAcaoDoBotao";
            btnAcaoDoBotao.Size = new Size(75, 23);
            btnAcaoDoBotao.TabIndex = 1;
            btnAcaoDoBotao.Text = "Texto";
            btnAcaoDoBotao.UseVisualStyleBackColor = true;
            // 
            // txtTexto
            // 
            txtTexto.Location = new Point(122, 106);
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(100, 23);
            txtTexto.TabIndex = 2;
            // 
            // lblTexto
            // 
            lblTexto.AutoSize = true;
            lblTexto.Location = new Point(81, 109);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(35, 15);
            lblTexto.TabIndex = 3;
            lblTexto.Text = "Texto";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 133);
            Controls.Add(lblTexto);
            Controls.Add(txtTexto);
            Controls.Add(btnAcaoDoBotao);
            Controls.Add(btnCliente);
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCliente;
        private Button btnAcaoDoBotao;
        private TextBox txtTexto;
        private Label lblTexto;
    }
}