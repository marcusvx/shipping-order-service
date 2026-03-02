FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["ShippingOrderService.Web/ShippingOrderService.Web.csproj", "ShippingOrderService.Web/"]
RUN dotnet restore "ShippingOrderService.Web/ShippingOrderService.Web.csproj"
COPY . .
WORKDIR "/src/ShippingOrderService.Web"
RUN dotnet build "./ShippingOrderService.Web.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./ShippingOrderService.Web.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ShippingOrderService.Web.dll"]
