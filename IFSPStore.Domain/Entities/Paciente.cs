using ConsultorioIFSP.Domain.Base;

namespace ConsultorioIFSP.Domain.Entities
{
    public class Paciente : BaseEntity<int>
    {
        public Paciente()
        {

        }
        public Paciente(int id, string nome, string email, DateTime dataNascimento, string sexo, string telefone) : base(id)
        {
            Nome = nome;
            Email = email;
            Sexo = sexo;
            DataNascimento = dataNascimento;
            Telefone = telefone;

        }

        public string Nome { get; set; }
        public string Email { get; set; }
        public string Sexo { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }


    }
}
