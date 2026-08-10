namespace Projeto.Forms.Pagina_Configuracoes
{
    public partial class Configuracoes : Form
    {
        public Configuracoes()
        {
            InitializeComponent();
        }

        private void button_consultar_Click(object sender, EventArgs e)
        {
            DialogResult aviso = MessageBox.Show(
                "Cuidado, informações pessoais de sua conta a seguir. \nDeseja continuar?",
                "Aviso",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (aviso == DialogResult.Yes)
            {
                MessageBox.Show(
                    $"Id de conta: {Sessao.UsuarioAtual!.Id} \n" +
                    $"Nome de usuário: {Sessao.UsuarioAtual!.Nome} \n" +
                    $"Email: {Sessao.UsuarioAtual.Email}",
                    "Informações",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            }
        }

        private void button_mudarsenha_Click(object sender, EventArgs e)
        {
            using Senha senha = new();
            senha.ShowDialog();
        }

        private void button_excluirconta_Click(object sender, EventArgs e)
        {
            using ExcluiUsuario excluiUsuario = new();
            excluiUsuario.ShowDialog();
        }

        private void combo_tema_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_tema.SelectedIndex == 0)
            {
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;
                Properties.Settings.Default.TemaEscuro = false;
                Properties.Settings.Default.Save();
            }
            else if (combo_tema.SelectedIndex == 1)
            {
                this.BackColor = Color.Black;
                this.ForeColor = Color.White;
                Properties.Settings.Default.TemaEscuro = true;
                Properties.Settings.Default.Save();
            }
        }
    }
}
