# Client

Client applikationen är en Blazor WebAssembly applikation.

## Kör lokalt

Genom CLI navigera till /client och kör följande kommandon:

* ```docker build -t matveckan-client .```
* ```docker run -p 35104:80 matveckan-client``` eller ```docker run -d -p 35104:80 matveckan-client```