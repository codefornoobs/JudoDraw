namespace AppCore.Common;

public abstract class BaseEntity
{
    public int Id { get; set; }
    public string ChangeBy { get; set; }
    public DateTime ChangeDate { get; set; }
}