# NhlStats C# SDK 1.0.0

Welcome to the NhlStats SDK documentation. This guide will help you get started with integrating and using the NhlStats SDK in your project.

## Versions

- API version: `1.0.0`
- SDK version: `1.0.0`

## About the API

This section provides documentation for the NHL Stats API. Based on the unofficial documentation https://github.com/Zmalski/NHL-API-Reference

## Table of Contents

- [Setup & Configuration](#setup--configuration)
  - [Supported Language Versions](#supported-language-versions)
  - [Installation](#installation)
- [Sample Usage](#sample-usage)
- [Services](#services)
- [Models](#models)
- [License](#license)

# Setup & Configuration

## Supported Language Versions

This SDK is compatible with the following versions: `C# >= .NET 6`

## Installation

To get started with the SDK, we recommend installing using `nuget`:

```bash
dotnet add package NhlStats
```

# Sample Usage

Below is a comprehensive example demonstrating how to authenticate and call a simple endpoint:

```cs
using NhlStats;
using NhlStats.Config;
using Environment = NhlStats.Http.Environment;

var config = new NhlStatsConfig
{
  Environment = Environment.Default
};

var client = new NhlStatsClient(config);

var response = await client.Miscellaneous.PingServerAsync();

Console.WriteLine(response);

```

## Services

The SDK provides various services to interact with the API.

<details> 
<summary>Below is a list of all available services with links to their detailed documentation:</summary>

| Name                                                                   |
| :--------------------------------------------------------------------- |
| [PlayersService](documentation/services/PlayersService.md)             |
| [SkatersService](documentation/services/SkatersService.md)             |
| [GoaliesService](documentation/services/GoaliesService.md)             |
| [DraftService](documentation/services/DraftService.md)                 |
| [TeamsService](documentation/services/TeamsService.md)                 |
| [SeasonService](documentation/services/SeasonService.md)               |
| [GameService](documentation/services/GameService.md)                   |
| [MiscellaneousService](documentation/services/MiscellaneousService.md) |

</details>

## License

This SDK is licensed under the MIT License.

See the [LICENSE](LICENSE) file for more details.
