# ------- Build stage -------
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# Copiamos toda la solución
COPY . .

# Restaura TODA la solución (evita descargas paralelas que a veces fallan en CI)
RUN dotnet restore ./RanchMasterWebApp.sln --disable-parallel

# 👉 Paso extra para ver errores con más detalle antes del publish
RUN dotnet build ./Presentation/Presentation.csproj -c Release --no-restore -v detailed

# Publica sin restaurar de nuevo
RUN dotnet publish ./Presentation/Presentation.csproj -c Release -o /app/publish --no-restore -v detailed

# ------- Runtime stage -------
FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app

COPY --from=build /app/publish .

ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080

ENTRYPOINT ["dotnet", "Presentation.dll"]
