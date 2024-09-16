# PlayersService

A list of all methods in the `PlayersService` service. Click on the method name to view detailed information about that method.

| Methods                                                 | Description                                                                           |
| :------------------------------------------------------ | :------------------------------------------------------------------------------------ |
| [GetPlayerInformationAsync](#getplayerinformationasync) | Retrieve player information. Currently seems to return a truncated list with a total. |

## GetPlayerInformationAsync

Retrieve player information. Currently seems to return a truncated list with a total.

- HTTP Method: `GET`
- Endpoint: `/{lang}/players`

**Parameters**

| Name | Type   | Required | Description   |
| :--- | :----- | :------- | :------------ |
| lang | string | ✅       | Language code |

**Return Type**

`object`

**Example Usage Code Snippet**

```csharp
using NhlStatsClient;

var client = new NhlStatsClientClient();

var response = await client.Players.GetPlayerInformationAsync("lang");

Console.WriteLine(response);
```
