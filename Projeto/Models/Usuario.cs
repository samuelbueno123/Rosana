namespace Projeto.Models
{

    public class Usuario
    {

        public int id { get; set; }
        public string nome {  get; set; }
        public string email {  get; set; }

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

        }
    }
}