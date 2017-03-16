using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OktaFirst.Domain;
using OktaFirst.Services;

namespace OktaFirst.Controllers
{
  [Route("api/[controller]")]
  public class UserController : Controller
  {
    private readonly UserService userService;
    public UserController(UserService userService)
    {
      this.userService = userService;

    }

    public async Task<IActionResult> Get()
    {
      return Ok(await userService.GetAllUsersAsync());
    }

    [Route("{id}")]
    public async Task<IActionResult> Get(string id)
    {
      return Ok(await userService.GetUserByIdAsync(id));
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody]User user)
    {
      try
      {
        return Ok(await userService.CreateUser(user));
      }
      catch (System.Exception ex)
      {
        return BadRequest(ex.Message);
      }
    }
  }
}