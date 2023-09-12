namespace AuPointsCalc.Model
{
    public class Category
    {
        public string Description { get; set; }
        public string HeadlineQuestion { get; set; }
        public List<Option> Options { get; set; } = new List<Option>();

        public List<Requirement> Requirements { get; set; } = new List<Requirement>();
    }

    
}
