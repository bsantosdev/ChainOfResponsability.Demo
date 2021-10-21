using ChainOfResponsability.Demo.Business.Exceptions;
using ChainOfResponsability.Demo.Business.Models;
using ChainOfResponsability.Demo.Business.Validators;

namespace ChainOfResponsability.Demo.Business.Handlers.UserValidation
{
    public class SocialSecurityNumberValidatonHandler : Handler<User>
    {
        private SocialSecurityNumberValidator socialSecurityNumberValidaton
            = new SocialSecurityNumberValidator();

        public override void Handle(User request)
        {
            if (!socialSecurityNumberValidaton.Validate(request.SocialSecurityNumber, request.CitizenshipRegion))
            {
                throw new UserValidationException("Social security number could not be validated");
            }

            base.Handle(request);
        }
    }
}
