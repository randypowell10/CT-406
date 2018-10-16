# ViewInjectSample
### Randy Powell
### Capitol Technology University
### CT 406
### Homework 5: Dependency Injection in Views
### URL OF SITE: not currently hosted

### Description
This app is the result of following the dependency injection tutorial at
* https://docs.microsoft.com/en-us/aspnet/core/mvc/views/dependency-injection?view=aspnetcore-2.1

The app consists of three dependency injection demostrations, each in a separate view. The first demo is shown in the ToDo view located at /Views/ToDo/Index.cshtml. This view contains a list of tasks and a summary at the top. In this example, a service is injected directly into a view using ` @inject `. The statistics service is built in /Models/Services/StatisticsService.cs and is essentially a class with with a series of functions to calculate summary information. These functions are called in the .cshtml file to directly populate the summary elements at the top of the page.

The second demo is shown in the Profile view at /Views/Profile/Index.cshtml which contains a few dropdown lists and an input box to update information about a person. In this example, the ProfileOptions Service is injected directly into the view and used to populate the options of the inputs. This logic is usually done in the controller but injecting it directly into the view minimizes time and effort.

The last demo, shown at /Views/Helper/Index.cshtml, demonstrates using dependency injection to override previously injected services. The page doesn't do anything besides printing a message to the screen. The message is derived from the html helper class. The default html helper class is overridden by ` MyHtmlHelper ` so the message displayed is the message set in /Helpers/MyHtmlHelper.cs