FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY *.sln ./
COPY VoicesWebApp/*.csproj VoicesWebApp/
COPY VoicesDomain/*.csproj VoicesDomain/ 
COPY VoicesDataAccess/*.csproj VoicesDataAccess/ 
COPY VoicesTest/*.csproj VoicesTest/
RUN dotnet restore

# Copy everything else and build
COPY . ./
RUN dotnet publish VoicesWebApp -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "VoicesWebApp.dll"]