
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /app


# Copy everything else and build
COPY . ./
RUN dotnet restore Softplan.Challenge.sln
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY --from=build /app/out ./interest_rate_api
COPY --from=build /app/out ./interest_calculation_api
COPY --from=build /app/run.sh .
ENTRYPOINT ["./run.sh"]
