# ControllerDI
### Randy Powell
### Capitol Technology University
### CT 406
### Homework 5: Dependency Injection in Controllers and Requirement Handlers
### URL OF SITE: not currently hosted

### Description
This app is the result of following the dependency injection tutorials at 
* https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/dependency-injection?view=aspnetcore-2.1
* https://docs.microsoft.com/en-us/aspnet/core/security/authorization/dependencyinjection?view=aspnetcore-2.1

This app consists of three demos of dependency injection in controllers and one example of dependency injection in requirement handlers. The first demo is on the /Views/Home/Index.cshtml page which uses the Home controller. This page gets the current server time and outputs whether it is morning, afternoon, or evening. The Home controller uses an interface to access the SystemDateTime Service. The IDateTime interface is injected into the controller. This allows the controller to access the 'Now' field from the SystemDateTime service and perform business logic on it. The service is not injected directly but rather through an interface. In /Startup.cs, the service is configured as a 'Transient' so the service will be configured each time it is requested.

The second demo, still using the Home controller, is on the /Views/Home/About.cshtml page. This page outputs the current time on the server. This example uses the same service but injects it in a different way. In this example, the service is injected as a paramenter to the action method using the ` [FromServices] ` attribute. The information from the service is accessible inside the method.

The third example is shown on the /Views/Settings/Index.cshtml page and uses the Settings controller. This page outputs a set of configuration settings from a json file. This example shows how to access configuration settings from within a controller. The json file is read in the Startup.cs file and configured into a SampleWebSettings object. This object can be injected into the controller using ` IOptions<SampleWebSettings> `. The settings can then be read into the controller and output to the view.

The last example shows dependency injection in requirement handlers and is shown in /Services/LoggingAuthorizationHandler.cs. A repository of requirement rules, created at /Services/Requirements/MyRequirement.cs, is to be evaluated inside the authorization handler. To use ASP.NET logging in the handler, an ILoggerFactory must be injected.
### Questions:
1. How does Dependency Injection help to write 'Clean Code'?

Dependency Injection makes it so modules and classes that depend on each other are not strongly coupled. In this methodology, classes do not directly refer to each other and instantiate each other. Instead, a layer of abstraction is added so when one is changed, it does not directly effect the other. As a result, code is much more maintainable, modular, clean, easy to test, and easy to follow. 

2. For your final project, how can you use Inversion of Control in your application?

No classes I create should be tightly coupled to another class. This would make it easier to maintain which is important because I will be using and updating the application for years as I gain more experience.

3. What is the Explicit Dependencies Principle?

Methods and classes should explicitly require any collaborating objects they need in order to function correctly. They should be honest and state very clearly what they require to carry out their function.