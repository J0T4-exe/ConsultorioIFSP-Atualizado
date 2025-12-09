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

            RuleFor(m => m.Especialidade)
                .NotEmpty().NotNull().WithMessage("A Especialidade é obrigatória.")
                .MaximumLength(100).WithMessage("A Especialidade não pode exceder 100 caracteres.");

            RuleFor(m => m.Crm)
                .NotEmpty().NotNull().WithMessage("O CRM é obrigatório.")
                .MaximumLength(20).WithMessage("O CRM não pode exceder 20 caracteres.");

            RuleFor(m => m.Telefone)
                .NotEmpty().NotNull().WithMessage("O Telefone é obrigatório.")
                .MaximumLength(20).WithMessage("O Telefone não pode exceder 20 caracteres.");

            RuleFor(m => m.Login)
                .NotEmpty().NotNull().WithMessage("O Login é obrigatório.")
                .MaximumLength(50).WithMessage("O Login não pode exceder 50 caracteres.");

            RuleFor(m => m.Password)
                .NotEmpty().NotNull().WithMessage("A Senha é obrigatória.")
                .MinimumLength(6).WithMessage("A Senha deve ter pelo menos 6 caracteres.");
        }
    }
}