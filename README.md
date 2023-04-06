# Basic CRUD RestAPI built on .Net SDK 6.0.407

Very basic MVC CRUD API using users. Database not connected to a SQL Server and must be run locally on http://localhost:4000

See functionality on Postman: https://youtu.be/a3tcyUCBQ9c

### Project Structure

- Controllers: 
Defines the endpoints for the web application. Very similar to Ruby on Rails backend.

- Models:
Define paramaters for incoming requests.
In this case, we have CreateRequest.cs, which gives us the validations for a POST request to "/users," telling us what we can include in our request and what we can't. We also have UpdateRequest.cs, which works very similarly to CreateRequest.cs, but in the case of a PUT request to "/users/{:id}"

- Services:
UserServices.cs contains the brunt of the logic behind what the routes in the controller actually do. Responsible
for all database interaction and, in this case, every operation.

- Entities:
Represent application data stored in the database. Organized similarly to a schema in ruby on rails.

- Helpers
Bunch of miscellaneous files designed for error handling. Crafted from many different tutorials.


### Backend API Endpoints

| Method | Endpoint          | Params                | Description                                          |
| ------ | ----------------- | --------------------- | ---------------------------------------------------- |
| GET    | /users            |                       | returns JSON formatted list of all users             |
| GET    | /users/{:id}      |                       | returns JSON formatted list of user with said id     |
| POST   | /users            |                       | creates a new user profile                           |
|        |                   | title                 | user title                                           |
|        |                   | firstName             | user name                                            |
|        |                   | lastName              | user name                                            |
|        |                   | email                 | user email                                           |
|        |                   | role                  | user role (admin or user)                            |
|        |                   | password              | user password                                        |
|        |                   | password_confirmation | user password confirmation                           |
| PUT    | /users/{:id}      |                       | updates a user with info                             |
|        |                   | title                 | user title                                           |
|        |                   | firstName             | user name                                            |
|        |                   | lastName              | user name                                            |
|        |                   | email                 | user email                                           |
|        |                   | role                  | user role (admin or user)                            |
|        |                   | password              | user password                                        |
|        |                   | password_confirmation | user password confirmation                           |
| DELETE | /users/{:id}      |                       | deletes a user with given id                         |

### Additional Features
- Separate "Role entity" that acts to distinguish a user role from just a string. /Entities/Role.cs
- Bcrypt password hashing (https://code-maze.com/dotnet-secure-passwords-bcrypt/)
- Custom error handling and messages (https://learn.microsoft.com/en-us/aspnet/core/fundamentals/error-handling?view=aspnetcore-7.0)
- Validation for attributes like passwords, roles, etc. (https://learn.microsoft.com/en-us/aspnet/core/fundamentals/error-handling?view=aspnetcore-7.0)






