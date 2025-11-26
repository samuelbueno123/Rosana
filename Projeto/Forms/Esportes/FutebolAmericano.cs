namespace Projeto.Forms
{
    public partial class FutebolAmericano : Form
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

            data_jogadores.DataSource = EsporteService.GetJogadores("futebol americano");

        }
    }
}
