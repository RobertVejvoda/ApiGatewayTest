FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src

COPY ["API/Tea/TeaAPI.csproj", "API/Tea/"]
RUN dotnet restore "API/Tea/TeaAPI.csproj"

COPY . .
WORKDIR "/src/API/Tea"
RUN dotnet build "TeaAPI.csproj" -c Release -o /app/build

FROM build as publish
RUN dotnet publish "TeaAPI.csproj" -c Release -o /app/publish

FROM base as final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TeaAPI.dll"]