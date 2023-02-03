using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportDashAI.Contracts.Dto.Catalog
{
    public class ProductDto
    {
        public Guid? Id { get; set; }
        public string Identifier { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual CategoryDto Category { get; set; }
        public Guid CategoryId { get; set; }
    }
}
