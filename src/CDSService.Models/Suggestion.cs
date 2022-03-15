using Action = CDSService.Models.Action;

namespace CDSService.Models
{
    public class Suggestion
    {
        public string Label { get; set; } = default!;
        public Guid? Uuid { get; set; }
        public IList<Action>? Actions { get; set; }
    }
}