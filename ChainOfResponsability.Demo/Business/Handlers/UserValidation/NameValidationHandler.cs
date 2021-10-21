using ChainOfResponsability.Demo.Business.Exceptions;
using ChainOfResponsability.Demo.Business.Models;

namespace ChainOfResponsability.Demo.Business.Handlers.UserValidation
{
    public class NameValidationHandler : Handler<User>
    {
        public override void Handle(User request)
        {
            if (request.Name.Length <= 1)
            {
                throw new UserValidationException("Your name is unlikely this short.");
            }

            base.Handle(request);
        }
    }
}
