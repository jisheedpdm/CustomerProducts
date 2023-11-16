using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAPI.Core.Domain;

public class Order
{
    public int? OrderNumber { get; set; }
    public DateTime? OrderDate { get; set; }
    public string? DeliveryAddress { get; set; }
    public DateTime? DeliveryExpected { get; set; }
    public List<OrderItems>? _OrderItems { get; set; }
}
