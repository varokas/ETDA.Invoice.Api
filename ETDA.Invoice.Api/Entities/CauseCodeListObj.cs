using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ETDA.Invoice.Api.Entities
{
    public class CauseCodeListObj
    {
        public string code { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public string cases { get; set; }

        public CauseCodeListObj()
        {

        }

        public CauseCodeListObj(string code, string description, string type, string cases)
        {
            this.code = code;
            this.description = description;
            this.type = type;
            this.cases = cases;
        }
    }
}
