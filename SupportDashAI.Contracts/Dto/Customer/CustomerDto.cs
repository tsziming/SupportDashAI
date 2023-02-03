using SupportDashAI.Contracts.Dto.Catalog;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportDashAI.Contracts.Dto.Customer
{
    public class CustomerDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string AISummary { get; set; }
        public string AIStatus { get; set; }
        public string Notes { get; set; }
        public virtual List<CategoryDto> CategoryInterests { get; set; }
        public virtual List<ProductDto> ProductHistory { get; set; }
        public virtual List<CustomerRequestDto> Requests { get; set; }
        public virtual List<AgentResponseDto> Responses { get; set; }
        public virtual List<AgentResponseTipDto> Tips { get; set; }
        public virtual AgentDto Agent { get; set; }
        public string PreviewMessage { get; set; }
    }
}
