using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using Food.Exception;

namespace Food.Aspects
{
    public class ExceptionHandlerAttribute : ExceptionFilterAttribute
    {

        public override void OnException(ExceptionContext context) // called when exception occurs
        {
            var exceptionType = context.Exception.GetType();
            var message = context.Exception.Message;

            if (exceptionType == typeof(DishNotFoundException))
            {
                var result = new NotFoundObjectResult(message);
                context.Result = result;
            }
            else if (exceptionType == typeof(DishAlreadyExistsException))
            {
                var result = new ConflictObjectResult(message);
                context.Result = result;
            }

            else
            {
                var result = new StatusCodeResult(500);
                context.Result = result;
            }
        }
    }
}
