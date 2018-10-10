# RazorPagesMovie
### Randy Powell
### Capitol Technology University
### CT 406
### Homework 4: Razor Pages Movie App
### URL OF SITE: not currently hosted, functionality is very similar to MvcMovie, hosted at https://rpowellmvc.azurewebsites.net/Movies

### Description
This app is the result of follwing the Razor pages tutorials at https://docs.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/?view=aspnetcore-2.1 and https://docs.microsoft.com/en-us/aspnet/core/razor-pages/upload-files?view=aspnetcore-2.1
The movie app tracks a list of movies along with information about them. Each movie entry is stored in a database and has a separate razor page to view details, edit, create, and delete.
The schedules section of the app allows users to upload text files and tracks them in a list.
The app is organized into Models and Pages. Each page is comprised of a razor .cshtml file and a corresponding .cshtml.cs file.
Models are used to create classes of data and connect to the database. I created a model class for File Upload, Movie, Movie Context, Schedule, and Seed Data. This is essentially the same as in an MVC architecture.

Where the razor pages methodology differs from MVC is in the views and controllers. In an MVC app, each view is associated with a controller by name, a controller may have many views. The view does not connect directly to the C# file.
In a Razor app, each view, or page, is associated directly with cs code. The code is either embedded in the cshtml file, or a cshtml.cs file is referenced in it. This makes Razor pages more organized and easier to follow.
Razor controller files usually tend to stay smaller than MVC controller files that can keep growing and running many different pages. It is easier to track when one C# file controls one page.

Legacy ASP.NET developers may be familiar with ASP.Net WebForms, a programming model which came natively to the original ASP.Net back in the early 2000s.
This model used a very similar methodology of each page having a front end view file and an associated backend cs file, eliminating the need of a controller.
The Razor model seems to be bringing this format of web development back into use, even though it is a relatively new framework.