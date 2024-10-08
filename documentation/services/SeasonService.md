# SeasonService

A list of all methods in the `SeasonService` service. Click on the method name to view detailed information about that method.

| Methods                                                 | Description                            |
| :------------------------------------------------------ | :------------------------------------- |
| [GetComponentSeasonAsync](#getcomponentseasonasync)     | Retrieve component season information. |
| [GetSeasonInformationAsync](#getseasoninformationasync) | Retrieve season information.           |

## GetComponentSeasonAsync

Retrieve component season information.

- HTTP Method: `GET`
- Endpoint: `/{lang}/componentSeason`

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

var response = await client.Season.GetComponentSeasonAsync("lang");

Console.WriteLine(response);
```

## GetSeasonInformationAsync

Retrieve season information.

- HTTP Method: `GET`
- Endpoint: `/{lang}/season`

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

var response = await client.Season.GetSeasonInformationAsync("lang");

Console.WriteLine(response);
```
