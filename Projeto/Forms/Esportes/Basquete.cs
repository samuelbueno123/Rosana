namespace Projeto.Forms
{
    public partial class Basquete : Form
    {
        public Basquete()
        {
            InitializeComponent();
            this.FormClosed += Basquete_FormClosed;
        }

        private void Basquete_FormClosed(object? sender, FormClosedEventArgs e)
        {
            var principal = new PaginaPrincipal();
            principal.Show();
        }
    }
}
