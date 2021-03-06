# CoolApi
ASP.NET Core API with Entity Framework Core and MSSQL Database

# Agenda
1. Create ASP.NET Core API
2. Add migration and create database with Entity Framework Core 
3. What is Swagger and Implementation

# API
| API | Description | Request body | Response body |
| --- | --- | --- | --- |
| GET /api/student | Get all students | None | Array of all students |
| GET /api/Student/getbyid/{id} | Get student by id | id | Array of one Student |
| POST /api/Student | Create Student | firstname,lastName,county | Array of the created student |
| PUT /api/Student | Update Student data | id,firstname,lastName,county | Array of the updated student |
| DELETE /api/Student | Delete Student data | id | response message |


# Swagger
Swagger takes the manual work out of API documentation, with a range of solutions for generating, visualizing, and maintaining API docs.
1. API https://localhost:port/swagger/index.html
