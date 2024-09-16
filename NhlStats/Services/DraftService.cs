using System.Net.Http.Json;
using NhlStats.Http;
using NhlStats.Http.Exceptions;
using NhlStats.Http.Extensions;
using NhlStats.Http.Serialization;

namespace NhlStats.Services;

public class DraftService : BaseService
{
    internal DraftService(HttpClient httpClient)
        : base(httpClient) { }

    /// <summary>Retrieve draft information.</summary>
    /// <param name="lang">Language code</param>
    public async Task<object> GetDraftInformationAsync(
        string lang,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(lang, nameof(lang));

        var request = new RequestBuilder(HttpMethod.Get, "{lang}/draft")
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
}
