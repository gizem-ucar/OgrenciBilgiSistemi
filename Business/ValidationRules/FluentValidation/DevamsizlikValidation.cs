using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class DevamsizlikValidation : AbstractValidator<Devamsizlik>
    {
        public DevamsizlikValidation()
        {
            RuleFor(d => d.DersId).NotEmpty();
            RuleFor(d => d.DevamsizlikDurumu).NotEmpty();
            RuleFor(d => d.OgrenciId).NotEmpty();
        }
    }
}
