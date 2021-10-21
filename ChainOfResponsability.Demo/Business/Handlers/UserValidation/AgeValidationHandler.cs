using ChainOfResponsability.Demo.Business.Exceptions;
using ChainOfResponsability.Demo.Business.Models;

namespace ChainOfResponsability.Demo.Business.Handlers.UserValidation
{
    public class AgeValidationHandler : Handler<User>
    {
        public override void Handle(User request)
        {
            if (request.Age < 18)
            {
                throw new UserValidationException("You have to be 18 years or older");
            }

            base.Handle(request);
        }
    }
}
