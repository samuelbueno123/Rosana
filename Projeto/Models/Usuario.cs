namespace Projeto.Models
{

    public class Usuario : IDisposable
    {

        public int id { get; set; }
        public string nome {  get; set; }
        public string email {  get; set; }
        private bool disposed = false;

        public Usuario(int id, string nome, string email)
        {
            this.id = id;
            this.nome = nome;
            this.email = email;
        }
    

        public void Sair()
        {
            id = -1;
            nome = "";
            email = "";
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