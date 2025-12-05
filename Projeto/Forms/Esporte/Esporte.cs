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
            foreach (string jogador in EsporteService.GetJogadores(esporte))
            {
                Button botao = new Button
                {
                    Text = jogador,
                    Width = 200,
                    Height = 50,
                    Margin = new Padding(10)
                };
            }
            panel_foto1.BackgroundImage = Constantes.Imagens[esporte];
            panel_foto1.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void panel_foto_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ((Panel)sender).ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }
    }
}
