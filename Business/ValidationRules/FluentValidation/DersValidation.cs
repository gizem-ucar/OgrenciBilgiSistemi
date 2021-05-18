using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class DersValidation : AbstractValidator<Ders>
    {
        public DersValidation()
        {
            RuleFor(d => d.DersAdi).NotEmpty();
            RuleFor(d => d.DersKodu).MaximumLength(6);
            RuleFor(d => d.Id).NotEmpty();
        }
    }
}
