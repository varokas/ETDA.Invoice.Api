using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ETDA.Invoice.Api.Entities
{
    public class TypeCodeObj
    {
        public string code { get; set; }
        public string description { get; set; }

        public TypeCodeObj(string code, string description)
        {
            this.code = code;
            this.description = description;
        }
    }
}
