# Basic CRUD RestAPI built on .Net SDK 6.0.407

Very basic MVC CRUD API using users. Database not connected to a SQL Server and must be run locally on http://localhost:4000

Project Structure:

- Controllers: 
Defines the endpoints for the web application. Very similar to Ruby on Rails backend.

-Models:
Define paramaters for incoming requests.
In this case, we have CreateRequest.cs, which gives us the validations for a POST request to "/users," telling us what we can include in our request and what we can't.

We also have UpdateRequest.cs, which works very similarly to CreateRequest.cs, but in the case of a PUT request to "/users/{:id}"

-Services:
UserServices.cs contains the brunt of the logic behind what the routes in the controller actually do. Responsibl
for all database interaction and, in this case, every operation.

-Entities:
Represent application data stored in the database. Organized similarly to a schema in ruby on rails.

-Helpers
Bunch of miscellaneous files designed for error handling. Crafted from many different tutorials.

ACTUAL ROUTES:





