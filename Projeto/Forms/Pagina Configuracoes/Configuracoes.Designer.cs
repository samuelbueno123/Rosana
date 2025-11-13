namespace Projeto.Forms.Pagina_Configuracoes
{
    partial class Configuracoes
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
            group_design = new GroupBox();
            group_conta = new GroupBox();
            button_excluirconta = new Button();
            button_consultar = new Button();
            button_mudarsenha = new Button();
            label_tema = new Label();
            combo_tema = new ComboBox();
            group_design.SuspendLayout();
            group_conta.SuspendLayout();
            SuspendLayout();
            // 
            // group_design
            // 
            group_design.Controls.Add(combo_tema);
            group_design.Controls.Add(label_tema);
            group_design.Location = new Point(85, 80);
            group_design.Name = "group_design";
            group_design.Size = new Size(197, 249);
            group_design.TabIndex = 0;
            group_design.TabStop = false;
            group_design.Text = "Design";
            // 
            // group_conta
            // 
            group_conta.Controls.Add(button_excluirconta);
            group_conta.Controls.Add(button_consultar);
            group_conta.Controls.Add(button_mudarsenha);
            group_conta.Location = new Point(498, 80);
            group_conta.Name = "group_conta";
            group_conta.Size = new Size(197, 249);
            group_conta.TabIndex = 1;
            group_conta.TabStop = false;
            group_conta.Text = "Conta";
            // 
            // button_excluirconta
            // 
            button_excluirconta.Location = new Point(36, 171);
            button_excluirconta.Name = "button_excluirconta";
            button_excluirconta.Size = new Size(130, 27);
            button_excluirconta.TabIndex = 2;
            button_excluirconta.Text = "Excluir conta";
            button_excluirconta.UseVisualStyleBackColor = true;
            button_excluirconta.Click += button_excluirconta_Click;
            // 
            // button_consultar
            // 
            button_consultar.Location = new Point(36, 50);
            button_consultar.Name = "button_consultar";
            button_consultar.Size = new Size(130, 27);
            button_consultar.TabIndex = 1;
            button_consultar.Text = "Consultar dados";
            button_consultar.UseVisualStyleBackColor = true;
            button_consultar.Click += button_consultar_Click;
            // 
            // button_mudarsenha
            // 
            button_mudarsenha.Location = new Point(36, 109);
            button_mudarsenha.Name = "button_mudarsenha";
            button_mudarsenha.Size = new Size(130, 27);
            button_mudarsenha.TabIndex = 0;
            button_mudarsenha.Text = "Alterar senha";
            button_mudarsenha.UseVisualStyleBackColor = true;
            button_mudarsenha.Click += button_mudarsenha_Click;
            // 
            // label_tema
            // 
            label_tema.AutoSize = true;
            label_tema.Location = new Point(38, 38);
            label_tema.Name = "label_tema";
            label_tema.Size = new Size(38, 15);
            label_tema.TabIndex = 0;
            label_tema.Text = "Tema:";
            // 
            // combo_tema
            // 
            combo_tema.FormattingEnabled = true;
            combo_tema.Items.AddRange(new object[] { "Claro", "Escuro" });
            combo_tema.Location = new Point(38, 56);
            combo_tema.Name = "combo_tema";
            combo_tema.Size = new Size(119, 23);
            combo_tema.TabIndex = 1;
            combo_tema.SelectedIndexChanged += combo_tema_SelectedIndexChanged;
            // 
            // Configuracoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(group_conta);
            Controls.Add(group_design);
            Name = "Configuracoes";
            Text = "Configuracoes";
            group_design.ResumeLayout(false);
            group_design.PerformLayout();
            group_conta.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox group_design;
        private GroupBox group_conta;
        private Button button_excluirconta;
        private Button button_consultar;
        private Button button_mudarsenha;
        private ComboBox combo_tema;
        private Label label_tema;
    }
}