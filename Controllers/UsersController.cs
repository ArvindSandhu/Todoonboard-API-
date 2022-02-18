namespace todoonboard_api.Controllers;

using Microsoft.AspNetCore.Mvc;
using todoonboard_api.Helpers;
using todoonboard_api.InfoModels;
using todoonboard_api.Services;
using todoonboard_api.Models;

[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{
    private IUserService _userService;

    public UsersController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost("authenticate")]
    public IActionResult Authenticate(AuthenticateRequest model)
    {
        var response = _userService.Authenticate(model);

        if (response == null)
            return BadRequest(new { message = "Username or password is incorrect" });

        return Ok(response);
    }

    [HttpPost("create")]
    public IActionResult Create(UserRequest userRequest)
    {
        var user = _userService.CreateUser(userRequest);
        if (user == null) return BadRequest(user);

        return Ok(user);



    }
    [Authorize]
    [HttpGet]
    public IActionResult GetAll()
    {
        var users = _userService.GetAll();
        return Ok(users);
    }
}
