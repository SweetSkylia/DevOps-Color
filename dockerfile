# Utilisez l'image de base contenant le SDK .NET pour créer l'application
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env

# Définir le répertoire de travail dans le conteneur
WORKDIR /app

# Copier le fichier csproj et restaurer les dépendances
COPY ./DevOps-Color/DevOps-Color.csproj ./
RUN dotnet restore 

# Copier tout le reste et construire l'application
COPY . ./
RUN dotnet publish -c Release -o out

# Utilisez une image légère de l'exécution .NET pour exécuter l'application
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "DevOps-Color.dll"]