#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/NerdStore.WebApp.MVC/NerdStore.WebApp.MVC.csproj", "src/NerdStore.WebApp.MVC/"]
COPY ["src/NerdStore.Vendas.Domain/NerdStore.Vendas.Domain.csproj", "src/NerdStore.Vendas.Domain/"]
COPY ["src/NerdStore.Core/NerdStore.Core.csproj", "src/NerdStore.Core/"]
COPY ["src/NerdStore.Vendas.Data/NerdStore.Vendas.Data.csproj", "src/NerdStore.Vendas.Data/"]
COPY ["src/NerdStore.Pagamentos.Business/NerdStore.Pagamentos.Business.csproj", "src/NerdStore.Pagamentos.Business/"]
COPY ["src/NerdStore.Catologo.Domain/NerdStore.Catologo.Domain.csproj", "src/NerdStore.Catologo.Domain/"]
COPY ["src/NerdStore.Vendas.Application/NerdStore.Vendas.Application.csproj", "src/NerdStore.Vendas.Application/"]
COPY ["src/NerdStore.Catalogo.Data/NerdStore.Catalogo.Data.csproj", "src/NerdStore.Catalogo.Data/"]
COPY ["src/NerdStore.Catalogo.Application/NerdStore.Catalogo.Application.csproj", "src/NerdStore.Catalogo.Application/"]
COPY ["src/NerdStore.Pagamentos.Data/NerdStore.Pagamentos.Data.csproj", "src/NerdStore.Pagamentos.Data/"]
COPY ["src/NerdStore.Pagamentos.AntiCorruption/NerdStore.Pagamentos.AntiCorruption.csproj", "src/NerdStore.Pagamentos.AntiCorruption/"]
RUN dotnet restore "src/NerdStore.WebApp.MVC/NerdStore.WebApp.MVC.csproj"
COPY . .
WORKDIR "/src/src/NerdStore.WebApp.MVC"
RUN dotnet build "NerdStore.WebApp.MVC.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "NerdStore.WebApp.MVC.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "NerdStore.WebApp.MVC.dll"]
