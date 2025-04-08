# Etapa de build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# .csproj primero
COPY GeneradoresYPruebas.Api/*.csproj ./GeneradoresYPruebas.Api/
COPY GeneradoresYPruebas.Dominio/*.csproj ./GeneradoresYPruebas.Dominio/


# restaurar las dependencias
RUN dotnet restore ./GeneradoresYPruebas.Api/GeneradoresYPruebas.Api.csproj

# resto del código
COPY GeneradoresYPruebas.Api ./GeneradoresYPruebas.Api
COPY GeneradoresYPruebas.Dominio ./GeneradoresYPruebas.Dominio

# compilar
WORKDIR /src/GeneradoresYPruebas.Api
RUN dotnet publish -c Release -o /app/publish

# runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "GeneradoresYPruebas.Api.dll"]
