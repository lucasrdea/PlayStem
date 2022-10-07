using Microsoft.AspNetCore.Mvc.Filters;

namespace PlayStemAPI.Filters
{
    public class ValidateModelStateFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                // TBD
            }
        }
    }
}