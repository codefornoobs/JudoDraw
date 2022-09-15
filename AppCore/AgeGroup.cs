using AppCore.Weight;

namespace AppCore;

public class AgeGroup
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int MinimumAge { get; set; }
    public int MaximumAge { get; set; }
    public List<WeightCategory> WeightCategories { get; set; }
}