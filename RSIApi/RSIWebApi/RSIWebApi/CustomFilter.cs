

using Microsoft.AspNetCore.Mvc.Filters;
using RSI.Core.Interfaces;

namespace RSIWebApi
{
    public class CustomFilter : IActionFilter
    {
        private readonly IEventService _eventService;

        public CustomFilter(IEventService eventService)
        {
            _eventService = eventService;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
           if(context.HttpContext.Request.Headers.TryGetValue("User", out var name))
            {
                _eventService.SetUsername(name);
            }
        }
    }
}
