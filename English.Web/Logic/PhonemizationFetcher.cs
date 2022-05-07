using English.Web.Model.Requests;
using English.Web.Model.Responses;
using System.Net.Http.Json;

namespace English.Web.Logic;

public class PhonemizationFetcher
{
    private HttpClient Http { get; }

    public PhonemizationFetcher(HttpClient http)
    {
        Http = http;
    }

    public async Task<String> GetPhonemization(String text)
    {
        List<String> lines = text.Split(Environment.NewLine).ToList();
        PhonemizeRequest request = new(lines);

        HttpResponseMessage responseMessage = await Http.PostAsJsonAsync("http://localhost:8000/phonemize", request);
        PhonemizeResponse? response = await responseMessage.Content.ReadFromJsonAsync<PhonemizeResponse>();

        String phonemization = String.Join(Environment.NewLine, response?.phonemized ?? new());

        return phonemization;
    }
}
