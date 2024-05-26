FROM mcr.microsoft.com/dotnet/sdk:6.0
WORKDIR /NUnitTestProject

COPY . ./

RUN dotnet restore
RUN dotnet build

CMD ["dotnet", "test", "--no-restore"]
