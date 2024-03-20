FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["dPosit.PrimeTrust.Worker/dPosit.PrimeTrust.Worker.csproj", "dPosit.PrimeTrust.Worker/"]
RUN dotnet restore "dPosit.PrimeTrust.Worker/dPosit.PrimeTrust.Worker.csproj"
COPY . .
WORKDIR "/src/dPosit.PrimeTrust.Worker"
RUN dotnet build "dPosit.PrimeTrust.Worker.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "dPosit.PrimeTrust.Worker.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "dPosit.PrimeTrust.Worker.dll"]
