# SkatersService

A list of all methods in the `SkatersService` service. Click on the method name to view detailed information about that method.

| Methods                                                 | Description                                       |
| :------------------------------------------------------ | :------------------------------------------------ |
| [GetSkaterLeadersAsync](#getskaterleadersasync)         | Retrieve skater leaders for a specific attribute. |
| [GetSkaterMilestonesAsync](#getskatermilestonesasync)   | Retrieve skater milestones.                       |
| [GetSkaterInformationAsync](#getskaterinformationasync) | Retrieve skater information.                      |
| [GetSkaterStatsAsync](#getskaterstatsasync)             | Retrieve skater stats for a specific report.      |

## GetSkaterLeadersAsync

Retrieve skater leaders for a specific attribute.

- HTTP Method: `GET`
- Endpoint: `/{lang}/leaders/skaters/{attribute}`

**Parameters**

| Name      | Type   | Required | Description      |
| :-------- | :----- | :------- | :--------------- |
| attribute | string | ✅       | Skater attribute |
| lang      | string | ✅       | Language code    |

**Return Type**

`object`

**Example Usage Code Snippet**

```csharp
using NhlStatsClient;

var client = new NhlStatsClientClient();

var response = await client.Skaters.GetSkaterLeadersAsync("attribute", "lang");

Console.WriteLine(response);
```

## GetSkaterMilestonesAsync

Retrieve skater milestones.

- HTTP Method: `GET`
- Endpoint: `/{lang}/milestones/skaters`

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

var response = await client.Skaters.GetSkaterMilestonesAsync("lang");

Console.WriteLine(response);
```

## GetSkaterInformationAsync

Retrieve skater information.

- HTTP Method: `GET`
- Endpoint: `/{lang}/skater`

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

var response = await client.Skaters.GetSkaterInformationAsync("lang");

Console.WriteLine(response);
```

## GetSkaterStatsAsync

Retrieve skater stats for a specific report.

- HTTP Method: `GET`
- Endpoint: `/{lang}/skater/{report}`

**Parameters**

| Name           | Type   | Required | Description                                            |
| :------------- | :----- | :------- | :----------------------------------------------------- |
| report         | string | ✅       | Skater report                                          |
| lang           | string | ✅       | Language code                                          |
| cayenneExp     | string | ✅       | Required                                               |
| isAggregate    | bool   | ❌       | Optional                                               |
| isGame         | bool   | ❌       | Optional                                               |
| factCayenneExp | string | ❌       | Optional                                               |
| include        | string | ❌       | Optional                                               |
| exclude        | string | ❌       | Optional                                               |
| sort           | string | ❌       | Optional                                               |
| dir            | string | ❌       | Optional                                               |
| start          | long   | ❌       | Optional                                               |
| limit          | long   | ❌       | Optional (Note: a limit of -1 will return all results) |

**Return Type**

`object`

**Example Usage Code Snippet**

```csharp
using NhlStatsClient;

var client = new NhlStatsClientClient();

var response = await client.Skaters.GetSkaterStatsAsync("report", "lang", "cayenneExp", true, false, "factCayenneExp", "include", "exclude", "sort", "dir", 9, 8);

Console.WriteLine(response);
```
