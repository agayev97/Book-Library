# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY ["BookLibrary.Api/BookLibrary.Api.csproj", "BookLibrary.Api/"]
COPY ["BookLibrary.Application/BookLibrary.Application.csproj", "BookLibrary.Application/"]
COPY ["BookLibrary.Domain/BookLibrary.Domain.csproj", "BookLibrary.Domain/"]
COPY ["BookLibrary.Infrastructure/BookLibrary.Infrastructure.csproj", "BookLibrary.Infrastructure/"]

RUN dotnet restore "BookLibrary.Api/BookLibrary.Api.csproj"

COPY . .

WORKDIR "/src/BookLibrary.Api"
RUN dotnet publish -c Release -o /app/publish

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "BookLibrary.Api.dll"]
