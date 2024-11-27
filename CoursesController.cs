
[ApiController]
[Route("api/[controller]")]
public class CoursesController : ControllerBase
{
    private readonly YourDbContext _context;

    public CoursesController(YourDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Course>>> GetCourses()
    {
        return await _context.Courses.ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<Course>> CreateCourse(Course course)
    {
        _context.Courses.Add(course);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(CreateCourse), new { id = course.Id }, course);
    }
}