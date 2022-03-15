using Newtonsoft.Json;

namespace CDSService.Models;

public class Card
{
    public string Summary { get; set; } = default!;
    public string Detail { get; set; } = default!;
    public string Indicator { get; set; } = default!;
    public Source Source { get; set; } = default!;
    public IList<Suggestion>? Suggestions { get; set; }
    public string? SelectionBehavior { get; set; }
    public IList<Link>? Links { get; set; }
}
