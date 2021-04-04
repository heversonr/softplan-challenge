#!/bin/bash

case $1 in
    api1)        cd api1 && dotnet Softplan.Challenge.Api1.dll ;;
    api2)        cd api2 && dotnet Softplan.Challenge.Api2.dll ;;
    debug)          /bin/bash ;;
    *)              echo "OPCAO NAO ENCONTRADA"
esac