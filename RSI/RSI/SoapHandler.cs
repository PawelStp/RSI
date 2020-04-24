using Microsoft.AspNetCore.Http;
using RSI.Services;
using SoapCore.Extensibility;
using SoapCore.ServiceModel;

namespace RSI
{
    public class SoapHandler : IServiceOperationTuner
    {
        public void Tune(HttpContext httpContext, object serviceInstance, OperationDescription operation)
        {
            SOAPService service = serviceInstance as SOAPService;

            if (httpContext.Request.Headers.TryGetValue("User", out var paramValue))
            {
                service.SetUsername(paramValue[0]);
            }
        }
    }
}
