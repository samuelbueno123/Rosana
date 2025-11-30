namespace Projeto.Services
{
    public static class EsporteService
    {

        private static string GetEsporte(string esporte)
        {

            string view = esporte.ToLower() switch
            {
                "jogadores" => "jogadores",
                "futebol" => "jogadores_futebol",
                "basquete" => "jogadores_basquete",
                "baseball" => "jogadores_baseball",
                "nfl" => "jogadores_nfl",
                _ => throw new ArgumentException("Esporte inválido")
            };
            return view;

        }

        public static DataTable? GetJogadores(string esporte)
        {

            string query = $"SELECT * FROM {GetEsporte(esporte)}";

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
