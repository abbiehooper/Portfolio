FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src
COPY AbbiePortfolio.csproj .
RUN dotnet restore AbbiePortfolio.csproj
COPY Program.cs .
COPY appsettings.json .
COPY appsettings.Development.json .
RUN dotnet publish AbbiePortfolio.csproj -c Release -o /app/publish --no-restore
FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app
COPY --from=build /app/publish .
RUN useradd -m -u 1001 appuser
USER appuser
EXPOSE 8080
ENV ASPNETCORE_URLS=http://+:8080

ENTRYPOINT ["dotnet", "AbbiePortfolio.dll"]