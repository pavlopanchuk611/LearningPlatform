﻿
public class Course
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int TeacherId { get; set; }
    public ICollection<User> EnrolledStudents { get; set; }
}