FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /app

copy *.csproj ./
run dotnet restore

copy ./ ./
run dotnet publish -c Release -o out

From mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT ["dotnet", "WebApplication1.dll"]
