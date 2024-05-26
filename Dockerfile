FROM mcr.microsoft.com/dotnet/sdk:6.0
WORKDIR /tests

COPY . ./

CMD ["dotnet", "test", "--no-restore"]
