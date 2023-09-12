namespace AuPointsCalc.Model
{
    public record Option
    {
        public string Description { get; set; }
        public List<Requirement> Requirements { get; set; } = new List<Requirement>();
        public int Points { get; set; }
    }

    public record Requirement
    {
        public string Description { get; set; }
    }
}