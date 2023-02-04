FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["am20001382 Project/am20001382 Project.csproj", "am20001382 Project/"]
RUN dotnet restore "am20001382 Project/am20001382 Project.csproj"
COPY . .
WORKDIR "/src/am20001382 Project"
RUN dotnet build "am20001382 Project.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "am20001382 Project.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "am20001382 Project.dll"]
