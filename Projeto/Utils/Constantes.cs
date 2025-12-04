namespace Projeto.Utils
{
    public static class Constantes
    {
        // Lista de tabelas/esportes
        public static readonly string[] tabelas = new[]
        {
            "atletismo", "baseball", "basquete",
            "boxe", "cod", "cs",
            "formula1", "futebol", "futebolamericano",
            "golfe", "judo", "natacao",
            "rocket", "valorant", "xadrez"
        };

        // Mapeamento de nome do esporte (chave) para a classe correspondente (valor).
        // Valores são objetos genéricos aqui (strings com o nome da classe) para evitar
        // dependência de tipos que podem não existir no projeto atual.
        public static Dictionary<string, Type> esporteParaClasse = new()
        {
           // { "atletismo", typeof(Forms.Atletismo) },
            { "baseball", typeof(Forms.Baseball) },
            { "basquete", typeof(Forms.Basquete) },
           // { "boxe", typeof(Forms.Boxe) },
           // { "cod", typeof(Forms.Cod) },
           // { "cs", typeof(Forms.CS) },
            //{ "formula1", typeof(Forms.Formula1) },
            { "futebol", typeof(Forms.Futebol) },
            { "futebolamericano", typeof(Forms.FutebolAmericano) },
            // { "golfe", typeof(Forms.Golfe) },
            { "jogadores", typeof(Forms.todosJogadores) },
           // { "judo", typeof(Forms.Judo) },
           // { "natacao", typeof(Forms.Natacao) },
           // { "rocket", typeof(Forms.RocketLeague) },
           // { "valorant", typeof(Forms.Valorant) },
           // { "xadrez", typeof(Forms.Xadrez) }
        };

    }
}
