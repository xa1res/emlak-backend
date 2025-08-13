FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

COPY ["emlak-backend.sln", "."]
COPY ["emlak-backend/emlak-backend.csproj", "emlak-backend/"]
COPY ["emlak-backend/PentaNest.Emlak.Api/PentaNest.Emlak.Api.csproj", "emlak-backend/PentaNest.Emlak.Api/"]

RUN dotnet restore "emlak-backend.sln"

COPY . .

WORKDIR "/src/emlak-backend"
RUN dotnet publish "emlak-backend.csproj" -c Release -o /app/publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS final
WORKDIR /app

COPY --from=build /app/publish .

EXPOSE 80
EXPOSE 443

ENTRYPOINT ["dotnet", "emlak-backend.dll"]