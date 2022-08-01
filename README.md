# Exercices of "Curso de Fundamentos de Entity Framework"

Check "Curso de Fundamentos de Entity Framework" in https://platzi.com/cursos/entity-framework/

## Course resume

Discover Entity Framework, a modern ORM designed for .Net with a project to add to your portfolio. Make the connection to a database and create the models using the Fluent API.

- Create a .NET project with the Entity Framework.
- It uses the Fluent API to specify the configuration of the models.
- Learn what migrations are and add seed data to the project.
- Learn the elements of a CRUD to consume data with the Entity Framework

## Install

1. Install pre requirements:

- Net SDK
- Postgres server
- Postman

2. Configure project

- Modify appsettings.json to change postgress connection

3. Run project

```bash
$ dotnet restore
$ dotnet run
```

4. Import collection of postman from postman.json file and change baseURL param to current URL project
5. In postman call to /dbconnect (Ex. http://localhost:7233/dbconnect)
6. Using a postgresql client database
