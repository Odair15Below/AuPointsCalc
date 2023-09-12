using AuPointsCalc.Model;

namespace AuPointsCalc
{
    public class PointsCalculator
    {
        private readonly Dictionary<string, int> Totals = new();

        public int Total { get; internal set; } = 0;

        public List<Category> Categories { get; internal set; } = new ();

        public PointsCalculator(ICategoryLoader categoryLoader)
        {
            Categories = categoryLoader.LoadCategories();
        }

        public void SelectOptionForCategory(string category, Option option)
        {
            Totals[category] = option.Points;
            CalculateTotal();
        }

        private void CalculateTotal()
        {
            Total = Totals.Values.Sum();
        }
    }
}
