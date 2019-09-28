FROM microsoft/dotnet:2.2-runtime AS base
WORKDIR /app

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY VehiclesPingSimulator/VehiclesPingSimulator.csproj VehiclesPingSimulator/
RUN dotnet restore VehiclesPingSimulator/VehiclesPingSimulator.csproj
COPY . .
WORKDIR /src/VehiclesPingSimulator
RUN dotnet build VehiclesPingSimulator.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish VehiclesPingSimulator.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "VehiclesPingSimulator.dll"]
