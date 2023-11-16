using ProductAPI.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAPI.InfraStructure.Respository;

public interface ICustomerRepo
{
    Task<Customer> GetCustomerOrder(string email, string customerId);
}
