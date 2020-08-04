using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model.Model
{
    public class Category : BaseModel
    {
        [Key]
        public string CategoryCode { get; set; }
        public string Name { get; set; }
    }
}
