namespace SportsNotebook.Server.Models;

public class Plan_Exercise
{
    public int Id { get; set; }
    public int PlanId { get; set; }
    public int ExerciseId { get; set; }
    public Plan Plan { get; set; } = null!;
    public Exercise Exercise { get; set; } = null!;
}
