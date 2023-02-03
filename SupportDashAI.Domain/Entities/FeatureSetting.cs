using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportDashAI.Domain.Entities
{
    public class FeatureSetting
    {
        public Guid Id { get; set; }
        public string? UserId { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
