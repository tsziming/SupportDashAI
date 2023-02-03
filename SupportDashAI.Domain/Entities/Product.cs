using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportDashAI.Domain.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Identifier { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public virtual Category Category { get; set; }
        public Guid CategoryId { get; set; }
    }
}
