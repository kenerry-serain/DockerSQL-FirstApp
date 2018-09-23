FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY *.sln ./
COPY Source/Application/DockerSQL.Application.WebAPI/DockerSQL.Application.WebAPI.csproj Source/Application/DockerSQL.Application.WebAPI/
RUN dotnet restore
COPY . .
WORKDIR /src/Source/Application/DockerSQL.Application.WebAPI
RUN dotnet build -c Release -o /app

FROM build AS publish
RUN dotnet publish -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "DockerSQL.Application.WebAPI.dll"]
