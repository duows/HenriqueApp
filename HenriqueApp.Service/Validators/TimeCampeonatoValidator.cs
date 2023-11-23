using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HenriqueApp.Domain.Entities;
namespace HenriqueApp.Service.Validators
{
    public class TimeCampeonatoValidator : AbstractValidator<TimeCampeonato>
    {
        public TimeCampeonatoValidator()
        {
            RuleFor(c => c.Time)
                .NotEmpty().WithMessage("Por favor informe o time.")
                .NotNull().WithMessage("Por favor informe o time.");
            RuleFor(c => c.Temp)
                .NotEmpty().WithMessage("Por favor informe a temporada do campeonato.")
                .NotNull().WithMessage("Por favor informe a temporada do campeonato.");
            RuleFor(c => c.Pontos)
                .NotEmpty().WithMessage("Por favor informe os pontos.")
                .NotNull().WithMessage("Por favor informe os pontos.");
            RuleFor(c => c.Posicao)
                .NotEmpty().WithMessage("Por favor informe a posicao.")
                .NotNull().WithMessage("Por favor informe a posicao.");
            RuleFor(c => c.Golpro)
                .NotEmpty().WithMessage("Por favor informe os gols pro.")
                .NotNull().WithMessage("Por favor informe os gols pro.");
            RuleFor(c => c.Golcon)
                .NotEmpty().WithMessage("Por favor informe os gols contra.")
                .NotNull().WithMessage("Por favor informe os gols contra.");
        }
    }
}
