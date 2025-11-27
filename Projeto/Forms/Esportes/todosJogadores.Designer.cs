namespace Projeto.Forms
{
    partial class todosJogadores
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
            tabela_jogadores = new DataGridView();
            ((ISupportInitialize)tabela_jogadores).BeginInit();
            SuspendLayout();
            // 
            // tabela_jogadores
            // 
            tabela_jogadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabela_jogadores.Location = new Point(90, 8);
            tabela_jogadores.Name = "tabela_jogadores";
            tabela_jogadores.Size = new Size(664, 436);
            tabela_jogadores.TabIndex = 0;
            // 
            // todosJogadores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabela_jogadores);
            Name = "todosJogadores";
            Text = "todosJogadores";
            Load += todosJogadores_Load;
            ((ISupportInitialize)tabela_jogadores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tabela_jogadores;
    }
}