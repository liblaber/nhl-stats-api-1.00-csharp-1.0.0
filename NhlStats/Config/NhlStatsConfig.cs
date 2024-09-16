using Environment = NhlStats.Http.Environment;

namespace NhlStats.Config;

/// <summary>
/// Configuration options for the NhlStatsClient.
/// </summary>
public record NhlStatsConfig(
    /// <value>The environment to use for the SDK.</value>
    Environment? Environment = null
);
