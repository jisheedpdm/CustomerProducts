using Dapper;
using Microsoft.Data.SqlClient;
using ProductAPI.Core.Domain;
using ProductAPI.InfraStructure.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAPI.InfraStructure.Respository;

public class CustomerRepo : ICustomerRepo
{
    private readonly DBContext _dbContext;

    public CustomerRepo(DBContext dbContext)
    {
        _dbContext = dbContext;
    }
   
    public async Task<Customer> GetCustomerOrder(string email, string customerId)
    {
        try
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("email", email);
            parameters.Add("customerId", customerId);
            using (var connection = _dbContext.GetConnection())
            {
                var data = await connection.QuerySingleOrDefaultAsync<Customer>("SP_GET_CUSTOMERRECENTORDER", parameters, commandType: CommandType.StoredProcedure);
                return data;
            }
            
        }
        catch (Exception ex)
        {
            throw new Exception("Exception from GetCustomerOrder while SQL query execution", ex);
        }
    }
}
