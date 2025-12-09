using IFSPStore.Domain.Base;

namespace ConsultorioIFSP.Domain.Entities
{
    public class Medico : BaseEntity<int>
    {
        public Medico()
        {

        }
        public Medico(int id, string nome, string login, string password, string especialidade, string crm, string telefone) : base(id)
        {
            Nome = nome;
            Login = login;
            Password = password;
            Especialidade = especialidade;
            Crm = crm;
            Telefone = telefone;

        }

        public string Nome { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Especialidade { get; set; }
        public string Crm { get; set; }
        public string Telefone { get; set; }


    }
}
