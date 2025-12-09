
using ConsultorioIFSP.Domain.Base;

namespace ConsultorioIFSP.Domain.Entities
{
    public class Medicamento : BaseEntity<int>
    {
        public Medicamento()
        {

        }
        public Medicamento(int id, String nome, String nome_Generico) : base(id)
        {
            Nome = nome;
            Nome_Generico = nome_Generico;

        }
        public string Nome { get; set; }
        public object Nome_Generico { get; set; }
    }
}
