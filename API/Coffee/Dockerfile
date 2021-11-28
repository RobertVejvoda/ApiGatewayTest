FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src

COPY ["API/Coffee/CoffeeAPI.csproj", "API/Coffee/"]
RUN dotnet restore "API/Coffee/CoffeeAPI.csproj"

COPY . .
WORKDIR "/src/API/Coffee"
RUN dotnet build "CoffeeAPI.csproj" -c Release -o /app/build

FROM build as publish
RUN dotnet publish "CoffeeAPI.csproj" -c Release -o /app/publish

FROM base as final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CoffeeAPI.dll"]