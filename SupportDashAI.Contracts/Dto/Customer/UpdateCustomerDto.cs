﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportDashAI.Contracts.Dto.Customer
{
    public class UpdateCustomerDto
    {
        public Guid Id { get; set; }
        public string Name { get; set;}
        public string Notes { get; set;}
    }
}
