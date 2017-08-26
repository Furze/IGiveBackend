FROM microsoft/dotnet:2.0-sdk
WORKDIR /build

ENV ASPNETCORE_URLS http://*:8000
EXPOSE 8000

# copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore

# copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out

WORKDIR /build/out/
ENTRYPOINT ["dotnet", "GiveAShitBackend.dll"]