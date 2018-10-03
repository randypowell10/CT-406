# Mvc3ViewDemo
### Randy Powell
### Capitol Technology University
### CT 206
### Homework 3: MVC & Views
### URL OF SITE: https://mvc3viewdemo20181003022103.azurewebsites.net/

### Description
This app is the result of follwing the MVC Dynamic vs Strongly Typed Views tutorial at https://docs.microsoft.com/en-us/aspnet/mvc/overview/views/dynamic-v-strongly-typed-views 
The basic function of the app is to display a list of links to blogs. Each blog is stored as a blog object and the two main views loop through the list of blogs,
displaying their names as links to their URLs. The two main views, linked to from the index page, have the same esssential function,
accomplished in two different ways.

#### Difference between a Dynamic and Strongly Typed View
The first page is created as a Strongly Typed View. In the cshtml file, the tag at the top is written as ` @model IEnumerable<Mvc3ViewDemo.Controllers.Blog> `
This uses the IEnumerable interface to open read only access directly to Blog objects. The strongly typed method allows intellisense to work in
the view file. Keywords and options come up automatically in VS.
The second page is created as a Dynamic Typed View. The tag at the top is written as ` @model dynamic ` There is no direct reference to the type of object to be enumerated on.
The object is dynamically passed to the view. Intellisense does not work when the view is not strongly typed. This makes it more difficult to
remember correct syntax to reference the Blog object.
