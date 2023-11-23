using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HenriqueApp.Domain.Entities;

namespace HenriqueApp.Service.Validators
{
    public class TemporadaValidator : AbstractValidator<Temporada>
    {
        public TemporadaValidator()
        {
            RuleFor(c => c.Ano)
                .NotEmpty().WithMessage("Por favor informe o ano.")
                .NotNull().WithMessage("Por favor informe o ano.");
        }
    }
}
