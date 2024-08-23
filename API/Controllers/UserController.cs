using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers{

[ApiController]
public class UserController : ControllerBase
{

    private readonly TestContext _dbContext;
    public UserController(
        TestContext dbContext
        )
    {
        _dbContext = dbContext;
    }


    [HttpGet]
    [Route("test")]
    public async Task<List<User>> GetUsers()
    {
        return await _dbContext.User.ToListAsync();

    }

    [HttpGet]
    [Route("hey")]
    public string Get()
    {
        return "hey";
    }

}
}

