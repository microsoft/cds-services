using CDSService.Models.PatientView;

namespace Models.EncounterStart
{
    public class EncounterStartContext : PatientViewContext
    {
        public string EncounterId { get; set; }
    }
}
