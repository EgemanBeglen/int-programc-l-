using System.ComponentModel.DataAnnotations;

public class Course
{
    [Key]
    public int id { get; set; }

    public string? Title  { get; set; }

    public string? Description { get; set; }

    public int MyProperty { get; set; }
}