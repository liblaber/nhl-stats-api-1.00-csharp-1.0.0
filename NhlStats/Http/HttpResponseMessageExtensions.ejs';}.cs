using NhlStats.Http.Exceptions;

namespace NhlStats.Http.Extensions;

public static class HttpResponseMessageExtensions
{
    public static HttpResponseMessage EnsureSuccessfulResponse(this HttpResponseMessage response)
    {
        if (!response.IsSuccessStatusCode)
        {
            throw new ApiException(response);
        }
        return response;
    }
}
