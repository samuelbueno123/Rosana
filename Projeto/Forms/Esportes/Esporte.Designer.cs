namespace Projeto.Forms
{
    partial class Esporte
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
            tabela_stats = new DataGridView();
            ((ISupportInitialize)tabela_stats).BeginInit();
            SuspendLayout();
            // 
            // tabela_stats
            // 
            tabela_stats.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabela_stats.Location = new Point(59, 49);
            tabela_stats.Name = "tabela_stats";
            tabela_stats.Size = new Size(686, 244);
            tabela_stats.TabIndex = 0;
            // 
            // Esporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabela_stats);
            Name = "Esporte";
            Text = "Esporte";
            Load += Esporte_Load;
            ((ISupportInitialize)tabela_stats).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tabela_stats;
    }
}