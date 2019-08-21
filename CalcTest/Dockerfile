#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see http://aka.ms/containercompat 

FROM microsoft/dotnet:2.1-aspnetcore-runtime-nanoserver-sac2016 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk-nanoserver-sac2016 AS build
WORKDIR /src
COPY CalcTest/CalcTest.WebAPI.csproj CalcTest/
COPY CalcTest.Application/CalcTest.Application.csproj CalcTest.Application/
COPY CalcTest.Infraestructure/CalcTest.Infraestructure.csproj CalcTest.Infraestructure/
RUN dotnet restore CalcTest/CalcTest.WebAPI.csproj
COPY . .
WORKDIR /src/CalcTest
RUN dotnet build CalcTest.WebAPI.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish CalcTest.WebAPI.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "CalcTest.WebAPI.dll"]
