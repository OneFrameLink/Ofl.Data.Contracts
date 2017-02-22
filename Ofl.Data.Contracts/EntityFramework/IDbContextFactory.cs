using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Ofl.Data.EntityFramework
{
    public interface IDbContextFactory
    {
        Task<T> CreateDbContextAsync<T>(
            Func<DbContextOptionsBuilder<T>, CancellationToken, Task> configuration,
            CancellationToken cancellationToken)
            where T : DbContext;
    }
}
