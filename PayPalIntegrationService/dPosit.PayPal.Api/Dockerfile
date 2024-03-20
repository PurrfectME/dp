FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["PayPalIntegrationService/dPosit.PayPal.Api/dPosit.PayPal.Api.csproj", "PayPalIntegrationService/dPosit.PayPal.Api/"]
COPY ["PayPalIntegrationService/dPosit.PayPal.Sdk/dPosit.PayPal.Sdk.csproj", "PayPalIntegrationService/dPosit.PayPal.Sdk/"]
COPY ["Shared/dPosit.Http/dPosit.Http.csproj", "Shared/dPosit.Http/"]
COPY ["Shared/dPosit.AspNet.Helpers/dPosit.AspNet.Helpers.csproj", "Shared/dPosit.AspNet.Helpers/"]

RUN dotnet restore "PayPalIntegrationService/dPosit.PayPal.Api/dPosit.PayPal.Api.csproj"
COPY . .
WORKDIR "/src/PayPalIntegrationService/dPosit.PayPal.Api"
RUN dotnet build "dPosit.PayPal.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "dPosit.PayPal.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "dPosit.PayPal.Api.dll"]
