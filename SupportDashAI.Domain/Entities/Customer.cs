using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportDashAI.Domain.Entities
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? AISummary { get; set; }
        public string? AIStatus { get; set; }
        public string? Notes { get; set; }
        public virtual List<Category> CategoryInterests { get; set;}
        public virtual List<Product> ProductHistory { get; set;}
        public virtual List<CustomerRequest> Requests { get; set;}
        public virtual List<AgentResponse> Responses { get; set;}
        public virtual List<AgentResponseTip> Tips { get; set;}
        public virtual IdentityUser Agent { get; set;}
        [NotMapped]
        public string? PreviewMessage { get; set; }
    }
}
