namespace AppCore.Common;

public interface IReadRepository<T>
{
    Task<T> FetchAsync(int id, CancellationToken cancellationToken = default);
    Task<T> FetchAsync(string name,CancellationToken cancellationToken = default);
    Task<IEnumerable<T>> FetchAllAsync(CancellationToken cancellationToken = default);
}