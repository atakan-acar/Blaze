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

            var type = GetBlazeType(typeName);

            if (type is null) return new WidgetResponseModel();

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
            widget.IsSuccess = true;
            return widget;
        }

        public static FormResponseModel Form(string typeName)
        {
            var form = new FormResponseModel();
            var type = GetBlazeType(typeName);

            if (type is null) return new FormResponseModel();

            var properties = type.GetProperties();

            foreach (var prop in properties)
            {
                var attr = prop.GetCustomAttributes(typeof(UIAttribute), false).FirstOrDefault();

                if (attr is null) continue;

                UIAttribute uiAttr = attr as UIAttribute;

                if (attr is null) continue;

                FormElement fElement = new FormElement
                {
                    ElementName = uiAttr.DisplayName,
                    Order = uiAttr.Order,
                    UIType = uiAttr.UIType
                };

                form.Form.FormElement.Add(fElement);
            }
            form.IsSuccess = true;
            return form;
        }

        public static EntityInformationModel Information(string typeName)
        {
            var t = GetBlazeType(typeName);

            if (t is null) return new EntityInformationModel();

            var attr = t.GetCustomAttributes(typeof(EInformation), false).FirstOrDefault() as EInformation;

            if (attr is null) return new EntityInformationModel() { IsSuccess = false, Message = "ENTITY_ATTRIBUTE_NOT_FOUND" };

            return new EntityInformationModel()
            {
                Description = attr.Description,
                DisplayName = attr.Name,
                EntityName = typeName,
                IsSuccess = true, 
            };   
        }

        private static Type? GetBlazeType(string typeName)
        {
            var types = AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes()).Where(a => a.FullName.StartsWith("Blaze.Application.Entities.Projects") && a.IsAssignableTo(typeof(Entity))).ToList();

            var type = types.FirstOrDefault(x => x.Name.ToLower() == typeName.ToLower());

            return type;
        }
    }
}
