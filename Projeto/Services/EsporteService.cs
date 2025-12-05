using Microsoft.Graph.Models;

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
                    "select nome, melhortempo, `títulos` " +
                    "from atletismo join jogadores on jogadores.codigo = atletismo.jogadores_codigo",

                "baseball" =>
                    "select nome, partidas, mediarebatidas, homeruns, basesroubadas, corridas " +
                    "from baseball join jogadores on jogadores.codigo = baseball.jogadores_codigo",

                "basquete" =>
                    "select nome, partidas, pontos, `3pontos`, rebote, assistencias " +
                    "from basquete join jogadores on jogadores.codigo = basquete.jogadores_codigo",

                "boxe" =>
                    "select nome, nocautes, vitorias, derrotas, razaovitorias, ouro, prata, bronze " +
                    "from boxe join jogadores on jogadores.codigo = boxe.jogadores_codigo",

                "cod" =>
                    "select nome, kills, mortes, kd, adr, titulos " +
                    "from cod join jogadores on jogadores.codigo = cod.jogadores_codigo",

                "cs" =>
                    "select nome, kills, mortes, kd, adr, `títulos` " +
                    "from cs join jogadores on jogadores.codigo = cs.jogadores_codigo",

                "formula1" =>
                    "select nome, podios, polepositions, vitorias " +
                    "from formula1 join jogadores on jogadores.codigo = formula1.jogadores_codigo",

                "futebol" =>
                    "select nome, partidas, gols, assistencias, titulos, boladeouro " +
                    "from futebol join jogadores on jogadores.codigo = futebol.jogadores_codigo",

                "futebolamericano" =>
                    "select nome, partidas, jardas, mediajardas, pontos, `títulos` " +
                    "from futebolamericano join jogadores on jogadores.codigo = futebolamericano.jogadores_codigo",

                "golf" =>
                    "select nome, holeinone, gir " +
                    "from golfe join jogadores on jogadores.codigo = golfe.jogadores_codigo",

                "jogadores" =>
                    "select * from jogadores_esporte",

                "judo" =>
                    "select nome, faixa, clube, ouros, prata, bronze, ippon " +
                    "from judo join jogadores on jogadores.codigo = judo.jogadores_codigo",

                "natacao" =>
                    "select nome, melhortempo, velmedia, `títulos` " +
                    "from natacao join jogadores on jogadores.codigo = natacao.jogadores_codigo",

                "rocket" =>
                    "select nome, golsporjogo, assistporjogo, defesaporjogo " +
                    "from rocket join jogadores on jogadores.codigo = rocket.jogadores_codigo",

                "valorant" =>
                    "select nome, agente, kills, mortes, kd, adr, titulos " +
                    "from valorant join jogadores on jogadores.codigo = valorant.jogadores_codigo",

                "xadrez" =>
                    "select nome, percentvitoria, elo, aberturafavorita, titulos " +
                    "from xadrez join jogadores on jogadores.codigo = xadrez.jogadores_codigo",

                _ => throw new ArgumentException("esporte inválido")
            };
        }



        //public static List<string>? GetJogadores(string esporte) fazer a logica para preencher as estatisticas depois
        {

            string query = (esporte == "jogadores") ?
                $"SELECT * FROM jogadores_esporte" :
                Queries(esporte);

            using (var conn = BD.Conectar())
            {
                if (conn is null) return null;

                using (MySqlDataReader? reader = new MySqlCommand(query, conn).ExecuteReader())
                {
                    List<string> jogadores = [];
                    while (reader.Read())
                    {
                        jogadores.Add(reader.GetString("nome"));
                    }
                    return jogadores;
                }

            }


        }

    }
}
