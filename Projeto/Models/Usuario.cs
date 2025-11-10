namespace Projeto.Models
{

    public class Usuario : IDisposable
    {

        public int Id { get; set; }
        public string Nome {  get; set; }
        public string Email {  get; set; }
        public string SenhaHash { get; set; }
        private bool disposed = false;

        public Usuario(int id, string nome, string email, string senhahash)
        {
            this.Id = id;
            this.Nome = nome;
            this.Email = email;
            SenhaHash = senhahash;
        }
    

        public void Sair()
        {
            Id = -1;
            Nome = "";
            Email = "";
            SenhaHash = "";
            Dispose();
        }

        public void Dispose()
        {
            if (disposed) return;
            disposed = true;
            GC.SuppressFinalize(this);
        }

        ~Usuario()
        {
            Dispose();
        }
    }
}