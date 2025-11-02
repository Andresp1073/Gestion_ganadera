# ------- Build stage -------
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# Copiamos toda la solución
COPY . .

# 🔹 Restaura TODAS las dependencias de la solución
RUN dotnet restore ./RanchMasterWebApp.sln --disable-parallel

# 🔹 Publica SOLO el proyecto Presentation (sin volver a restaurar)
RUN dotnet publish ./Presentation/Presentation.csproj -c Release -o /app/publish --no-restore

# ------- Runtime stage -------
FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app

# Copiamos el publish
COPY --from=build /app/publish .

# La app escuchará en 8080 dentro del contenedor
ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080

# Tu ensamblado final se llama Presentation.dll
ENTRYPOINT ["dotnet", "Presentation.dll"]
