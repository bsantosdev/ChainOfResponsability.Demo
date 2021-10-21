using ChainOfResponsability.Demo.Business.Exceptions;
using ChainOfResponsability.Demo.Business.Handlers.UserValidation;
using ChainOfResponsability.Demo.Business.Models;

namespace ChainOfResponsability.Demo.Business
{
    public class UserProcessor
    {
        public bool Register(User user)
        {
            try
            {
                var handler = new SocialSecurityNumberValidatonHandler();

                handler
                    .SetNext(new AgeValidationHandler())
                    .SetNext(new NameValidationHandler())
                    .SetNext(new CitizenshipRegionValidationHandler());

                handler.Handle(user);
            }
            catch (UserValidationException ex)
            {
                return false;
            }

            return true;
        }
    }
}
