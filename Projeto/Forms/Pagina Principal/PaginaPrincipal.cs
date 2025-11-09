using K4os.Compression.LZ4.Internal;
using Projeto.Forms.Pagina_Configuracoes;

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
            if (!navegando)
                Application.Exit();
        }

        private void menu_cadastro_Click(object sender, EventArgs e)
        {

            navegando = true;
            PaginaCadastro cadastro = new PaginaCadastro();
            this.Close();
            cadastro.ShowDialog();

        }

        private void menu_login_Click(object sender, EventArgs e)
        {

            navegando = true;
            PaginaLogin login = new PaginaLogin();
            login.Show();
            this.Hide();
            this.BeginInvoke(new Action(() => this.Close()));

        }

        private void menu_preferencias_Click(object sender, EventArgs e)
        {

            Preferencias preferencias = new Preferencias(Sessao.UsuarioAtual!);
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
                label_bemvindo.Text = "Bem-vindo ao site";
                Sessao.UsuarioAtual!.Sair();
                menu_sair.Visible = false;
                menu_opcoes.Visible = false;
                menu_cadastro.Visible = true;
                menu_login.Visible = true;
            }
        }

        private void button_teste_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"id = {Sessao.UsuarioAtual?.id}, nome = {Sessao.UsuarioAtual?.nome}, email = {Sessao.UsuarioAtual?.email}");
        }

        private void label_bemvindo_Click(object sender, EventArgs e)
        {

        }

        private void PaginaPrincipal_Resize(object sender, EventArgs e)
        {

            label_bemvindo.Left = (this.ClientSize.Width - label_bemvindo.Width) / 2;
            label_bemvindo.Top = (this.ClientSize.Height - label_bemvindo.Height) / 4;

            button_teste.Left = (this.ClientSize.Width - button_teste.Width) / 2;
            button_teste.Top = (this.ClientSize.Height - button_teste.Width) / 2;

        }

        private void PaginaPrincipal_Load(object sender, EventArgs e)
        {

            label_bemvindo.Left = (this.ClientSize.Width - label_bemvindo.Width) / 2;
            label_bemvindo.Top = (this.ClientSize.Height - label_bemvindo.Height) / 4;

            button_teste.Left = (this.ClientSize.Width - button_teste.Width) / 2;
            button_teste.Top = (this.ClientSize.Height - button_teste.Width) / 2;

            if (Sessao.UsuarioAtual != null)
            {
                menu_sair.Visible = true;
                menu_opcoes.Visible = true;
                menu_cadastro.Visible = false;
                menu_login.Visible = false;
                label_bemvindo.Text = $"Bem-vindo, {Sessao.UsuarioAtual!.nome}";
            }

        }

        private void menu_fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menu_configuracoes_Click(object sender, EventArgs e)
        {
            navegando = true;
            Configuracoes config = new Configuracoes();
            config.Show();
        }
    }
}
