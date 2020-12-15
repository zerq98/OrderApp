using FluentValidation;
using OrderApp.App.Dto;

namespace OrderApp.Validation
{
    public class ProductValidation : AbstractValidator<ProductDto>
    {
        /// <summary>
        /// Validate product properties.
        /// </summary>
        public ProductValidation()
        {
            RuleFor(x => x.Name).NotNull().NotEmpty();
            RuleFor(x => x.Price).GreaterThanOrEqualTo(0);
            RuleFor(x => x.Quantity).GreaterThanOrEqualTo(1);
        }
    }
}