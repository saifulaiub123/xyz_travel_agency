#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["TA.Api/TA.Api.csproj", "TA.Api/"]
COPY ["TA.Infrastructure/TA.Infrastructure.csproj", "TA.Infrastructure/"]
COPY ["TA.Domain/TA.Domain.csproj", "TA.Domain/"]
COPY ["TA.Application/TA.Application.csproj", "TA.Application/"]
COPY ["Framework/Logistic.Framework.csproj", "Framework/"]
COPY ["Logistic.Service/Logistic.Service.csproj", "Logistic.Service/"]
RUN dotnet restore "TA.Api/TA.Api.csproj"
COPY . .
WORKDIR "/src/TA.Api"
RUN dotnet build "TA.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TA.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TA.Api.dll"]