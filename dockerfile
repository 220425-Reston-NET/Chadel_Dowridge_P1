#
#
#
from mcr.microsoft.com/dotnet/sdk:6.0 as build

#
workdir /app

##
copy *.sln ./
copy SneakerApi/*.csproj SneakerApi/
copy StoreBL/*.csproj StoreBL/
copy StoreDL/*.csproj StoreDL/
copy StoreModel/*.csproj StoreModel/

#
copy . ./

#
run dotnet build

#
run dotnet publish -c Release -o publish

#
#
#

#
from mcr.microsoft.com/dotnet/aspnet:6.0 as runtime

workdir /app
copy --from=build /app/publish ./

#
cmd ["dotnet", "SneakerApi.dll"]

expose 80