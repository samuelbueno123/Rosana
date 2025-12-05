namespace Projeto.Forms
{
    public partial class BaseForm : Form
    {

        public BaseForm()
        {
            this.KeyPreview = true;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true; // mark handled
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}
