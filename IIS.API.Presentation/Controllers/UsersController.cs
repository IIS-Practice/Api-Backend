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

    // GET: api/<UsersController>
    [HttpGet]
    public async Task<IActionResult> Get(CancellationToken token)
    {
        IEnumerable<User> response = await _userService.GetUsersAsync(token);

        return Ok(response);
    }

    // GET api/<UsersController>/5
    [HttpGet("{id}")]
    public async Task<IActionResult> Get(string id, CancellationToken token)
    {
        if (Guid.TryParse(id, out var userId))
        {
            User? response = await _userService.GetFirstOrDefaultUserAsync(f => f.Id == userId, token);

            return response is null ? NotFound() : Ok(response);
        }

        return NotFound();
    }

    // POST api/<UsersController>
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] User user, CancellationToken token)
    {
        await _userService.AddUserAsync(user, token);

        return Ok();
    }

    // PUT api/<UsersController>/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(string id, [FromBody] User user, CancellationToken token)
    {
        if (Guid.TryParse(id, out var userId))
        {
            user.Id = userId;
            await _userService.UpdateUserAsync(user, token);

            return Ok();
        }

        return NotFound();
    }

    // DELETE api/<UsersController>/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(string id, CancellationToken token)
    {
        if (Guid.TryParse(id, out var userId))
        {
            await _userService.DeleteUserAsync(userId, token);

            return Ok();
        }

        return NotFound();
    }
}
