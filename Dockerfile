FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
WORKDIR /app

COPY *.csproj ./
RUN dotnet restore

COPY . .
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY --from=build-env /app/out .

#RUN apt-get update
#RUN apt-get install libicu-dev -y
ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false
#Run line below instead when run in heroku
# CMD ASPNETCORE_URLS=http://*:$PORT dotnet leetly.api.dll
ENTRYPOINT [ "dotnet", "test.dll" ]
