FROM mcr.microsoft.com/dotnet/sdk:7.0.305 AS build-env
WORKDIR /App

COPY . ./
WORKDIR /App/src/WorldService
RUN dotnet restore
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:7.0.305
WORKDIR /App
COPY --from=build-env /App/src/WorldService/out .
ENTRYPOINT ["dotnet", "WorldService.dll"]
