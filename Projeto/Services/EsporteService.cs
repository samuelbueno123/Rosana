using Microsoft.Graph.Models;
using System.Dynamic;

namespace Projeto.Services
{
    public static class EsporteService
    {

        public static string GetEsporte(string esporte)
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

        private static string Queries(string esporte)
        {
            return esporte.ToLower() switch
            {
                "atletismo" =>
                    "select melhortempo, `títulos` " +
                    "from atletismo where atletismo.jogadores_codigo = @codigo",

                "baseball" =>
                    "select partidas, mediarebatidas, homeruns, basesroubadas, corridas " +
                    "from baseball where baseball.jogadores_codigo = @codigo",

                "basquete" =>
                    "select partidas, pontos, `3pontos`, rebote, assistencias " +
                    "from basquete where basquete.jogadores_codigo = @codigo",

                "boxe" =>
                    "select nocautes, vitorias, derrotas, razaovitorias, ouro, prata, bronze " +
                    "from boxe where boxe.jogadores_codigo = @codigo",

                "cod" =>
                    "select kills, mortes, kd, adr, titulos " +
                    "from cod where cod.jogadores_codigo = @codigo",

                "cs" =>
                    "select kills, mortes, kd, adr, `títulos` " +
                    "from cs where cs.jogadores_codigo = @codigo",

                "formula1" =>
                    "select podios, polepositions, vitorias " +
                    "from formula1 where formula1.jogadores_codigo = @codigo",

                "futebol" =>
                    "select partidas, gols, assistencias, titulos, boladeouro " +
                    "from futebol where futebol.jogadores_codigo = @codigo",

                "futebolamericano" =>
                    "select partidas, jardas, mediajardas, pontos, `títulos` " +
                    "from futebolamericano where futebolamericano.jogadores_codigo = @codigo",

                "golfe" =>
                    "select holeinone, gir " +
                    "from golfe where golfe.jogadores_codigo = @codigo",

                "jogadores" =>
                    "select * from jogadores_esporte",

                "judo" =>
                    "select faixa, clube, ouros, prata, bronze, ippon " +
                    "from judo where judo.jogadores_codigo = @codigo",

                "natacao" =>
                    "select melhortempo, velmedia, `títulos` " +
                    "from natacao where natacao.jogadores_codigo = @codigo",

                "rocket" =>
                    "select golsporjogo, assistporjogo, defesaporjogo " +
                    "from rocket where rocket.jogadores_codigo = @codigo",

                "valorant" =>
                    "select agente, kills, mortes, kd, adr, titulos " +
                    "from valorant where valorant.jogadores_codigo = @codigo",

                "xadrez" =>
                    "select percentvitoria, elo, aberturafavorita, titulos " +
                    "from xadrez where xadrez.jogadores_codigo = @codigo",

                _ => throw new ArgumentException("esporte inválido")
            };
        }

        public static Dictionary<string, object>? GetStats(string nome, string esporte)
        {
            string query = Queries(esporte);

            using (var conn = BD.Conectar())
            {
                if (conn is null) return null;

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@codigo", GetCodigo(nome));
                    using (MySqlDataReader? reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Dictionary<string, object> stats = [];
                            for (int i = 0; i < reader.FieldCount; i++)
                                stats[reader.GetName(i)] = reader.GetValue(i);

                            return stats;
                        }
                        else
                            return null;
                    }
                }
            }
        }

        public static List<string>? GetJogadores(string esporte)
        {

            string query = $"select nome from jogadores where esporte = '{esporte}'";

            using (var conn = BD.Conectar())
            {
                if (conn is null) return null;

                using (MySqlDataReader? reader = new MySqlCommand(query, conn).ExecuteReader())
                {
                    List<string> jogadores = [];
                    while (reader.Read())
                        jogadores.Add(reader.GetString("nome"));

                    return jogadores;
                }
            }

        }

        public static string? GetNome(int codigo)
        {
            string query = "select nome from jogadores where codigo = @codigo";
            using (var conn = BD.Conectar())
            {
                if (conn is null) return null;

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@codigo", codigo);
                    object? result = cmd.ExecuteScalar();
                    return result != null ? result.ToString()! : string.Empty;
                }
            }
        }

        public static int? GetCodigo(string nome)
        {
            string query = "select codigo from jogadores where nome = @nome";
            using (var conn = BD.Conectar())
            {
                if (conn is null) return null;
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nome", nome);
                    object? result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1;
                }
            }
        }

        public static string? GetImages (string nome)
        {
            string query = "select image_url from jogadores where nome = @nome";
            using (var conn = BD.Conectar())
            {
                if (conn is null) return null;

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nome", nome);

                    string? result = cmd.ExecuteScalar() as string;
                    return result?.Split('.')[0];
                }
            }
        }
    }
}
