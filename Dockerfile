FROM mcr.microsoft.com/dotnet/sdk:6.0
WORKDIR /NUnitTestProject

COPY . ./

CMD ["dotnet", "test", "--no-restore"]
