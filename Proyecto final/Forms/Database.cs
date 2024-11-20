using System.Data.SqlClient;

public class Database
{
    private readonly string connectionString =
        "Data Source=WIN-H1P8F3D3IAS\\SQLEXPRESS;Initial Catalog=db;Integrated Security=True;Encrypt=False";

    public SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }
}