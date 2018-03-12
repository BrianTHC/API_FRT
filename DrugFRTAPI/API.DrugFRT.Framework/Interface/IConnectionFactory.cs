using System.Data.SqlClient;

namespace API.DrugFRT.Framework.Interface
{
    public interface IConnectionFactory
    {
        SqlConnection CreateConnection();
    }
}
