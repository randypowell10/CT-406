# ContactManager
### Randy Powell
### Capitol Technology University
### CT 406
### Homework 8: RESTful APIs
### URL OF SITE: not currently hosted

### Description
This app is the result of following the API tutorial at
* https://docs.microsoft.com/en-us/aspnet/web-api/overview/older-versions/build-restful-apis-with-aspnet-web-api

The app tracks a list of contacts each with a name and Id. The database is accessed by an html client
using a RESTful API. At the top level there are two routes. The api/contacts GET route sends a GET request
which activates the get() method of the API in ` ContactController.cs `. This retrieves all of the records
in the database and returns them as the response. While the tutorial used a class for a contact repository and 
and server caching, I use an EF core database to keep persistant data. The api/contacts POST route is called from
the index page. When a button is pressed, the data from a form is put into the body of a POST request and activates
the post() method in ` ContactController.cs `. This method adds the record to the database and returns an 'OK' response
along with the record.