# GameService

A list of all methods in the `GameService` service. Click on the method name to view detailed information about that method.

| Methods                                             | Description                 |
| :-------------------------------------------------- | :-------------------------- |
| [GetGameInformationAsync](#getgameinformationasync) | Retrieve game information.  |
| [GetGameMetadataAsync](#getgamemetadataasync)       | Retrieve metadata for game. |

## GetGameInformationAsync

Retrieve game information.

- HTTP Method: `GET`
- Endpoint: `/{lang}/game`

**Parameters**

| Name | Type   | Required | Description   |
| :--- | :----- | :------- | :------------ |
| lang | string | ✅       | Language code |

**Return Type**

`object`

**Example Usage Code Snippet**

```csharp
using NhlStats;

var client = new NhlStatsClient();

var response = await client.Game.GetGameInformationAsync("lang");

Console.WriteLine(response);
```

## GetGameMetadataAsync

Retrieve metadata for game.

- HTTP Method: `GET`
- Endpoint: `/{lang}/game/meta`

**Parameters**

| Name | Type   | Required | Description   |
| :--- | :----- | :------- | :------------ |
| lang | string | ✅       | Language code |

**Return Type**

`object`

**Example Usage Code Snippet**

```csharp
using NhlStats;

var client = new NhlStatsClient();

var response = await client.Game.GetGameMetadataAsync("lang");

Console.WriteLine(response);
```
