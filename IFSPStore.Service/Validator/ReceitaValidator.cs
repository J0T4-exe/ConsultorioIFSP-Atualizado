using ConsultorioIFSP.Domain.Entities;
using FluentValidation;
using System;

namespace ConsultorioIFSP.Domain.Validators
{
    public class ReceitaValidator : AbstractValidator<Receita>
    {
        public ReceitaValidator()
        {
            RuleFor(r => r.Periodo)
                .LessThanOrEqualTo(DateTime.Now)
                .WithMessage("O Período/Data da Receita não pode ser uma data futura.");

            RuleFor(r => r.Quantidade)
                .GreaterThan(0).WithMessage("A Quantidade deve ser maior que zero.");

            RuleFor(r => r.PacienteId)
                 .GreaterThan(0).WithMessage("O ID do Paciente é obrigatório na Receita.");

            RuleFor(c => c.MedicoId)
               .GreaterThan(0).WithMessage("O ID do Médico é obrigatório.");
        }
    }
}