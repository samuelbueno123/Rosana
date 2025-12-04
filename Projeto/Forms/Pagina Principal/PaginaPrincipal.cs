namespace Projeto
{
    public partial class PaginaPrincipal : BaseForm
    {
        private bool navegando = false;
        private string? esporte;

        private void Esporte(string esporte)
        {
            navegando = true;

            // pega o type da classe a partir do dicionário
            Type t = Constantes.esporteParaClasse[esporte.ToLower()];

            // instancia a classe dinamicamente
            Form pagina = (Form)Activator.CreateInstance(t)!;

            pagina.Show();

            this.Hide();
            this.BeginInvoke(new Action(() => this.Close()));
        }

        private void Deslogar()
        {
            Sessao.UsuarioAtual?.Sair();
            label_bemvindo.Text = "Bem-vindo ao site";
            menu_sair.Visible = false;
            menu_opcoes.Visible = false;
            menu_cadastro.Visible = true;
            menu_login.Visible = true;
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
        }

        private void PaginaPrincipal_FormClosed(object? sender, EventArgs e)
        {
            if (!navegando) Application.Exit();
        }

        private void menu_cadastro_Click(object sender, EventArgs e)
        {

            navegando = true;
            PaginaCadastro cadastro = new();
            cadastro.Show();
            this.Hide();
            this.BeginInvoke(new Action(() => this.Close()));

        }

        private void menu_login_Click(object sender, EventArgs e)
        {

            navegando = true;
            PaginaLogin login = new();
            login.Show();
            this.Hide();
            this.BeginInvoke(new Action(() => this.Close()));

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

        private void label_bemvindo_Click(object sender, EventArgs e)
        {

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

            if (Properties.Settings.Default.UltimoUsuario is not null && Properties.Settings.Default.UltimoUsuario != String.Empty)
            {
                if (Conta.Logar(Properties.Settings.Default.UltimoUsuario))
                    Logar();
            }

        }

        private void menu_fechar_Click(object sender, EventArgs e) => Application.Exit();

        private void menu_configuracoes_Click(object sender, EventArgs e)
        {
            Configuracoes config = new();
            config.Show();
        }

        private void button_futebolAmericano_Click(object sender, EventArgs e)
        {
            esporte = "futebolAmericano";
            Esporte(esporte);

        }

        private void button_futebol_Click(object sender, EventArgs e)
        {
            esporte = "futebol";
            Esporte(esporte);
        }

        private void button_basquete_Click(object sender, EventArgs e)
        {
            esporte = "basquete";
            Esporte(esporte);
        }

        private void button_todosJogadores_Click(object sender, EventArgs e)
        {
            esporte = "jogadores";
            Esporte(esporte);
        }

        private void button_baseball_Click(object sender, EventArgs e)
        {
            esporte = "baseball";
            Esporte(esporte);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{Constantes.Imagens["profile"]}");
            button1.Image = Constantes.Imagens["sport_stats"];
        }
    }
}
