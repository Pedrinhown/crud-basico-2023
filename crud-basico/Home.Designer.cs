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
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 133);
            Controls.Add(btnCliente);
            Name = "Home";
            Text = "Home";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCliente;
    }
}