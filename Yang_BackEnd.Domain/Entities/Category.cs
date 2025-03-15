using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yang_BackEnd.Domain.Entities
{
    public class Category
    {
        [Key]
        public required int Id { get; set; }
        public required string Name { get; set; }
        public string Description { get; set; }
    }
}
