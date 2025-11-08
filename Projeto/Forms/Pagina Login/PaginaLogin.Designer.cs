namespace Projeto
{
    partial class PaginaLogin
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
            label1 = new Label();
            label_emailusuario = new Label();
            label_senha = new Label();
            TxtEmailUsuario = new TextBox();
            TxtSenha = new TextBox();
            button_login = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(212, 52);
            label1.Name = "label1";
            label1.Size = new Size(320, 47);
            label1.TabIndex = 0;
            label1.Text = "Fazer login no site";
            // 
            // label_emailusuario
            // 
            label_emailusuario.AutoSize = true;
            label_emailusuario.Location = new Point(148, 166);
            label_emailusuario.Name = "label_emailusuario";
            label_emailusuario.Size = new Size(200, 15);
            label_emailusuario.TabIndex = 1;
            label_emailusuario.Text = "Insira seu email ou nome de usuário:";
            // 
            // label_senha
            // 
            label_senha.AutoSize = true;
            label_senha.Location = new Point(255, 206);
            label_senha.Name = "label_senha";
            label_senha.Size = new Size(93, 15);
            label_senha.TabIndex = 2;
            label_senha.Text = "Insira sua senha:";
            // 
            // TxtEmailUsuario
            // 
            TxtEmailUsuario.Location = new Point(354, 163);
            TxtEmailUsuario.Name = "TxtEmailUsuario";
            TxtEmailUsuario.Size = new Size(131, 23);
            TxtEmailUsuario.TabIndex = 3;
            // 
            // TxtSenha
            // 
            TxtSenha.Location = new Point(354, 203);
            TxtSenha.Name = "TxtSenha";
            TxtSenha.Size = new Size(131, 23);
            TxtSenha.TabIndex = 4;
            TxtSenha.UseSystemPasswordChar = true;
            // 
            // button_login
            // 
            button_login.Location = new Point(380, 257);
            button_login.Name = "button_login";
            button_login.Size = new Size(75, 23);
            button_login.TabIndex = 5;
            button_login.Text = "Login";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // PaginaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_login);
            Controls.Add(TxtSenha);
            Controls.Add(TxtEmailUsuario);
            Controls.Add(label_senha);
            Controls.Add(label_emailusuario);
            Controls.Add(label1);
            Name = "PaginaLogin";
            Text = "PaginaLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label_emailusuario;
        private Label label_senha;
        private TextBox TxtEmailUsuario;
        private TextBox TxtSenha;
        private Button button_login;
    }
}