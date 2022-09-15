using System.Security.Cryptography.X509Certificates;

namespace AppCore;

public class Competition
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public DateTime Date { get; set; }
    public string Location { get; set; }
    public AgeGroup AgeGroup { get; set; }
    public List<Judoka> Judokas { get; set; }
}