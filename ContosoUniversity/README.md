# ContosoUniversity
### Randy Powell
### Capitol Technology University
### CT 406
### Homework 7: EF in Razor Pages App
### URL OF SITE: not currently hosted

### Description
This app is the result of following the Entity Framework tutorials at
* https://docs.microsoft.com/en-us/aspnet/core/data/ef-rp/index?view=aspnetcore-2.1

University web application to track students, instructors, courses, departments, offices, and how they are all connected.


### Questions
1. What is the difference between database first and code first approaches?

In a code first approach, entity classes with properties already defined are created first.
Entity Framework automatically creates the database and tables based on the already defined classes.
The database is generated from the code.

In the database first approach, databases and tables are created first, then entities are created from the existing database.

2. Explain a scenario where using the Scaffold-DbContext would be beneficial.

Scaffold-DbContext would be beneficial if a database already exists and models need to be created off of it.
If a company already has a large scale database that would be tough to reconstruct, Scaffold-Dbcontext could be used
to generate entity classes for each table in the database, to be easily used in the application.

3. What is the difference between configuration by using Data Annotation Attributes vs. using Fluent API?

Data annotation attributes are set inside the model, are simpler, and more readable than Fluent API.
The Fluent API approach requires annotations and tunings of the database to be done in the database context class
rather than in the model itself. These annotations are more complicated but offer a greater capability than the
Data Annotation approach. The data annotation approach is simpler and easier to use but the Fluent API approach offers greater capabilities.