# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /app

COPY ../src/WeatherService/*.csproj ./WeatherService/
RUN dotnet restore ./WeatherService/WeatherService.csproj

COPY ../src/WeatherService/. ./WeatherService/
WORKDIR /app/WeatherService
RUN dotnet publish -c Release -o out

# Stage 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS runtime
WORKDIR /app
COPY --from=build /app/WeatherService/out ./
ENTRYPOINT ["dotnet", "WeatherService.dll"]
