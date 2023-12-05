using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HenriqueApp.Domain.Entities;

namespace HenriqueApp.Service.Validators
{
    public class TempCampValidator : AbstractValidator<TempCamp>
    {
        public TempCampValidator()
        {
            RuleFor(c => c.Premio)
                .NotEmpty().WithMessage("Por favor informe o premio.")
                .NotNull().WithMessage("Por favor informe o premio.");
            RuleFor(c => c.Campeao)
                .NotEmpty().WithMessage("Por favor informe o campeao.")
                .NotNull().WithMessage("Por favor informe o campeao.");
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por favor informe o nome.")
                .NotNull().WithMessage("Por favor informe o nome.");
            RuleFor(c => c.Camp)
                .NotEmpty().WithMessage("Por favor informe o campeonato.")
                .NotNull().WithMessage("Por favor informe o campeonato.");
            RuleFor(c => c.Temp)
                .NotEmpty().WithMessage("Por favor informe o temporada.")
                .NotNull().WithMessage("Por favor informe o temporada.");
        }
    }
}
