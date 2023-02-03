using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportDashAI.Contracts.Dto
{
    public class FeatureSettingDto
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public string? UserId { get; set; }
    }
}
