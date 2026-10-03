# Solución Login

Login en C# Windows Forms (.NET Framework 4.8) contra SQL Server.
Valida usuario y contraseña contra la tabla `usuario` con consultas parametrizadas.

## Requisitos

- Windows y .NET Framework 4.8
- SQL Server con la base `bd_usuario` (tabla `usuario`: `usuario`, `contrasena`, `activo`)
- Visual Studio 2022

## Abrir

Abrí `Solucion_Login.slnx` en Visual Studio y ejecutá. Visual Studio restaura solo
los paquetes de `packages.config`. La conexión apunta a `localhost` con
`Integrated Security=True`, sin usuario ni contraseña.

Nota: no compila con `dotnet build` porque el proyecto tiene un recurso no textual
(`pictureBox1.Image`) que requiere el MSBuild de Visual Studio.
