﻿using FluentValidation;
using Shopping_WebApi.Features.DigitalProducts.Commands;

namespace Shopping_WebApi.Features.DigitalProducts.Validators
{
    public class DeleteDigitalProductCommandValidator : AbstractValidator<DigitalProductQueryCommand>
    {
        public DeleteDigitalProductCommandValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("Id is required.");
        }
    }


}
