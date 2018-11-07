# ToDoApi2
### Randy Powell
### Capitol Technology University
### CT 406
### Homework 8: Backend services for native mobile apps
### URL OF SITE: not currently hosted

### Description
This app is the result of following the API tutorial at
* https://docs.microsoft.com/en-us/aspnet/core/mobile/native-mobile-backend?view=aspnetcore-2.1

This is an API app that tracks a list of to do items and allows adding, editing, and deleting of items in an programming interface.
An API is created with methods to create, update, delete, and get all items.
This API is created and all these methods are defined in ` ToDoItemsController.cs `. These methods can be called by sending http requests
from an interface such as Postman. The controller uses ` ToDoRepository.cs ` to control a local database. The data is not persistant and is
automatically populated with sample data when the program is started. After that, items can be added, edited, or deleted with requests. When the program is closed,
the data is lost.