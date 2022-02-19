# Matveckan

Matveckan är ett hobby projekt som jag har haft tankar om sedan Augusti 2020 då jag började min .NET utbildning. 

Tanken är att det ska bli en applikation som delvis fungerar som en digital receptbok, och delvis som en matplanerare. 

## Syfte

Syftet med applikationen är att jag försöker hålla nere matkostnaden som blir av att dagligen handla. Tanken är att man ska börja veckohandla, men problemet där är att varje vecka sitta och planera mat för en hel vecka. 

## Funktionallitet

Man ska kunna lägga till recept som man vet att alla i familjen äter, och därefter kunna slumpa fram recept baserat på dessa innan man handlar. Man ska få ut en inköpslista med de varor som behövs för att täåcka in hela veckans mat. 

## Utveckling

Tanken är att jobba med en <a href="https://swagger.io/resources/articles/adopting-an-api-first-approach/">Api-First </a> approach. Grunden till API:et bygger på en Api definition som utvecklas med <a href="https://swagger.io/specification/">OpenAPI</a>

## Projektet

Matveckan innehåller två projekt som ligger samlade i detta repository:

* <a href="https://github.com/Spuute/Matveckan/tree/main/src/api">api</a>
    * ASP.NET Core Web Api
* client
    * Blazor WebAssembly (wasm)
* <a href="https://github.com/Spuute/Matveckan/tree/main/src/api-definition">api-definition</a>
    * OpenAPI

## Hur man kör projektet

### Kör lint lokalt

Öppna CLI och cd:a till
```./src/api-definition``` och kör följande kommando:

* ```spectral lint .\matveckan.oas.yaml --ruleset ../../.spectral.yaml```