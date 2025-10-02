# Use official .NET SDK image for build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy solution files
COPY ../Shared/Shared.csproj ./Shared/
COPY Backend.csproj ./Backend/

# Restore dependencies
RUN dotnet restore Backend.csproj

# Copy the rest of the code
COPY ../Shared ./Shared
COPY . ./Backend

WORKDIR /src/Backend
RUN dotnet publish -c Release -o /app

# Final image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app ./

ENTRYPOINT ["dotnet", "Backend.dll"]
