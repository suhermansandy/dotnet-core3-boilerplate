#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Moonlay.MasterData.ApiGrpc/Moonlay.MasterData.ApiGrpc.csproj", "Moonlay.MasterData.ApiGrpc/"]
COPY ["Moonlay.MasterData.Topics/Moonlay.MasterData.Topics.csproj", "Moonlay.MasterData.Topics/"]
COPY ["Moonlay.MasterData.Domain/Moonlay.MasterData.Domain.csproj", "Moonlay.MasterData.Domain/"]
COPY ["Moonlay.Core.Models/Moonlay.Core.Models.csproj", "Moonlay.Core.Models/"]
COPY ["Moonlay.Confluent.Kafka/Moonlay.Confluent.Kafka.csproj", "Moonlay.Confluent.Kafka/"]
RUN dotnet restore "Moonlay.MasterData.ApiGrpc/Moonlay.MasterData.ApiGrpc.csproj"
COPY . .
WORKDIR "/src/Moonlay.MasterData.ApiGrpc"
RUN dotnet build "Moonlay.MasterData.ApiGrpc.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Moonlay.MasterData.ApiGrpc.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Moonlay.MasterData.ApiGrpc.dll"]