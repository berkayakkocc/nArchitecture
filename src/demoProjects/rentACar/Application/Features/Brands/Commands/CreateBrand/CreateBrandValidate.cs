﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Brands.Commands.CreateBrand
{
    public class CreateBrandValidate:AbstractValidator<CreateBrandCommand>
    {
        public CreateBrandValidate()
        {
            RuleFor(c => c.Name).NotEmpty();
            RuleFor(c => c.Name).MinimumLength(2);

        }
    }
}
