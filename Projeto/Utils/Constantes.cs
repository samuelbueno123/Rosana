using Microsoft.VisualBasic.Logging;

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

        public static readonly Dictionary<string, Image> Imagens = LoadImagens();

        private static Dictionary<string, Image> LoadImagens()
        {
            var validExtensions = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            { ".jpg", ".jpeg", ".png", ".bmp", ".gif" };

            var directories = new[]
            {
            Path.Combine(Application.StartupPath, "Assets", "fotos"),
            Path.Combine(Application.StartupPath, "Assets", "fotos", "esportes"),
            Path.Combine(Application.StartupPath, "Assets", "fotos", "devs")
            };

            var Imagens = new Dictionary<string, Image>(StringComparer.OrdinalIgnoreCase);

            foreach (var dir in directories)
            {
                if (!Directory.Exists(dir)) continue;

                foreach (var file in Directory.GetFiles(dir))
                {
                    //filtra para apenas extensões validas
                    if (!validExtensions.Contains(Path.GetExtension(file))) continue;

                    string key = Path.GetFileNameWithoutExtension(file);

                    //tratamento de chaves duplicadas
                    if (!Imagens.ContainsKey(key))
                    {
                        try
                        {
                            Imagens.Add(key, Image.FromFile(file));
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Erro ao carregar imagem '{file}': {ex.Message}");
                        }
                    }
                }
            }
            return Imagens;
        }



    }
}
