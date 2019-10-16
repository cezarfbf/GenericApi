using ApplicationCore.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }
    }
}
