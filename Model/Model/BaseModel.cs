using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Model
{
    public class BaseModel
    {
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DateLastImported { get; set; }
        public DateTime? DateLastExported { get; set; }
    }
}
