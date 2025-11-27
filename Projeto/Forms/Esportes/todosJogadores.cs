namespace Projeto.Forms
{
    public partial class todosJogadores : Form
    {
        public todosJogadores()
        {
            InitializeComponent();
            this.FormClosed += todosJogadores_FormClosed;
        }

        private void todosJogadores_FormClosed(object? sender, FormClosedEventArgs e)
        {
            var principal = new PaginaPrincipal();
            principal.Show();
        }

        private void todosJogadores_Load(object sender, EventArgs e)
        {
            tabela_jogadores.DataSource = EsporteService.GetJogadores("jogadores");
        }
    }
}
