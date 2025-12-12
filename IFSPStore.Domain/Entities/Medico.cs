using ConsultorioIFSP.Domain.Base;

namespace ConsultorioIFSP.Domain.Entities
{
    public class Medico : BaseEntity<int>
    {
        public Medico()
        {

        }
        public Medico(int id, string nome, string login, string password, string especialidade, string crm, string telefone, string email) : base(id)
        {
            Nome = nome;
            Login = login;
            Password = password;
            Especialidade = especialidade;
            Crm = crm;
            Telefone = telefone;
            Email = email;

        }

        public string Nome { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Especialidade { get; set; }
        public string Crm { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

    }
}
