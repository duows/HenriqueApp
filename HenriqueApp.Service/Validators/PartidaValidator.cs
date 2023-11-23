using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HenriqueApp.Domain.Entities;

namespace HenriqueApp.Service.Validators
{
    public class PartidaValidator : AbstractValidator<Partida>
    {
        public PartidaValidator()
        {
            RuleFor(c => c.Data)
                .NotEmpty().WithMessage("Por favor informe a data.")
                .NotNull().WithMessage("Por favor informe a data.");
            RuleFor(c => c.Gol1)
                .NotEmpty().WithMessage("Por favor informe os gol do time mandante.")
                .NotNull().WithMessage("Por favor informe os gol do time mandante.");
            RuleFor(c => c.Gol2)
                .NotEmpty().WithMessage("Por favor informe os gol do time visitante.")
                .NotNull().WithMessage("Por favor informe os gol do time visitante.");
            RuleFor(c => c.Time1)
                .NotEmpty().WithMessage("Por favor informe o time mandante.")
                .NotNull().WithMessage("Por favor informe o time mandante.");
            RuleFor(c => c.Time2)
                .NotEmpty().WithMessage("Por favor informe o time visitante.")
                .NotNull().WithMessage("Por favor informe o time visitante.");
        }
    }
}
