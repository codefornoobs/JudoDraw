using AppCore.Common;

namespace Infrasctrure;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
    public DateTime Today => DateTime.Now;
}