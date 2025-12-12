using ConsultorioIFSP.Domain.Entities;
using FluentValidation;

namespace ConsultorioIFSP.Domain.Validators
{
    public class ConsultaValidator : AbstractValidator<Consulta>
    {
        public ConsultaValidator()
        {
            RuleFor(c => c.DataConsulta)
                .LessThanOrEqualTo(DateTime.Now)
                .WithMessage("A Data da Consulta deve ser igual ou posterior à data atual.");

            RuleFor(c => c.Horario)
                .NotNull().WithMessage("O Horário da Consulta é obrigatório.");

            RuleFor(c => c.PacienteId)
                .GreaterThan(0).WithMessage("O ID do Paciente é obrigatório.");

            RuleFor(c => c.MedicoId)
                .GreaterThan(0).WithMessage("O ID do Médico é obrigatório.");
        }
    }
}