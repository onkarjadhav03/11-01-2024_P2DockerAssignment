#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["MovieAsgn5/MovieAsgn5.csproj", "MovieAsgn5/"]
RUN dotnet restore "MovieAsgn5/MovieAsgn5.csproj"
COPY . .
WORKDIR "/src/MovieAsgn5"
RUN dotnet build "MovieAsgn5.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MovieAsgn5.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MovieAsgn5.dll"]