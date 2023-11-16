using Dapper;
using ProductAPI.Core.Domain;
using ProductAPI.InfraStructure.Data;
using System;
using System.Collections.Generic;
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
        string query = "Select * from Customers";
        using (var connection =_dbContext.GetConnection())
        {
            var customerDetails = await connection.QueryFirstOrDefaultAsync<Customer>(
                query,
                new { email, customerId });
            return customerDetails;
        }
    }
}
