namespace AppCore.Weight;

public class WeightCategory
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int Weight { get; set; }
    public WeightType WeightType { get; set; }
}