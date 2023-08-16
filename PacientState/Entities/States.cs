namespace PacientState.Entities
{
    public struct States
    {
        public const string CheckIn = "Doing checkin to pacient {0}";
        public const string Triage = "Doing triage to pacient {0}";
        public const string MedicEvaluation = "Doing medic evaluation to pacient {0}";
        public const string MedicRelease = "Doing medic release to pacient {0}";
    }
}