FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
RUN apt-get update
RUN apt-get install -y curl
RUN curl -sSLf https://get.tuna.am | sh
RUN tuna config save-token tt_3qfouz27rj9e92oszpf69ermf1pqf435
USER $APP_UIDs
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["CHSMonitoring.API/CHSMonitoring.API.csproj", "CHSMonitoring.API/"]
COPY ["CHSMonitoring.Application/CHSMonitoring.Application.csproj", "CHSMonitoring.Application/"]
COPY ["CHSMonitoring.Infrastructure/CHSMonitoring.Infrastructure.csproj", "CHSMonitoring.Infrastructure/"]
COPY ["CHSMonitoring.Domain/CHSMonitoring.Domain.csproj", "CHSMonitoring.Domain/"]
COPY ["Shared/Shared.csproj", "Shared/"]
RUN dotnet restore "CHSMonitoring.API/CHSMonitoring.API.csproj"
COPY . .
WORKDIR "/src/CHSMonitoring.API"
RUN dotnet build "CHSMonitoring.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "CHSMonitoring.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CHSMonitoring.API.dll"]
