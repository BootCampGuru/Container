using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleApp.Models
{
    public class IRepository

    {
       public IQueryable<Product> Products { get; }
    
    }
}
