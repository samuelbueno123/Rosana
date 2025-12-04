namespace Projeto.Forms
{
    public partial class Baseball : BaseForm
    {
        public Baseball()
        {
            InitializeComponent();
            this.FormClosed += Baseball_FormClosed;
        }

        private void Baseball_FormClosed(object? sender, FormClosedEventArgs e)
        {
            var principal = new PaginaPrincipal();
            principal.Show();
        }

        private void Baseball_Load(object sender, EventArgs e)
        {
            tabela_baseball.DataSource = EsporteService.GetJogadores("baseball");
        }
    }
}
