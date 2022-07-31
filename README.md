# AlkemyDisneyAPI
CHALLENGE BACKEND - C# .NET (API)



De acuerdo al Challenge estas son las actividades que se alcanzaron a realizar:

Requerimientos técnicos

1. Modelado de Base de Datos (50%  Se crearon las tablas y se realizó una relación entre la tabla Personajes y Género)

2. Autenticación de Usuarios (50%  Solo se creó el login(tabla UserInfo), una tabla que guarda información del usuario incluyendo su usuario y contraseña con el cual se realiza la autorización y recolección del token.  Pendiente el registro).

3. Listado de Personajes (Se utilizó un DTO de la clase PersonajesController y Automapper)
	La imagen solo se creó un campo string para guardar URL imagen
El listado deberá mostrar: Imagen. Nombre.
El endpoint deberá ser: /characters

4. Creación, Edición y Eliminación de Personajes (CRUD)

5. NO

5. NO

7. Listado de Películas (Se utilizó un DTO de la clase PeliculasController y Automapper)
	La imagen solo se creó un campo string para guardar URL imagen
Deberá mostrar solamente los campos imagen, título y fecha de creación.
El endpoint deberá ser: ● GET /movies

8. NO

9. Creación, Edición y Eliminación de Película / Serie (CRUD)

10. NO

11. NO


POSTMAN:
https://martian-escape-893546.postman.co/workspace/Team-Workspace~9786e0b3-51c8-49a6-8285-43a81f48a07f/request/22043782-81598b07-87de-410e-9e57-50c636baa4cf

-------------------------------------------------------------------

Una breve descripción de los pasos seguidos:

1	Create ASP.NET Core Web API
2	Create folder "Model"
3	Inside de Model Create a Class:
	Personaje
	Película
	Genero
3.1	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema
3.2	create relational and foreign key (codefirst)
4	Install  Microsoft.EntityFrameworkCore.Design
5	Add Controller Class
	API Controller with actions, usin Entity Framework
	DisneyAPI.Data.DisneyAPIContext
6	Migration 
	In Package Manager Console :
	add-migration DisneyAPIData
	update-database


Automapper

/**************************
Pruebas Con Swagger
Pruebas Con POSTMAN
**************************/

7	Configuration, security whith JWT
7.1	Microsoft.AspNetCore.Authentication.JwtBearer



