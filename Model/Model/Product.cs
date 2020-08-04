using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model.Model
{
    public class Product : BaseModel
    {
        [Key]
        public string ProductCode { get; set; }
        public string Name { get; set; }
        public long PriceImport { get; set; }
        public long PriceSale { get; set; }

        public string CategoryCode { get; set; }
        public int Amount { get; set; }

        public string Description { get; set; }
    }
}
