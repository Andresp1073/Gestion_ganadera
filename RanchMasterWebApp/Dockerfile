# ------- Build stage -------
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# Copiamos la solución y restauramos todo
COPY . .
RUN dotnet restore RanchMasterWebApp.sln

# Compilamos en Release
RUN dotnet build RanchMasterWebApp.sln -c Release --no-restore

# Publicamos solo Presentation
RUN dotnet publish ./Presentation/Presentation.csproj -c Release -o /app/publish --no-restore --no-build

# ------- Runtime stage -------
FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app
COPY --from=build /app/publish .
ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080
ENTRYPOINT ["dotnet", "Presentation.dll"]
