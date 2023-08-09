## Dependency

- .NET 5 Runtime

## Usage

```yaml
version: "2.4"
services:
  web:
    image: ghcr.io/exit-path/server
    restart: always
    environment:
      AllowedOrigins__0: https://exit-path.github.io
      Multiplayer__Auth__TokenSecret: SECRET # replace this
```
or edit appsettings.json

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "AllowedHosts": "*",
  "Multiplayer": {
    "Auth": {
      "Authority": "exit-path",
      "TokenSecret": "REPLACE THIS WITH TOKEN OF 32 CHARACTERS IN LENGTH"
    }
  },
  "AllowedOrigins": {
    "0": "REPLACE THIS WITH FRONT END ADDRESS EG HTTP://LOCALHOST:8080"
  }
}
```
