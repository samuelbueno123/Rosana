using Microsoft.Graph.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Projeto.Utils
{

    public static class Conta
    {

        private static Usuario? usuario { get; set; }
        private static readonly PasswordHasher<object> hasher = new PasswordHasher<object>();
        private static readonly string query = "select id, nome, email from usuario where nome = @usuario or email = @usuario";

        public static string HasharSenha(string senha) => hasher.HashPassword("", senha);

        public static bool VerificarSenha(string hash, string senha)
        {

            var resultado = hasher.VerifyHashedPassword("", hash, senha); // se bugado, formato do banco de dados está ERRADO
            return resultado == PasswordVerificationResult.Success;

        }

        public static int Cadastrar(string usuario, string email, string senha)
        {

            string insertcadastro = "insert into usuario (nome, email, senha) values (@usuario, @email, @senha)";

            using (var conn = BD.Conectar())
            {
                if (conn == null) return 0;

                using (var cmd = new MySqlCommand(insertcadastro, conn))
                {

                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@senha", senha);
                    return cmd.ExecuteNonQuery();

                }
            }
        }

        public static bool Logar(string user)
        {

            using (var conn = BD.Conectar())
            {
                if (conn == null) return false;

                using (var cmd = new MySqlCommand(query, conn))
                {

                    cmd.Parameters.AddWithValue("@usuario", user);

                    cmd.ExecuteNonQuery();

                    using (var data = cmd.ExecuteReader())
                    {
                        data.Read();
                        Sessao.UsuarioAtual = new(data.GetInt32("id"), data.GetString("nome").ToString(), data.GetString("email").ToString());

                        return Sessao.UsuarioAtual!.nome == user || Sessao.UsuarioAtual.email == user;

                    }
                }
            }

        }

        public static int AlterarSenha(string senha, string nova)
        {
            string hash;
            string query = "select senha from usuario where nome = @nome";

            using (var cmd = new MySqlCommand(query, BD.Conectar()))
            {
                cmd.Parameters.AddWithValue("@nome", Sessao.UsuarioAtual!.nome);
                hash = cmd.ExecuteScalar().ToString() ?? "";
                if (!Conta.VerificarSenha(hash, senha)) return -1;
            }
            using (var cmd = new MySqlCommand("updatesenha", BD.Conectar()))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("_nome", Sessao.UsuarioAtual.nome);
                cmd.Parameters.AddWithValue("atual", senha);
                cmd.Parameters.AddWithValue("nova", nova);
                return cmd.ExecuteNonQuery();
            }
        }
    }
}