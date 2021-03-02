using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.Description).NotEmpty();//boş bırakılmaz
            RuleFor(c => c.Description).MinimumLength(2);
            RuleFor(c => c.DailyPrice).GreaterThan(500000).When(c => c.BrandId == 2);//BMW fiyat min 500000  
            RuleFor(c => c.Description).Must(StartWithA).WithMessage("Arabalar A harfi ile başlamalı");//kendi kuralımızı yazdık

        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
