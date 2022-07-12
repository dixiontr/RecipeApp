FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["RecipeApp.RecipeService/RecipeApp.RecipeService.csproj", "RecipeApp.RecipeService/"]
RUN dotnet restore "RecipeApp.RecipeService/RecipeApp.RecipeService.csproj"
COPY . .
WORKDIR "/src/RecipeApp.RecipeService"
RUN dotnet build "RecipeApp.RecipeService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RecipeApp.RecipeService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RecipeApp.RecipeService.dll"]
