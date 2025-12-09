
namespace ConsultorioIFSP.App.Models
{
    public class ReceitaModel
    {
        public int Id { get; set; }
        public DateTime Periodo { get; set; }
        public int Quantidade { get; set; }
        public MedicoModel Medico { get; set; }
        public PacienteModel Paciente { get; set; }
    }
}
