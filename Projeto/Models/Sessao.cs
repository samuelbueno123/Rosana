namespace Projeto.Models
{
    public static class Sessao
    {
        public static Usuario? UsuarioAtual {  get; set; }
        public static bool TemaEscuro = Properties.Settings.Default.TemaEscuro;

    }
}