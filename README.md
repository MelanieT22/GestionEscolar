# Sistema de Gestión Escolar - ASP.NET Core MVC

Proyecto desarrollado para la evaluación formativa aplicando el patrón MVC, Entity Framework Core y SQL Server.

## Desarrollador
- **Estudiante:** Melanie Abigail Talavera Castillo
- **Entidades implementadas:** Estudiante, Maestro, Aula, Libro.

## Requisitos 
- Visual Studio Code / .NET 10 SDK
- SQL Server 2025 Express (`localhost\SQLEXPRESS`)
- SQL Server Management Studio (SSMS 22)

## Pasos para ejecutar el proyecto
1. Clonar el repositorio de GitHub.
2. Verificar la cadena de conexión en `appsettings.json`.
3. Aplicar las migraciones a la base de datos:
   powershell
   dotnet ef database update
