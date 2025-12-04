namespace Projeto.Forms
{
    public partial class FutebolAmericano : BaseForm
    {
        public FutebolAmericano()
        {
            InitializeComponent();
            this.FormClosed += FutebolAmericano_FormClosed;
        }

        private void FutebolAmericano_FormClosed(object? sender, FormClosedEventArgs e)
        {
            var principal = new PaginaPrincipal();
            principal.Show();
        }

        private void FutebolAmericano_Load(object sender, EventArgs e)
        {

            tabela_nfl.DataSource = EsporteService.GetJogadores("futebolamericano");

        }

        private void tabela_nfl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
