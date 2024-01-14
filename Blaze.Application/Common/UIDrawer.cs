using Blaze.Application.Common.Models;
using Blaze.Application.Entities.Attributes;
using Blaze.Application.Entities.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blaze.Application.Common
{
    public static class UIDrawer 
    { 
        public static WidgetResponseModel Widget(string typeName)
        {
            var widget = new WidgetResponseModel();
            var types = AppDomain.CurrentDomain.GetAssemblies().SelectMany(x=> x.GetTypes()).Where(a => a.FullName.StartsWith("Blaze.Application.Entities.Projects") && a.IsAssignableTo(typeof(Entity))).ToList();

            var type = types.FirstOrDefault(x => x.Name.ToLower() == typeName.ToLower());

            if (type is null) return widget;

            var properties = type.GetProperties(); 

            foreach (var prop in properties)
            {
                var attr = prop.GetCustomAttributes(typeof(UIAttribute), false).FirstOrDefault();

                if (attr is null) continue;

                UIAttribute uiAttr = attr as UIAttribute;

                if (attr is null) continue;

                Column column = new Column
                {
                    ColumnDisplayName = uiAttr.DisplayName,
                    ColumnOrder = uiAttr.Order,
                    ColumnName = prop.Name
                };

                widget.Table.Columns.Add(column); 
            } 

            return widget;
        }
    }
}
