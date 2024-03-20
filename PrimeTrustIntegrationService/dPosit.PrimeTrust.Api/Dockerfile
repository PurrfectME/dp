#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["PrimeTrustIntegrationService/dPosit.PrimeTrust.Api/dPosit.PrimeTrust.Api.csproj", "PrimeTrustIntegrationService/dPosit.PrimeTrust.Api/"]
COPY ["PrimeTrustIntegrationService/dPosit.PrimeTrust.Sdk/dPosit.PrimeTrust.Sdk.csproj", "PrimeTrustIntegrationService/dPosit.PrimeTrust.Sdk/"]
COPY ["Shared/dPosit.Http/dPosit.Http.csproj", "Shared/dPosit.Http/"]
RUN dotnet restore "PrimeTrustIntegrationService/dPosit.PrimeTrust.Api/dPosit.PrimeTrust.Api.csproj"
COPY . .
WORKDIR "/src/PrimeTrustIntegrationService/dPosit.PrimeTrust.Api"
RUN dotnet build "dPosit.PrimeTrust.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "dPosit.PrimeTrust.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "dPosit.PrimeTrust.Api.dll"]