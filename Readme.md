# FullStack-2

## Pre-Requisitos

Añadir cadena de conexion a la BD en el archivo appsettings.json (AutoresAPI/AutoresAPI.Api/appsettings.json)

Es necesario aplicar las migraciones de Entity Framework en BD usando el siguiente comando:
```
dotnet ef --startup-project ./AutoresAPI/AutoresAPI.csproj -p ./AutoresAPI.Data/AutoresAPI.Data.csproj database update
```
(Requiere Entity Framework Tools) 
```
Mas info: https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli
```