using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blaze.Application.Entities.Attributes
{ 
    public class EInformation : Attribute
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
