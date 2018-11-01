# ContosoUniversity2
### Randy Powell
### Capitol Technology University
### CT 406
### Homework 7: EF in MVC app
### URL OF SITE: not currently hosted

### Description
This app is the result of following the Entity Framework tutorial at
* https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/index?view=aspnetcore-2.1

University web application to track students, instructors, courses, departments, offices, and how they are all connected. This app
is very similar in functionality to ContosoUniversity, a Razor Pages application.
At the top level, the app contains four main sections: Courses, Departments, Instructors, and Students.
The courses section displays and allows editing, creating, and deleting of all courses. Each course is associated with a department.
The students section displays and allows editing, creating, and deleting of all students. 
Each student can be associated with a list of courses. This section also includes
sorting by enrollment date and last name, searching by name, and pagination as configured in ` Models/Student.cs ` and ` PaginatedList.cs `.
When the students details are opened, a list of his courses are displayed below his personal information.
The departments section displays and allows editing, creating, and deleting of all departments. Each department contains one administrator,
who is taken from the ` Instructors `  table. This section also features handling of concurrency conflicts. If one person edits an entry at the same time
as another person, whoever tries to submit their changes last gets warned about the changes that have already occured.
The instructors section displays and allows editing, creating, and deleting of all instructors. Each instructor can be assigned to 
an office space, and zero or more courses from the courses table. When an instructor is selected in the index view, his courses
are shown beneath the table. When one of these courses are selected, all students enrolled in that course are shown below that table.

This app was made using .NET Core MVC methodologies, all app logic is put into controller files, each with a set of associated page files.
Each folder under views contains a set of pages for showing, editing, creating, and deleting one type of data. These files were all initially generated
through scaffolding provided by visual studio. One folder of views corresponds to one controller and one model file of the entity they manipulate. Model files were created for
Course, CourseAssignment, Department, Enrollment, Instructor, OfficeAssignment, Person, and Student. The Person model was used as a base class for Instructor and Student.
View models were created for AssignedCourseData, EnrollmentDateGroup, and InstructorIndexData. Each model contains data annotations to specify parameters for 
each type of data and validate input for them.
