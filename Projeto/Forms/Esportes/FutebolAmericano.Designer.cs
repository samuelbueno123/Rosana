namespace Projeto.Forms
{
    partial class FutebolAmericano
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
            components = new Container();
            tabela_nfl = new DataGridView();
            usuarioBindingSource = new BindingSource(components);
            ((ISupportInitialize)tabela_nfl).BeginInit();
            ((ISupportInitialize)usuarioBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tabela_nfl
            // 
            tabela_nfl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabela_nfl.Location = new Point(180, 29);
            tabela_nfl.Name = "tabela_nfl";
            tabela_nfl.Size = new Size(417, 281);
            tabela_nfl.TabIndex = 0;
            // 
            // FutebolAmericano
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabela_nfl);
            Name = "FutebolAmericano";
            Text = "FutebolAmericano";
            Load += FutebolAmericano_Load;
            ((ISupportInitialize)tabela_nfl).EndInit();
            ((ISupportInitialize)usuarioBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tabela_nfl;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn senhaHashDataGridViewTextBoxColumn;
        private BindingSource usuarioBindingSource;
    }
}