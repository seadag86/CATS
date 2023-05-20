FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["CATS.Web/CATS.Web.csproj", "CATS.Web/"]
RUN dotnet restore "CATS.Web/CATS.Web.csproj"
COPY . .
WORKDIR "/src/CATS.Web"
RUN dotnet build "CATS.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CATS.Web.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CATS.Web.dll"]
