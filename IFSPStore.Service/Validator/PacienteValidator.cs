using ConsultorioIFSP.Domain.Entities;
using FluentValidation;
using System;

namespace ConsultorioIFSP.Domain.Validators // Namespace de exemplo
{
    public class PacienteValidator : AbstractValidator<Paciente>
    {
        public PacienteValidator()
        {
            RuleFor(p => p.Nome)
                .NotEmpty().NotNull()
                .WithMessage("O Nome do Paciente é obrigatório.")
                .MaximumLength(100).WithMessage("O Nome não pode exceder 100 caracteres.");

            RuleFor(p => p.Email)
                .EmailAddress().WithMessage("E-mail inválido.")
                .NotEmpty().NotNull().WithMessage("O E-mail é obrigatório.")
                .MaximumLength(100).WithMessage("O Email não pode exceder 100 caracteres.");

            RuleFor(p => p.Sexo)
                .NotEmpty().NotNull()
                .WithMessage("O Sexo é obrigatório.")
                .MaximumLength(10).WithMessage("O Sexo não pode exceder 10 caracteres.");

            RuleFor(p => p.Telefone)
                .NotEmpty().NotNull()
                .WithMessage("O Telefone é obrigatório.")
                .MaximumLength(20).WithMessage("O Telefone não pode exceder 20 caracteres.");

            RuleFor(p => p.DataNascimento)
                .LessThan(DateTime.Now.Date)
                .WithMessage("A Data de Nascimento não pode ser atribuida");
        }
    }
}