using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AssestCategory.DTO
{
    public class AssestDataDTO
    {
        public string categoryId { get; set; }
        public string categoryName { get; set; }
        public string categoryCode { get; set; }
        public string classList { get; set; }
        public bool activeStatus { get; set; }
    }
}