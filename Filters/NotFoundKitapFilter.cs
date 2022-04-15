using BootcampAPIProje.Repositories;
using Microsoft.AspNetCore.Mvc.Filters;

namespace BootcampAPIProje.Filters
{
    public class NotFoundKitapFilter : ActionFilterAttribute
    {
        private readonly IKitapRepository _kitapRepository;

        public NotFoundKitapFilter(IKitapRepository kitapRepository)
        {
            _kitapRepository = kitapRepository;
        }

        public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            await next.Invoke();
        }
    }
}
