using System.Net.Http;
using System.Threading.Tasks;

namespace OktaFirst.Services
{
  public interface ApiService
  {
    Task<HttpResponseMessage> Get(string url);
    Task<HttpResponseMessage> Post(string url, string data);
  }
}