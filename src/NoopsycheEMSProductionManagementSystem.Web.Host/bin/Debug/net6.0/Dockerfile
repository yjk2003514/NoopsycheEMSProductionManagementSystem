#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/NoopsycheEMSProductionManagementSystem.Web.Host/NoopsycheEMSProductionManagementSystem.Web.Host.csproj", "src/NoopsycheEMSProductionManagementSystem.Web.Host/"]
COPY ["src/NoopsycheEMSProductionManagementSystem.Web.Core/NoopsycheEMSProductionManagementSystem.Web.Core.csproj", "src/NoopsycheEMSProductionManagementSystem.Web.Core/"]
COPY ["src/NoopsycheEMSProductionManagementSystem.Application/NoopsycheEMSProductionManagementSystem.Application.csproj", "src/NoopsycheEMSProductionManagementSystem.Application/"]
COPY ["src/NoopsycheEMSProductionManagementSystem.Core/NoopsycheEMSProductionManagementSystem.Core.csproj", "src/NoopsycheEMSProductionManagementSystem.Core/"]
COPY ["src/NoopsycheEMSProductionManagementSystem.EntityFrameworkCore/NoopsycheEMSProductionManagementSystem.EntityFrameworkCore.csproj", "src/NoopsycheEMSProductionManagementSystem.EntityFrameworkCore/"]
RUN dotnet restore "src/NoopsycheEMSProductionManagementSystem.Web.Host/NoopsycheEMSProductionManagementSystem.Web.Host.csproj"
COPY . .
WORKDIR "/src/src/NoopsycheEMSProductionManagementSystem.Web.Host"
RUN dotnet build "NoopsycheEMSProductionManagementSystem.Web.Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "NoopsycheEMSProductionManagementSystem.Web.Host.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
EXPOSE 5000
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "NoopsycheEMSProductionManagementSystem.Web.Host.dll"]