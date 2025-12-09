using ConsultorioIFSP.Domain.Entities;
using FluentValidation;

namespace ConsultorioIFSP.Domain.Validators
{
    public class MedicamentoValidator : AbstractValidator<Medicamento>
    {
        public MedicamentoValidator()
        {
            RuleFor(m => m.Nome)
                .NotEmpty().NotNull().WithMessage("O Nome do Medicamento é obrigatório.")
                .MaximumLength(100).WithMessage("O Nome não pode exceder 100 caracteres.");
        }
    }
}