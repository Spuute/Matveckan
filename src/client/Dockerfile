FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY client.csproj .
RUN dotnet restore client.csproj
COPY . .
RUN dotnet build client.csproj -c Release -o /app/build

FROM build AS publish
RUN dotnet publish client.csproj -c Release -o /app/publish

FROM nginx:alpine AS final
WORKDIR /usr/share/nginx/html
COPY --from=publish /app/publish/wwwroot .
COPY nginx.conf /etc/nginx/nginx.conf