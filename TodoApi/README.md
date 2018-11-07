# TodoApi
### Randy Powell
### Capitol Technology University
### CT 406
### Homework 8: Web API
### URL OF SITE: not currently hosted

### Description
This app is the result of following the API tutorial at
* https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-2.1#call-the-web-api-with-jquery

This app tracks a list of to do items and allows adding, editing, and deleting of items in a front end interface.
An API is created with methods to create, update, delete, get item by id, and get all items.
This API is created and all these methods are defined in ` Todocontroller.cs `. A front end html page is used to 
call these methods. A list element is populated using the ` getAll() ` GET method. A POST request is sent to call the 
create method to create a record when the add button is pressed using data from a text box. Another POST request is sent to call
the delete method when the delete button is pressed. A PUT request is sent when the edit button is pressed. It calls the update
method to update a record using a text box and a checkbox for data. These requests all use the ` api/todo ` route for each method call.
