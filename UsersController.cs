
[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly YourDbContext _context;

    public UsersController(YourDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<ActionResult<User>> Register(User user)
    {
        _context.Users.Add(user);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(Register), new { id = user.Id }, user);
    }
}