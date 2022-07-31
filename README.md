# AlkemyDisneyAPI
CHALLENGE BACKEND - C# .NET (API)



De acuerdo al Challenge estas son las actividades que se alcanzaron a realizar:

Requerimientos técnicos

1. Modelado de Base de Datos (50%  Se crearon las tablas y se realizo una relacion entre la tabla Personajes y Genero)


2. Autenticación de Usuarios (50%  Solo se creo el login(tabla UserInfo), una tabla que guarda informacion del usuario incluyendo su usuario y contraseña con el cual se realiza la autorizacion y recoleccion del token.  Pendiente el registro).

3. Listado de Personajes (Se utilizo un DTO de la clase PersonajesController y Automapper)
	La imagen solo se creo un campo string para uardar URL imagen
El listado deberá mostrar: Imagen. Nombre.
El endpoint deberá ser: /characters

4. Creación, Edición y Eliminación de Personajes (CRUD)

5. NO

5. NO

7. Listado de Películas (Se utilizo un DTO de la clase PeliculasController y Automapper)
	La imagen solo se creo un campo string para uardar URL imagen
Deberá mostrar solamente los campos imagen, título y fecha de creación.
El endpoint deberá ser: ● GET /movies

8. NO

9. Creación, Edición y Eliminación de Película / Serie (CRUD)

10. NO

11. NO


-------------------------------------------------------------------

Una breve descripcion de los pasos seguidos:

1	Create ASP.NET Core Web API
2	Create folder "Model"
3	Inside de Model Create a Class:
	Personaje
	Pelicula
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





