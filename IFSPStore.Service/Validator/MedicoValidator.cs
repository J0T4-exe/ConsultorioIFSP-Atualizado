using ConsultorioIFSP.Domain.Entities;
using FluentValidation;

namespace ConsultorioIFSP.Domain.Validators
{
    public class MedicoValidator : AbstractValidator<Medico>
    {
        public MedicoValidator()
        {
            RuleFor(m => m.Nome)
                .NotEmpty().NotNull().WithMessage("O Nome do Médico é obrigatório.")
                .MaximumLength(100).WithMessage("O Nome não pode exceder 100 caracteres.");
        }
    }
}