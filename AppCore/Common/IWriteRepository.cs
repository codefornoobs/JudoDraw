using System.Net.Sockets;

namespace AppCore.Common;

public interface IWriteRepository<T>
{
    Task<T> AddAsync(T entity,CancellationToken cancellationToken = default);
    Task<T> AddRangeAsync(IEnumerable<T> entity,CancellationToken cancellationToken = default);
    
    Task<T> UpdateAsync(int id,T entity,CancellationToken cancellationToken = default);
    Task DeleteAsync(int id,CancellationToken cancellationToken = default);
    Task DeleteRangeAsync(IEnumerable<int> id,CancellationToken cancellationToken = default);
}