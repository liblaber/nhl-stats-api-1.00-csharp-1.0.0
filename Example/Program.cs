using NhlStats;
using NhlStats.Config;
using Environment = NhlStats.Http.Environment;

var config = new NhlStatsConfig { Environment = Environment.Default };

var client = new NhlStatsClient(config);

var response = await client.Miscellaneous.PingServerAsync();

Console.WriteLine(response);
