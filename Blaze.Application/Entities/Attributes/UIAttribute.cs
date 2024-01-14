using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blaze.Application.Entities.Attributes
{
    public class UIAttribute: Attribute
    {
        public string DisplayName { get; set; }
          
        public Type? DataSource { get; set; }

        public int Order { get; set; }  

        public UIType UIType { get; set; }
    }

    public enum UIType
    {
        Textbox = 1,
        Selectbox =2, 
        Checkbox= 4,
        RadioButton = 8,
        DatetimePicker = 16,
    }
}
