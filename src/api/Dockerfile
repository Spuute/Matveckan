FROM mcr.microsoft.com/dotnet/sdk:6.0-alpine AS build-env
WORKDIR /src
COPY . .
RUN dotnet restore
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:6.0-alpine
WORKDIR /src
COPY --from=build-env /src/out .
# ENV ASPNETCORE_URLS=http://127.0.0.1:4001
# ENV ASPNETCORE_ENVIRONMENT Development
ENTRYPOINT [ "dotnet", "api.dll" ]
