namespace SportsNotebook.Server.Models;

public class Exercise
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public List<Plan> Plan { get; } = [];
    public List<Plan_Exercise> Plan_Exercises { get; } = [];

    public User User { get; set; } = null!;
    public string UserId { get; set; } = null!;
}
