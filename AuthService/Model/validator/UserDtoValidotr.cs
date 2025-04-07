using AuthService.Utility;
using FluentValidation;

namespace AuthService.Model.validator
{
    public class UserDtoValidotor : AbstractValidator<UserDto>
    {
        public UserDtoValidotor()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Email).NotEmpty().EmailAddress();
            RuleFor(x => x.Address).NotEmpty();
            RuleFor(x => x.Role)
                .NotEmpty()
                .Must(role => role == SD.DeliveryPartnerRole || role == SD.CustomerRole)
                .WithMessage($"Role must be either '{SD.DeliveryPartnerRole}' or '{SD.CustomerRole}'.");
            RuleFor(x => x.PhoneNumber).NotEmpty();
            RuleFor(x => x.Password).NotEmpty();


        }
    }
}
