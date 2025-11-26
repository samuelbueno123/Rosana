namespace Projeto
{
    public partial class PaginaPrincipal : Form
    {
        private bool navegando = false;

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
            {
                Sessao.UsuarioAtual?.Sair();
                label_bemvindo.Text = "Bem-vindo ao site";
                menu_sair.Visible = false;
                menu_opcoes.Visible = false;
                menu_cadastro.Visible = true;
                menu_login.Visible = true;
            }
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

            if (Properties.Settings.Default.UltimoUsuario != null && Properties.Settings.Default.UltimoUsuario != String.Empty)
            {
                MessageBox.Show($"{Properties.Settings.Default.UltimoUsuario}");
                Conta.Logar(Properties.Settings.Default.UltimoUsuario);
                menu_sair.Visible = true;
                menu_opcoes.Visible = true;
                menu_cadastro.Visible = false;
                menu_login.Visible = false;
                label_bemvindo.Text = $"Bem-vindo, {Sessao.UsuarioAtual?.Nome}";
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

            navegando = true;
            FutebolAmericano futebolAmericano = new();
            futebolAmericano.Show();
            this.Hide();
            this.BeginInvoke(new Action(() => this.Close()));

        }

        private void button_futebol_Click(object sender, EventArgs e)
        {

            navegando = true;
            Futebol futebol = new();
            futebol.Show();
            this.Hide();
            this.BeginInvoke(new Action(() => this.Close()));

        }

        private void button_basquete_Click(object sender, EventArgs e)
        {

            navegando = true;
            Basquete basquete = new();
            basquete.Show();
            this.Hide();
            this.BeginInvoke(new Action(() => this.Close()));

        }
    }
}
