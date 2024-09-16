using NhlStats.Config;
using NhlStats.Http.Handlers;
using NhlStats.Services;
using Environment = NhlStats.Http.Environment;

namespace NhlStats;

public class NhlStatsClient : IDisposable
{
    private readonly HttpClient _httpClient;

    public PlayersService Players { get; private set; }
    public SkatersService Skaters { get; private set; }
    public GoaliesService Goalies { get; private set; }
    public DraftService Draft { get; private set; }
    public TeamsService Teams { get; private set; }
    public SeasonService Season { get; private set; }
    public GameService Game { get; private set; }
    public MiscellaneousService Miscellaneous { get; private set; }

    public NhlStatsClient(NhlStatsConfig? config = null)
    {
        var retryHandler = new RetryHandler();
        _httpClient = new HttpClient(retryHandler)
        {
            BaseAddress = config?.Environment?.Uri ?? Environment.Default.Uri,
            DefaultRequestHeaders = { { "user-agent", "dotnet/7.0" } }
        };

        Players = new PlayersService(_httpClient);
        Skaters = new SkatersService(_httpClient);
        Goalies = new GoaliesService(_httpClient);
        Draft = new DraftService(_httpClient);
        Teams = new TeamsService(_httpClient);
        Season = new SeasonService(_httpClient);
        Game = new GameService(_httpClient);
        Miscellaneous = new MiscellaneousService(_httpClient);
    }

    /// <summary>
    /// Set the environment for the entire SDK.
    /// </summary>
    public void SetEnvironment(Environment environment)
    {
        SetBaseUrl(environment.Uri);
    }

    /// <summary>
    /// Sets the base URL for entire SDK.
    /// </summary>
    public void SetBaseUrl(string baseUrl)
    {
        SetBaseUrl(new Uri(baseUrl));
    }

    /// <summary>
    /// Sets the base URL for the entire SDK.
    /// </summary>
    public void SetBaseUrl(Uri uri)
    {
        _httpClient.BaseAddress = uri;
    }

    public void Dispose()
    {
        _httpClient.Dispose();
    }
}

// c029837e0e474b76bc487506e8799df5e3335891efe4fb02bda7a1441840310c
