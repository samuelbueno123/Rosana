namespace Projeto.Forms
{
    public partial class Esporte : BaseForm
    {
        public string esporte;

        public Esporte(string esporte)
        {
            this.esporte = esporte;
            InitializeComponent();
        }

        private void Esporte_Load(object sender, EventArgs e)
        {
            tabela_stats.DataSource = EsporteService.GetJogadores(esporte);
        }
    }
}
