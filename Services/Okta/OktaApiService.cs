using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OktaFirst.Services.Okta
{
  public class OktaApiService : ApiService
  {
    private string baseUrl;
    private string token;

    public OktaApiService()
    {
      baseUrl = "https://dev-367846.oktapreview.com/api/v1";
      token = "00eo-vcu2Q98G0bEtZsrwwlO_m2-UBgCydpzKSsz-0";
    }

    public Task<HttpResponseMessage> Get(string url)
    {
      var request = new HttpRequestMessage();
      request.RequestUri = new Uri($"{baseUrl}{url}");
      request.Headers.Accept.Clear();
      request.Headers.Accept.TryParseAdd("application/json");
      request.Headers.Authorization = new AuthenticationHeaderValue("SSWS", this.token);
      request.Method = HttpMethod.Get;
      HttpClient client = new HttpClient();
      return client.SendAsync(request);
    }

    public Task<HttpResponseMessage> Post(string url, string data)
    {
      // var request = new HttpRequestMessage();
      // request.RequestUri = new Uri($"http://localhost:8000/{url}");
      // request.Headers.Accept.Clear();
      // request.Headers.Accept.TryParseAdd("application/json");
      // request.Headers.Authorization = new AuthenticationHeaderValue("SSWS", this.token);
      // request.Method = HttpMethod.Post;
      // request.Content = new StringContent(data, Encoding.UTF8, "application/json");
      HttpClient client = new HttpClient();
      client.BaseAddress = new Uri("http://localhost:9898"); 
      return client.PostAsync("/users", new StringContent(string.Empty));
      //return client.SendAsync(request);
    }
  }
}