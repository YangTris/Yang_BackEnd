using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yang_BackEnd.Domain.Entities
{
    public class Inventory
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public int StockQuantity { get; set; }
    }
}
