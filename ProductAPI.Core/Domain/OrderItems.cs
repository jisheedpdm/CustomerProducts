using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAPI.Core.Domain;

public class OrderItems
{
    public string? ProductName { get; set; }
    public int? Quantity { get; set; }
    public double? PriceEach { get; set; }
}
