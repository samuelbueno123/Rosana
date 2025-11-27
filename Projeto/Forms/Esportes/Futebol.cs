namespace Projeto.Forms
{
    public partial class Futebol : Form
    {
        public Futebol()
        {
            InitializeComponent();
            this.FormClosed += Futebol_FormClosed;
        }

        private void Futebol_FormClosed(object? sender, FormClosedEventArgs e)
        {
            var principal = new PaginaPrincipal();
            principal.Show();
        }

        private void Futebol_Load(object sender, EventArgs e)
        {
            tabela_futebol.DataSource = EsporteService.GetJogadores("futebol");
        }
    }
}
