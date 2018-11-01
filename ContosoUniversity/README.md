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
At the top level, the app contains four main sections: Courses, Departments, Instructors, and Students.
The courses section displays and allows editing, creating, and deleting of all courses. Each course is associated with a department.
The students section displays and allows editing, creating, and deleting of all students. Each student can be associated with a list of courses.
This section also includes
sorting by enrollment date and last name, searching by name, and pagination as configured in ` Models/Student.cs ` and ` PaginatedList.cs `.
When the students details are opened, a list of his courses are displayed below his personal information.
The departments section displays and allows editing, creating, and deleting of all departments. Each department contains one administrator,
who is taken from the ` Instructors `  table. This section also features handling of concurrency conflicts. If one person edits an entry at the same time
as another person, whoever tries to submit their changes last gets warned about the changes that have already occured.
The instructors section displays and allows editing, creating, and deleting of all instructors. Each instructor can be assigned to 
an office space, and zero or more courses from the courses table. When an instructor is selected in the index view, his courses
are shown beneath the table. When one of these courses are selected, all students enrolled in that course are shown below that table.

This app was made using Razor Pages methodologies, all app logic is put in a cshtml.cs file, associated with a corresponding page file.
Each folder under pages contains a set of pages for showing, editing, creating, and deleting one type of data. These files were all initially generated
through scaffolding provided by visual studio. These folders correspond to model files of the entity they manipulate. Model files were created for
Course, CourseAssignment, Department, Enrollment, Instructor, OfficeAssignment, and Student. View models were created for AssignedCourseData, EnrollmentDateGroup,
and InstructorIndexData. Each model contains data annotations to specify parameters for each type of data and validate input for them.


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