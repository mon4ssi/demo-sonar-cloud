dotnet sonarscanner begin /o:"mon4ssi" /k:"mon4ssi_demo-sonar-cloud" /d:sonar.host.url="https://sonarcloud.io" /d:sonar.token="2a4e04299097c71e2f0f00097f462a0566e8990a"

dotnet build

dotnet sonarscanner end /d:sonar.token="2a4e04299097c71e2f0f00097f462a0566e8990a"
