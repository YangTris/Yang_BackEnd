using System.ComponentModel.DataAnnotations.Schema;
using Yang_BackEnd.Domain.Entities;

namespace Yang_BackEnd.API.Models
{
    public class AddProductModel
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}
