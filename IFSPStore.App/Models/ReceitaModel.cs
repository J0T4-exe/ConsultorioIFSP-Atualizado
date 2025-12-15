
namespace ConsultorioIFSP.App.Models
{
    public class ReceitaModel
    {
        public int Id { get; set; }
        public DateTime Periodo { get; set; }
        public int Quantidade { get; set; }
        public int MedicoId { get; set; }
        public int PacienteId { get; set; }
    }
}
