using Blaze.Application.Entities.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blaze.Application.Entities.Projects
{
    [EInformation(Name = "Ürünler", Description = "Ürünleri içeren varlık bilgisidir.")]
    public class Product : Entity
    {

        [UI(DisplayName = "Product Name",  Order = 1, UIType = UIType.Textbox)]
        public string Name { get; set; }

        [UI(DisplayName = "Product Color",  Order = 2, UIType = UIType.Textbox)]
        public string Color { get; set; }
    }
}
