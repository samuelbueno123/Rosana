namespace Projeto.Forms
{
    partial class Futebol
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
            tabela_futebol = new DataGridView();
            ((ISupportInitialize)tabela_futebol).BeginInit();
            SuspendLayout();
            // 
            // tabela_futebol
            // 
            tabela_futebol.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabela_futebol.Location = new Point(181, 77);
            tabela_futebol.Name = "tabela_futebol";
            tabela_futebol.Size = new Size(440, 243);
            tabela_futebol.TabIndex = 0;
            // 
            // Futebol
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabela_futebol);
            Name = "Futebol";
            Text = "Futebol";
            Load += Futebol_Load;
            ((ISupportInitialize)tabela_futebol).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tabela_futebol;
    }
}