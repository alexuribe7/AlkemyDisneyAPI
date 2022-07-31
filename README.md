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



Links que me ayudaron:

https://www.youtube.com/watch?v=8e-30LJb97g
https://bravedeveloper.com/2022/04/22/creando-un-api-restful-completo-con-net-core-para-un-sistema-crm-desde-cero-1-de-5/
https://bravedeveloper.com/2021/08/18/como-aplicar-seguridad-a-tu-api-mediante-json-web-token-jwt/
https://www.youtube.com/watch?v=fYDSqXfcF68
https://www.c-sharpcorner.com/article/how-to-implement-jwt-authentication-in-web-api-using-net-6-0-asp-net-core/
https://ardalis.com/web-api-dto-considerations/
https://www.entityframeworktutorial.net/code-first/configure-one-to-many-relationship-in-code-first.aspx#conventions-for-one-to-many-ef6


Packages:
  <PackageReference Include="AutoMapper.Extensions.Microsoft.DependencyInjection" Version="11.0.0" />
    <PackageReference Include="Microsoft.AspNetCore.Authentication.JwtBearer" Version="6.0.7" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.Design" Version="6.0.7">
      <PrivateAssets>all</PrivateAssets>
      <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
    </PackageReference>
    <PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="6.0.7" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="6.0.7">
      <PrivateAssets>all</PrivateAssets>
      <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
    </PackageReference>
    <PackageReference Include="Microsoft.VisualStudio.Web.CodeGeneration.Design" Version="6.0.7" />
    <PackageReference Include="Swashbuckle.AspNetCore" Version="6.3.0" />
    <PackageReference Include="System.ComponentModel.Annotations" Version="5.0.0" />




