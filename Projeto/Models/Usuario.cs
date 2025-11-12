namespace Projeto.Models
{

    public class Usuario(int id, string nome, string email, string senhahash) : IDisposable
    {
        private readonly IDisposable? _usuario;

        public int Id { get; set; } = id;
        public string Nome { get; set; } = nome;
        public string Email { get; set; } = email;
        public string SenhaHash { get; set; } = senhahash;

        public void Sair()
        {
            Id = -1;
            Nome = null; 
            Email = null;
            SenhaHash = null;
        }

        public void Dispose() => _usuario?.Dispose();

        ~Usuario() => Dispose();
    }
}