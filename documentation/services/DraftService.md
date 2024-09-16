# DraftService

A list of all methods in the `DraftService` service. Click on the method name to view detailed information about that method.

| Methods                                               | Description                 |
| :---------------------------------------------------- | :-------------------------- |
| [GetDraftInformationAsync](#getdraftinformationasync) | Retrieve draft information. |

## GetDraftInformationAsync

Retrieve draft information.

- HTTP Method: `GET`
- Endpoint: `/{lang}/draft`

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

var response = await client.Draft.GetDraftInformationAsync("lang");

Console.WriteLine(response);
```
