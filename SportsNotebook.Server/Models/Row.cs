using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SportsNotebook.Server.Models;

public class Row
{
    public int Id { get; set; }
    public int PlanId { get; set; }
    public Plan_Exercise Plan { get; set; } = null!;
    public DateTime Date { get; set; }

    [Column(TypeName = "json")]
    public RowObject[] Value { get; set; } = [];
}

public class RowObject
{
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public int Count { get; set; }

    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public double Weight { get; set; }
}
