namespace AppCore;

public interface IAppLogger
{
    void LogInformation<T0>(T0 arg0);
    void LogInformation<T0, T1>(T0 arg0, T1 arg1);
}