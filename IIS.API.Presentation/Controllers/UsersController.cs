using IIS.API.Application.Services.UserService;
using IIS.API.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace IIS.API.Presentation.Controllers;


[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly IUserService _userService;

    public UsersController(IUserService service)
    {
        _userService = service;
    }

    [HttpGet]
    public async Task<IActionResult> Get(CancellationToken token)
    {
        IEnumerable<User> response = await _userService.GetUsersAsync(token);

        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get([FromRoute] string id, CancellationToken token)
    {
        if (Guid.TryParse(id, out var userId))
        {
            User? response = await _userService.GetFirstOrDefaultUserAsync(f => f.Id == userId, token);

            return response is null ? NotFound() : Ok(response);
        }

        return NotFound();
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] User user, CancellationToken token)
    {
        await _userService.AddUserAsync(user, token);

        return NoContent();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put([FromRoute] string id, [FromBody] User user, CancellationToken token)
    {
        if (Guid.TryParse(id, out var userId))
        {
            user.Id = userId;
            await _userService.UpdateUserAsync(user, token);

            return NoContent();
        }

        return NotFound();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] string id, CancellationToken token)
    {
        if (Guid.TryParse(id, out var userId))
        {
            await _userService.DeleteUserAsync(userId, token);

            return NoContent();
        }

        return NotFound();
    }
}
