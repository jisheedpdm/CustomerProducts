using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAPI.InfraStructure.Data;

public class DBContext
{
    private readonly IConfiguration _configuration;
    private readonly string _connectionString;
    public DBContext(IConfiguration configuration)
    {
        _configuration = configuration;
        _connectionString = _configuration.GetConnectionString("Default");
    }

    public IDbConnection GetConnection() => new SqlConnection(_connectionString); 
}
