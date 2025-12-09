using IFSPStore.Domain.Base;


namespace ConsultorioIFSP.Domain.Entities
{
    public class Consulta : BaseEntity<int>
    {
        public Consulta()
        {

        }
        public Consulta(int id, DateTime dataConsulta, TimeOnly horario) : base(id)
        {
            DataConsulta = dataConsulta;
            Horario = horario;

        }

        public DateTime DataConsulta { get; set; }
        public TimeOnly Horario { get; set; }
        public int Paciente { get; set; }
        public int MedicoId { get; set; }
    }
}
