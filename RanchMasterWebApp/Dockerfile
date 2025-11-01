# ------- Build stage -------
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# Copiamos toda la solución
COPY . .

# Restaura y publica SOLO el proyecto Presentation (restaura refs transitivas)
RUN dotnet restore ./Presentation/Presentation.csproj
RUN dotnet publish ./Presentation/Presentation.csproj -c Release -o /app/publish

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
