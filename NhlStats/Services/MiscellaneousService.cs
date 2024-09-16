// This file was generated by liblab | https://liblab.com/

using System.Net.Http.Json;
using NhlStats.Http;
using NhlStats.Http.Exceptions;
using NhlStats.Http.Extensions;
using NhlStats.Http.Serialization;

namespace NhlStats.Services;

public class MiscellaneousService : BaseService
{
    internal MiscellaneousService(HttpClient httpClient)
        : base(httpClient) { }

    /// <summary>Retrieve configuration information.</summary>
    /// <param name="lang">Language code</param>
    public async Task<object> GetConfigurationAsync(
        string lang,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(lang, nameof(lang));

        var request = new RequestBuilder(HttpMethod.Get, "{lang}/config")
            .SetPathParameter("lang", lang)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        return await response
                .EnsureSuccessfulResponse()
                .Content.ReadFromJsonAsync<object>(_jsonSerializerOptions, cancellationToken)
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Ping the server to check connectivity.</summary>
    public async Task<object> PingServerAsync(CancellationToken cancellationToken = default)
    {
        var request = new RequestBuilder(HttpMethod.Get, "ping").Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        return await response
                .EnsureSuccessfulResponse()
                .Content.ReadFromJsonAsync<object>(_jsonSerializerOptions, cancellationToken)
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Retrieve country information. Returns list of all countries with a hockey presence(?)</summary>
    /// <param name="lang">Language code</param>
    public async Task<object> GetCountryInformationAsync(
        string lang,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(lang, nameof(lang));

        var request = new RequestBuilder(HttpMethod.Get, "{lang}/country")
            .SetPathParameter("lang", lang)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        return await response
                .EnsureSuccessfulResponse()
                .Content.ReadFromJsonAsync<object>(_jsonSerializerOptions, cancellationToken)
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Retrieve shift charts for a specific game.</summary>
    /// <param name="lang">Language code</param>
    /// <param name="cayenneExp">Required</param>
    public async Task<object> GetShiftChartsAsync(
        string lang,
        string cayenneExp,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(lang, nameof(lang));
        ArgumentNullException.ThrowIfNull(cayenneExp, nameof(cayenneExp));

        var request = new RequestBuilder(HttpMethod.Get, "{lang}/shiftcharts")
            .SetPathParameter("lang", lang)
            .SetQueryParameter("cayenneExp", cayenneExp)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        return await response
                .EnsureSuccessfulResponse()
                .Content.ReadFromJsonAsync<object>(_jsonSerializerOptions, cancellationToken)
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Retrieve the glossary for a specific language.</summary>
    /// <param name="lang">Language code</param>
    public async Task<object> GetGlossaryAsync(
        string lang,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(lang, nameof(lang));

        var request = new RequestBuilder(HttpMethod.Get, "{lang}/glossary")
            .SetPathParameter("lang", lang)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        return await response
                .EnsureSuccessfulResponse()
                .Content.ReadFromJsonAsync<object>(_jsonSerializerOptions, cancellationToken)
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Retrieve content module information.</summary>
    /// <param name="lang">Language code</param>
    public async Task<object> GetContentModuleAsync(
        string lang,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(lang, nameof(lang));

        var request = new RequestBuilder(HttpMethod.Get, "{lang}/content/module")
            .SetPathParameter("lang", lang)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        return await response
                .EnsureSuccessfulResponse()
                .Content.ReadFromJsonAsync<object>(_jsonSerializerOptions, cancellationToken)
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Retrieve metadata for content modules.</summary>
    public async Task<object> GetContentModuleMetadataAsync(
        CancellationToken cancellationToken = default
    )
    {
        var request = new RequestBuilder(HttpMethod.Get, "content/module/meta").Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        return await response
                .EnsureSuccessfulResponse()
                .Content.ReadFromJsonAsync<object>(_jsonSerializerOptions, cancellationToken)
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }
}
