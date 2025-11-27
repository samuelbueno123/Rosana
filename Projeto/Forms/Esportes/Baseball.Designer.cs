namespace Projeto.Forms
{
    partial class Baseball
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
            tabela_baseball = new DataGridView();
            ((ISupportInitialize)tabela_baseball).BeginInit();
            SuspendLayout();
            // 
            // tabela_baseball
            // 
            tabela_baseball.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabela_baseball.Location = new Point(137, 86);
            tabela_baseball.Name = "tabela_baseball";
            tabela_baseball.Size = new Size(527, 229);
            tabela_baseball.TabIndex = 0;
            // 
            // Baseball
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabela_baseball);
            Name = "Baseball";
            Text = "Baseball";
            Load += Baseball_Load;
            ((ISupportInitialize)tabela_baseball).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tabela_baseball;
    }
}