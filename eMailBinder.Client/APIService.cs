using System.Net.Http.Json;
using System.Text.Json;

namespace eMailBinder.Client;
internal class APIService
{
    private readonly HttpClient _httpClient;

    public APIService(HttpClient httpClient,string apiKey)
    {
        _httpClient = httpClient;
        _httpClient.DefaultRequestHeaders.Add("X-API-Key",apiKey);
    }

    public async Task<(bool IsSuccess, T? result, string? ErrorMessage)> Get<T>(string url)
    {
        try
        {                 
            var response = await _httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsByteArrayAsync();
                var options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
                var result = JsonSerializer.Deserialize<T>(content, options);
                return (true, result, null);
            }
            return (false, default(T), response.ReasonPhrase ?? "");
        }
        catch (Exception ex)
        {
            return (false, default(T), ex.Message);
        }
    }

    public async Task<(bool IsSuccess, T1? result, string? ErrorMessage)> Post<T1,T2>(string url, T2 objectContent)
    {
        try
        { 
            var response = await _httpClient.PostAsJsonAsync(url, objectContent);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsByteArrayAsync();
                var options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
                var result = JsonSerializer.Deserialize<T1>(content, options);
                return (true, result, null);
            }
            return (false, default(T1), response.ReasonPhrase ?? "");
        }
        catch (Exception ex)
        {
            return (false, default(T1), ex.Message);
        }
    }
}