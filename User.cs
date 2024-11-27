
public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Role { get; set; } // "Student" or "Teacher"
}

public class User1
{
    [Required]
    public string Username { get; set; }

    [Required]
    [MinLength(6)]
    public string Password { get; set; }

    public string Role { get; set; }
}