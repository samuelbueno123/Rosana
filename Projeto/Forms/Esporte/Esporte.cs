using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Projeto.Forms
{
    public partial class Esporte : BaseForm
    {
        private readonly string _esporte;
        private readonly List<Image> _ownedImages = [];

        public Esporte(string esporte)
        {
            _esporte = esporte;
            InitializeComponent();
            this.Load += Esporte_Load;
        }

        private void Esporte_Load(object? sender, EventArgs e)
        {
            var panels = AllControls(this)
                .OfType<Panel>()
                .Where(p => p.Name.StartsWith("panel_foto", StringComparison.OrdinalIgnoreCase))
                .OrderBy(p => p.Name)
                .Take(5)
                .ToList();

            string[]? nomes = EsporteService.GetJogadores(_esporte)?.ToArray();
            if (nomes == null || nomes.Length == 0)
            {
                this.Visible = true;
                return;
            }

            for (int i = 0; i < panels.Count && i < nomes.Length; i++)
            {
                var key = EsporteService.GetImages(nomes[i]);
                if (String.IsNullOrEmpty(key)) continue;

                var path = Constantes.GetPath(key);

                if (path == null) continue;

                // create a resized bitmap to the panel current size
                var bmp = ImageService.LoadResizedBitmap(path, panels[i].Size);
                if (bmp == null) continue;

                // assign and keep ownership so we can dispose later
                panels[i].BackgroundImage = bmp;
                panels[i].BackgroundImageLayout = ImageLayout.Stretch;
                panels[i].Dock = DockStyle.Fill;
                _ownedImages.Add(bmp);
            }
        }

        private static IEnumerable<Control> AllControls(Control root)
        {
            foreach (Control child in root.Controls)
            {
                yield return child;
                foreach (var desc in AllControls(child)) yield return desc;
            }
        }

        private void panel_foto1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ((Panel)sender).ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }
    }
}
