namespace Projeto
{
    partial class PaginaPrincipal
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
            label_bemvindo = new Label();
            menuStrip1 = new MenuStrip();
            menu_conta = new ToolStripMenuItem();
            menu_cadastro = new ToolStripMenuItem();
            menu_login = new ToolStripMenuItem();
            menu_sair = new ToolStripMenuItem();
            menu_opcoes = new ToolStripMenuItem();
            menu_configuracoes = new ToolStripMenuItem();
            menu_preferencias = new ToolStripMenuItem();
            menu_fechar = new ToolStripMenuItem();
            button_teste = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label_bemvindo
            // 
            label_bemvindo.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label_bemvindo.Location = new Point(167, 24);
            label_bemvindo.Name = "label_bemvindo";
            label_bemvindo.Size = new Size(381, 252);
            label_bemvindo.TabIndex = 0;
            label_bemvindo.Text = "Bem-vindo ao site";
            label_bemvindo.Click += label_bemvindo_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menu_conta, menu_opcoes, menu_fechar });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(764, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // menu_conta
            // 
            menu_conta.DropDownItems.AddRange(new ToolStripItem[] { menu_cadastro, menu_login, menu_sair });
            menu_conta.Name = "menu_conta";
            menu_conta.Size = new Size(51, 20);
            menu_conta.Text = "Conta";
            // 
            // menu_cadastro
            // 
            menu_cadastro.Name = "menu_cadastro";
            menu_cadastro.Size = new Size(180, 22);
            menu_cadastro.Text = "Cadastro";
            menu_cadastro.Click += menu_cadastro_Click;
            // 
            // menu_login
            // 
            menu_login.Name = "menu_login";
            menu_login.Size = new Size(180, 22);
            menu_login.Text = "Login";
            menu_login.Click += menu_login_Click;
            // 
            // menu_sair
            // 
            menu_sair.Name = "menu_sair";
            menu_sair.Size = new Size(180, 22);
            menu_sair.Text = "Sair";
            menu_sair.Visible = false;
            menu_sair.Click += menu_sair_Click;
            // 
            // menu_opcoes
            // 
            menu_opcoes.DropDownItems.AddRange(new ToolStripItem[] { menu_configuracoes, menu_preferencias });
            menu_opcoes.Name = "menu_opcoes";
            menu_opcoes.Size = new Size(59, 20);
            menu_opcoes.Text = "Opções";
            menu_opcoes.Visible = false;
            // 
            // menu_configuracoes
            // 
            menu_configuracoes.Name = "menu_configuracoes";
            menu_configuracoes.Size = new Size(180, 22);
            menu_configuracoes.Text = "Configurações";
            menu_configuracoes.Click += menu_configuracoes_Click;
            // 
            // menu_preferencias
            // 
            menu_preferencias.Name = "menu_preferencias";
            menu_preferencias.Size = new Size(180, 22);
            menu_preferencias.Text = "Preferências";
            menu_preferencias.Click += menu_preferencias_Click;
            // 
            // menu_fechar
            // 
            menu_fechar.Name = "menu_fechar";
            menu_fechar.Size = new Size(54, 20);
            menu_fechar.Text = "Fechar";
            menu_fechar.Click += menu_fechar_Click;
            // 
            // button_teste
            // 
            button_teste.Location = new Point(228, 356);
            button_teste.Name = "button_teste";
            button_teste.Size = new Size(171, 55);
            button_teste.TabIndex = 2;
            button_teste.Text = "teste usuario";
            button_teste.UseVisualStyleBackColor = true;
            button_teste.Click += button_teste_Click;
            // 
            // PaginaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 459);
            Controls.Add(button_teste);
            Controls.Add(label_bemvindo);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "PaginaPrincipal";
            Text = "Página Principal";
            Load += PaginaPrincipal_Load;
            Resize += PaginaPrincipal_Resize;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_bemvindo;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menu_conta;
        private ToolStripMenuItem menu_cadastro;
        private ToolStripMenuItem menu_login;
        private ToolStripMenuItem menu_opcoes;
        private ToolStripMenuItem menu_fechar;
        private ToolStripMenuItem menu_sair;
        private ToolStripMenuItem menu_preferencias;
        private Button button_teste;
        private ToolStripMenuItem menu_configuracoes;
    }
}
