using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportDashAI.Domain.Entities
{
    public class AgentResponseTip
    {
        public Guid Id { get; set; }
        public string Content { get; set; }
    }
}
