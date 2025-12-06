namespace Projeto
{
    public partial class PaginaPrincipal : BaseForm
    {
        private bool navegando = false;
        private readonly Dictionary<Button, string> botaoParaEsporte = [];

        
        private void Esporte(string esporte)
        {
            navegando = true;

            Esporte esporteForm = new(esporte);
            esporteForm.Show();

            navegando = false;
        }

        private void SemConta()
        {
            
            foreach (var botao in Constantes.ReceberBotoes(this))
            {
                if (botao.Name is not ("button_baseball" or "button_basquete" or "button_futebol"))
                    botao.Visible = false;
            }

            button_basquete.Location = new Point(166, 223);
            button_baseball.Location = new Point(460, 223);

        }

        private void Deslogar()
        {
            Sessao.UsuarioAtual?.Sair();
            label_bemvindo.Text = "Bem-vindo ao site";
            menu_sair.Visible = false;
            menu_opcoes.Visible = false;
            menu_cadastro.Visible = true;
            menu_login.Visible = true;
            SemConta();
        }

        private void Logar()
        {
            menu_sair.Visible = true;
            menu_opcoes.Visible = true;
            menu_cadastro.Visible = false;
            menu_login.Visible = false;
            label_bemvindo.Text = $"Bem-vindo, {Sessao.UsuarioAtual?.Nome}";
        }

        public PaginaPrincipal()
        {
            InitializeComponent();
            this.FormClosed += PaginaPrincipal_FormClosed;

            botaoParaEsporte = new Dictionary<Button, string>
            {
                { button_atletismo, "atletismo" },
                { button_baseball, "baseball" },
                { button_basquete, "basquete" },
                { button_boxe, "boxe" },
                { button_cod, "cod" },
                { button_cs, "cs" },
                { button_futebol, "futebol" },
                { button_futebolAmericano, "futebolAmericano" },
                { button_formula1, "formula1" },
                { button_golfe, "golfe" },
                { button_judo, "judo" },
                { button_natacao, "natacao" },
                { button_rocket, "rocket" },
                { button_valorant, "valorant" },
                { button_xadrez, "xadrez" }
            };
        }


        private void PaginaPrincipal_FormClosed(object? sender, EventArgs e)
        {
            if (!navegando) Application.Exit();
        }

        private void menu_cadastro_Click(object sender, EventArgs e)
        {

            navegando = true;
            PaginaCadastro cadastro = new();
            this.Hide();
            cadastro.ShowDialog();

        }

        private void menu_login_Click(object sender, EventArgs e)
        {

            navegando = true;
            PaginaLogin login = new();
            this.Hide();
            login.ShowDialog();

        }

        private void menu_preferencias_Click(object sender, EventArgs e)
        {

            Preferencias preferencias = new();
            preferencias.ShowDialog();

        }

        private void menu_sair_Click(object sender, EventArgs e)
        {
            DialogResult confirma = MessageBox.Show(
                "Deseja sair da sua conta?",
                "Sair",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (confirma == DialogResult.Yes)
                Deslogar();
        }

        private void PaginaPrincipal_Resize(object sender, EventArgs e)
        {

            label_bemvindo.Left = (this.ClientSize.Width - label_bemvindo.Width) / 2;
            label_bemvindo.Top = (this.ClientSize.Height - label_bemvindo.Height) / 4;

        }

        private void PaginaPrincipal_Load(object sender, EventArgs e)
        {

            label_bemvindo.Left = (this.ClientSize.Width - label_bemvindo.Width) / 2;
            label_bemvindo.Top = (this.ClientSize.Height - label_bemvindo.Height) / 4;

            if (Properties.Settings.Default.UltimoUsuario is not null &&
            Properties.Settings.Default.UltimoUsuario != String.Empty &&
            Conta.Logar(Properties.Settings.Default.UltimoUsuario))
                Logar();
            else
                SemConta();

        }

        private void menu_fechar_Click(object sender, EventArgs e) => Application.Exit();

        private void menu_configuracoes_Click(object sender, EventArgs e)
        {
            Configuracoes config = new();
            config.Show();
        }

        private void button_atletismo_Click(object sender, EventArgs e) => Esporte(botaoParaEsporte[(Button)sender]);

        private void button_basquete_Click(object sender, EventArgs e) => Esporte(botaoParaEsporte[(Button)sender]);

        private void button_boxe_Click(object sender, EventArgs e) => Esporte(botaoParaEsporte[(Button)sender]);

        private void button_baseball_Click(object sender, EventArgs e) => Esporte(botaoParaEsporte[(Button)sender]);

        private void button_cod_Click(object sender, EventArgs e) => Esporte(botaoParaEsporte[(Button)sender]);

        private void button_cs_Click(object sender, EventArgs e) => Esporte(botaoParaEsporte[(Button)sender]);

        private void button_formula1_Click(object sender, EventArgs e) => Esporte(botaoParaEsporte[(Button)sender]);

        private void button_futebol_Click(object sender, EventArgs e) => Esporte(botaoParaEsporte[(Button)sender]);

        private void button_futebolAmericano_Click(object sender, EventArgs e) => Esporte(botaoParaEsporte[(Button)sender]);

        private void button_golf_Click(object sender, EventArgs e) => Esporte(botaoParaEsporte[(Button)sender]);

        private void button_judo_Click(object sender, EventArgs e) => Esporte(botaoParaEsporte[(Button)sender]);

        private void button_natacao_Click(object sender, EventArgs e) => Esporte(botaoParaEsporte[(Button)sender]);

        private void button_rocket_Click(object sender, EventArgs e) => Esporte(botaoParaEsporte[(Button)sender]);

        private void button_todosJogadores_Click(object sender, EventArgs e) => Esporte(botaoParaEsporte[(Button)sender]);

        private void button_valorant_Click(object sender, EventArgs e) => Esporte(botaoParaEsporte[(Button)sender]);

        private void button_xadrez_Click(object sender, EventArgs e) => Esporte(botaoParaEsporte[(Button)sender]);
    }
}
