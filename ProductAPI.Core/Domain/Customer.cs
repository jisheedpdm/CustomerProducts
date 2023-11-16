using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAPI.Core.Domain;

public class Customer
{
    public string? CustomerId { get; set; }
    public string? EmailId { get; set;}
    public string? FirstName { get; set; }
    public string? LastName { get; set;}
    public Order? _RecentOrder { get; set; }
}
