# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy project files
COPY Backend/Backend.csproj Backend/
COPY NETReact.Shared/NETReact.Shared.csproj NETReact.Shared/
COPY NETReact.sln ./

# Restore dependencies
RUN dotnet restore Backend/Backend.csproj

# Copy all source
COPY Backend/ Backend/
COPY NETReact.Shared/ NETReact.Shared/

# Build and publish
WORKDIR /src/Backend
RUN dotnet publish -c Release -o /app

# Runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app .
ENTRYPOINT ["dotnet", "Backend.dll"]
