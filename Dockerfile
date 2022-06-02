#
from mcr.microsoft.com/dotnet/aspnet:6.0 as runtime

workdir /app

#
copy /publish ./

#
entrypoint ["dotnet", "SneakerApi.dll"]

#Change port to 5000
expose 5000

#We need to change our ASP.Net apllication to also start listening to 5000
env ASPNETCORE_URLS=http://+:5000
