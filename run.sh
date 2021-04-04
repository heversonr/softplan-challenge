#!/bin/bash

case $1 in
    interest_rate_api)        cd interest_rate_api && dotnet Softplan.Challenge.InterestRate.Api.dll ;;
    interest_calculation_api)        cd interest_calculation_api && dotnet Softplan.Challenge.InterestCalculation.Api.dll ;;
    debug)          /bin/bash ;;
    *)              echo "OPCAO NAO ENCONTRADA"
esac