// This file was generated by liblab | https://liblab.com/

using Environment = NhlStatsClient.Http.Environment;

namespace NhlStatsClient.Config;

/// <summary>
/// Configuration options for the NhlStatsClientClient.
/// </summary>
public record NhlStatsClientConfig(
    /// <value>The environment to use for the SDK.</value>
    Environment? Environment = null
);
