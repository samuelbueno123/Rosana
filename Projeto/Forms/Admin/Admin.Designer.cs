namespace Projeto.Forms
{
    partial class Admin
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
            tabela_usuarios = new DataGridView();
            label_usuarios = new Label();
            ((ISupportInitialize)tabela_usuarios).BeginInit();
            SuspendLayout();
            // 
            // tabela_usuarios
            // 
            tabela_usuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabela_usuarios.Location = new Point(12, 30);
            tabela_usuarios.Name = "tabela_usuarios";
            tabela_usuarios.Size = new Size(577, 304);
            tabela_usuarios.TabIndex = 0;
            // 
            // label_usuarios
            // 
            label_usuarios.AutoSize = true;
            label_usuarios.Location = new Point(137, 12);
            label_usuarios.Name = "label_usuarios";
            label_usuarios.Size = new Size(94, 15);
            label_usuarios.TabIndex = 1;
            label_usuarios.Text = "Lista de usuários";
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label_usuarios);
            Controls.Add(tabela_usuarios);
            DoubleBuffered = true;
            Name = "Admin";
            Text = "Admin";
            Load += Admin_Load;
            ((ISupportInitialize)tabela_usuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tabela_usuarios;
        private Label label_usuarios;
    }
}