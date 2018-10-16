using System;
using ControllerDI.Interfaces;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;
using ControllerDI.Services.Requirements;

namespace ControllerDI.Services
{
    public class LoggingAuthorizationHandler : AuthorizationHandler<MyRequirement>
    {
        ILogger _logger;

        public LoggingAuthorizationHandler(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger(this.GetType().FullName);
        }

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, MyRequirement requirement)
        {
            _logger.LogInformation("Inside my handler");
            // Check if the requirement is fulfilled.
            return Task.CompletedTask;
        }
    }
}