
namespace ConsultorioIFSP.App.Models
{
    public class ConsultaModel
    {
        public string Id { get; set; }
        public DateTime? DataConsulta { get; set; }
        public TimeOnly? Horario { get; set; }
        public int MedicoId { get; set; }
        public int PacienteId { get; set; }
    }
}
