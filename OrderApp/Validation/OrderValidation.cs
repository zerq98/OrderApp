using FluentValidation;
using OrderApp.App.Dto;

namespace OrderApp.Validation
{
    public class OrderValidation : AbstractValidator<OrderDto>
    {
        /// <summary>
        /// Validate order Properties
        /// </summary>
        public OrderValidation()
        {
            RuleFor(x => x.BirthDate).NotNull().NotEmpty().Matches(@"^[0-3]{1}[0-9]{1}\.[0-1]{1}[0-9]{1}\.[0-9]{0,1}[0-9]{0,1}[0-9]{0,1}[0-9]{0,1}$");
            RuleFor(x => x.FirstName).NotNull().NotEmpty().MaximumLength(63);
            RuleFor(x => x.Surname).NotNull().NotEmpty().MaximumLength(63);
        }
    }
}