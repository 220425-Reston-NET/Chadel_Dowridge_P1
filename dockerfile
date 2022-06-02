# #
# #
# #
# from mcr.microsoft.com/dotnet/sdk:6.0 as build

# #
# workdir /app

# ##
# copy *.sln ./
# copy SneakerApi/*.csproj SneakerApi/
# copy StoreBL/*.csproj StoreBL/
# copy StoreDL/*.csproj StoreDL/
# copy StoreModel/*.csproj StoreModel/

# #
# copy . ./

# #
# run dotnet build

# #
# run dotnet publish -c Release -o publish

# #
# #
# #

# #
from mcr.microsoft.com/dotnet/aspnet:6.0 as runtime

workdir /app

copy /publish ./

#
entrypoint ["dotnet", "SneakerApi.dll"]

#Change port to 5000
expose 5000

#We need to change our ASP.Net apllication to also start listening to 5000
env ASPNETCORE_URLS=http://+:5000