using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace ST10449143_CLDV6212_POEPART2.Functions.Functions;

public class CustomersFunctions
{
    private readonly ILogger<CustomersFunctions> _logger;

    public CustomersFunctions(ILogger<CustomersFunctions> logger)
    {
        _logger = logger;
    }

    [Function("CustomersFunctions")]
    public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
    {
        _logger.LogInformation("C# HTTP trigger function processed a request.");
        return new OkObjectResult("Welcome to Azure Functions!");
    }
}