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
            data_jogadores = new DataGridView();
            usuarioBindingSource = new BindingSource(components);
            ((ISupportInitialize)data_jogadores).BeginInit();
            ((ISupportInitialize)usuarioBindingSource).BeginInit();
            SuspendLayout();
            // 
            // data_jogadores
            // 
            data_jogadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_jogadores.Location = new Point(180, 29);
            data_jogadores.Name = "data_jogadores";
            data_jogadores.Size = new Size(417, 281);
            data_jogadores.TabIndex = 0;
            // 
            // FutebolAmericano
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(data_jogadores);
            Name = "FutebolAmericano";
            Text = "FutebolAmericano";
            Load += FutebolAmericano_Load;
            ((ISupportInitialize)data_jogadores).EndInit();
            ((ISupportInitialize)usuarioBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView data_jogadores;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn senhaHashDataGridViewTextBoxColumn;
        private BindingSource usuarioBindingSource;
    }
}