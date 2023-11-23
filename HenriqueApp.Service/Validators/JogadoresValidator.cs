using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HenriqueApp.Domain.Entities;

namespace HenriqueApp.Service.Validators
{
    public class JogadoresValidator : AbstractValidator<Jogadores>
    {
        public JogadoresValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por favor informe o nome.")
                .NotNull().WithMessage("Por favor informe o nome.");
            RuleFor(c => c.Idade)
                .NotEmpty().WithMessage("Por favor informe a idade.")
                .NotNull().WithMessage("Por favor informe a idade.");
            RuleFor(c => c.Gols)
                .NotEmpty().WithMessage("Por favor informe os gols.")
                .NotNull().WithMessage("Por favor informe os gols.");
            RuleFor(c => c.Assist)
                .NotEmpty().WithMessage("Por favor informe as assistências")
                .NotNull().WithMessage("Por favor informe as assistências.");
            RuleFor(c => c.Capitao)
                .NotEmpty().WithMessage("Por favor informe se é capitão.")
                .NotNull().WithMessage("Por favor informe se é capitão.");
            RuleFor(c => c.Time)
                .NotEmpty().WithMessage("Por favor informe o time.")
                .NotNull().WithMessage("Por favor informe o time.");
        }
    }
}
