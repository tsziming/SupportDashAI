using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportDashAI.Contracts.Dto.Catalog
{
    public class CategoryDto
    {
        public Guid? Id { get; set; }
        [Required]
        [MaxLength(256)]
        public string Name { get; set; }
        [MaxLength(1024)]
        public string Description { get; set; }
    }
}
