using Blaze.Application.Entities.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blaze.Application.Common.Models
{
    public class FormResponseModel : BaseResponse
    {
        public Form Form { get; set; }

        public FormResponseModel()
        {
            Form = new Form();
        }
    }

    
    public class Form
    {
        public string Name { get; set; }

        public List<FormElement> FormElement { get; set; }

        public Form()
        {
            FormElement = new List<FormElement>();
        }
    }

    public class FormElement
    {
        public string ElementName { get; set; }

        public int Order { get; set; }

        public UIType UIType { get; set; }


    }
}
