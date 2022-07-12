FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["RecipeApp.DataFetch/RecipeApp.DataFetch.csproj", "RecipeApp.DataFetch/"]
RUN dotnet restore "RecipeApp.DataFetch/RecipeApp.DataFetch.csproj"
COPY . .
WORKDIR "/src/RecipeApp.DataFetch"
RUN dotnet build "RecipeApp.DataFetch.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RecipeApp.DataFetch.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RecipeApp.DataFetch.dll"]
