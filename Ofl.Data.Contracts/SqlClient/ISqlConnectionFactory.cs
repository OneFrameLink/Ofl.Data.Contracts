using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;

namespace Ofl.Data.SqlClient
{
    public interface ISqlConnectionFactory
    {
        Task<SqlConnection> CreateConnectionAsync(string name, CancellationToken cancellationToken);
    }
}
