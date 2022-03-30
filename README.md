# Matveckan

Matveckan är ett hobby projekt som jag har haft tankar om sedan Augusti 2020 då jag började min .NET utbildning. 

Tanken är att det ska bli en applikation som delvis fungerar som en digital receptbok, och delvis som en matplanerare. 

## Syfte

Syftet med applikationen är att jag försöker hålla nere matkostnaden som blir av att dagligen handla. Tanken är att man ska börja veckohandla, men problemet där är att varje vecka sitta och planera mat för en hel vecka. 

## Funktionallitet

Man ska kunna lägga till recept som man vet att alla i familjen äter, och därefter kunna slumpa fram recept baserat på dessa innan man handlar. Man ska få ut en inköpslista med de varor som behövs för att täåcka in hela veckans mat. 

## Teknologier

I detta projekt används följande teknologier:

* ASP.NET Core
* Blazor WebAssembly
* OpenAPI

## Utveckling

Tanken är att jobba med en <a href="https://swagger.io/resources/articles/adopting-an-api-first-approach/">Api-First </a> approach. Grunden till API:et bygger på en Api definition som utvecklas med <a href="https://swagger.io/specification/">OpenAPI</a>

## Projektet

Matveckan innehåller tre projekt som ligger samlade i detta repository:

* <a href="https://github.com/Spuute/Matveckan/tree/main/src/api">API</a> - **ASP.NET Core Web Api**
    * ```docker build -t matveckan-api .```
    * ```docker run -p 35103:80 matveckan-api ``` eller ```docker run -d -p 35103:80 matveckan-api ```
* CLIENT - **Blazor WebAssembly (WASM)**
    * ```docker build -t matveckan-client .```
    * ```docker run -p 35104:80 matveckan-client``` eller ```docker run -d -p 35104:80 matveckan-client```
* <a href="https://github.com/Spuute/Matveckan/tree/main/src/api-definition">API-DEFINITION</a> -- **OpenAPI**
    * ```docker build -t prism-mock .```
    * ```docker run -p 35101:35101 prism-mock``` eller ```docker run -d -p 35101:35101```

## Lokal utveckling

För att starta upp hela systemet så finns det en docker-compose fil som ligger i ./src. Använd cli med följande kommandon:

* ```docker compose build``` - (första gången)
* ``` docker compose up ``` eller ```docker compose up -d```  (kör containern i bakgrunden)

### Portar

När hela projektet är uppe och kör så används följande portar:

* localhost:35100 - **Maria DB**
* localhost:35101 - **Prism Mock**
* localhost:35102 - **Api dokumentation med Swagger**
* localhost:35103 - **API**
* localhost:35104 - **Client**

### Kör lint lokalt

Öppna CLI och cd:a till
```./src/api-definition``` och kör följande kommando:

* ```spectral lint .\matveckan.oas.yaml --ruleset ../../.spectral.yaml```
