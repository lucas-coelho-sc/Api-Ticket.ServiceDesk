#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["Api.Ticket.Smartphone/Api.Ticket.Smartphone.csproj", "Api.Ticket.Smartphone/"]
RUN dotnet restore "Api.Ticket.Smartphone/Api.Ticket.Smartphone.csproj"
COPY . .
WORKDIR "/src/Api.Ticket.Smartphone"
RUN dotnet build "Api.Ticket.Smartphone.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Api.Ticket.Smartphone.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Api.Ticket.Smartphone.dll"]