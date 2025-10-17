using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp0407.Panel.Models;

internal class OrderItem
{
    public Order Order { get; set; }
    public Product Product { get; set; }
    public decimal CurrentPrice { get; set; }
    public int Count { get; set; }
}
