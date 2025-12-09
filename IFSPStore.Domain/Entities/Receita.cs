
using ConsultorioIFSP.Domain.Base;

namespace ConsultorioIFSP.Domain.Entities
{
    public class Receita : BaseEntity<int>
    {
        public Receita()
        {

        }
        public Receita(int id, DateTime periodo, int quantidade) : base(id)
        {
            Periodo = periodo;
            Quantidade = quantidade;

        }
        public DateTime Periodo { get; set; }
        public int Quantidade { get; set; }
    }
}
