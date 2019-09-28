FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["AltenCustomersMS/AltenCustomersMS.csproj", "AltenCustomersMS/"]
RUN dotnet restore "AltenCustomersMS/AltenCustomersMS.csproj"
COPY . ./
WORKDIR "/src/AltenCustomersMS"
RUN dotnet build "AltenCustomersMS.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "AltenCustomersMS.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "AltenCustomersMS.dll"]