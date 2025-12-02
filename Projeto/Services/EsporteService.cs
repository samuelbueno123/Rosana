namespace Projeto.Services
{
    public static class EsporteService
    {

        private static string GetEsporte(string esporte)
        {
            string view = esporte.ToLower() switch
            {
                "jogadores" => "jogadores",
                "futebol" => "futebol",
                "basquete" => "basquete",
                "baseball" => "baseball",
                "nfl" => "nfl",
                "atletismo" => "atletismo",
                "boxe" => "boxe",
                "formula1" => "formula1",
                "golfe" => "golfe",
                "judo" => "judo",
                "natacao" => "natacao",
                "xadrez" => "xadrez",
                "valorant" => "valorant",
                "rocket" => "rocket",
                "cs" => "cs",
                "cod" => "cod",
                _ => throw new ArgumentException("esporte inválido")
            };
            return view;
        }


        public static DataTable? GetJogadores(string esporte)
        {

            string query = (esporte == "jogadores") ?
                $"SELECT * FROM jogadores_esporte":
                $"SELECT * FROM jogadores_esporte WHERE esporte = \"{GetEsporte(esporte)}\"";

            using (var conn = BD.Conectar())
            {
                if (conn is null) return null;

                using (MySqlCommand cmd = new(query, conn))
                {

                    using (MySqlDataAdapter adapter = new(cmd))
                    {
                        DataTable dt = new();
                        adapter.Fill(dt);
                        return dt;
                    }

                }

            }


        }

    }
}
