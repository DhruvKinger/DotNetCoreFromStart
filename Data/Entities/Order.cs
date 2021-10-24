﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCoreEmptyApplication.Data.Entities
{
  public class Order
  {
    public int Id { get; set; }
    public DateTime OrderDate { get; set; }
    public string OrderNumber { get; set; }
    public ICollection<OrderItem> Items { get; set; }
  }
}
