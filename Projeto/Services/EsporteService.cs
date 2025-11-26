namespace Projeto.Services
{
    public static class EsporteService
    {

        //private static string GetEsporte(string esporte)

        public static DataTable? GetJogadores(string esporte)
        {
            string query = "SELECT * FROM jogadores_nfl";

            using (var conn = BD.Conectar())
            {
                if (conn == null) return null;

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }

            }

        }

    }
}
