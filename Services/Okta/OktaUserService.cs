using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using OktaFirst.Domain;

namespace OktaFirst.Services.Okta
{
  public class OktaUserService : UserService
  {
    private readonly ApiService apiService;
    public OktaUserService(ApiService apiService)
    {
      this.apiService = apiService;
    }

    public async Task<IList<User>> GetAllUsersAsync()
    {
      var response = await apiService.Get("/users");
      var json = await response.Content.ReadAsStringAsync();
      return JsonConvert.DeserializeObject<List<User>>(json);
    }

    public async Task<User> GetUserByIdAsync(string id)
    {
        var response = await apiService.Get($"/users/{id}");
        var json = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<User>(json);
    }

    public async Task<User> CreateUser(User user)
    {
        var userJson = JsonConvert.SerializeObject(user);
        var response = await apiService.Post("/users", userJson);
        if(response.IsSuccessStatusCode)
        {
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<User>(json);
        }
        else
        {
            throw new NotSupportedException("There was a problem creating the user");
        }
    }
  }
}