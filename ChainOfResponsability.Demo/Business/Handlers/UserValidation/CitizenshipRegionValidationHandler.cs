using ChainOfResponsability.Demo.Business.Exceptions;
using ChainOfResponsability.Demo.Business.Models;

namespace ChainOfResponsability.Demo.Business.Handlers.UserValidation
{
    public class CitizenshipRegionValidationHandler : Handler<User>
    {
        public override void Handle(User request)
        {
            if (request.CitizenshipRegion.TwoLetterISORegionName == "NO")
            {
                throw new UserValidationException("We currently do not support Norwegians");
            }

            base.Handle(request);
        }
    }
}
