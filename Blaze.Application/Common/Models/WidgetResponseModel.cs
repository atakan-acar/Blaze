using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blaze.Application.Common.Models
{
    public class WidgetResponseModel
    {
        public new Table Table { get; set; }

        public WidgetResponseModel()
        {
            Table = new Table();
        }
    }

    public class Table
    {
        public List<Column> Columns { get; set; }

        public Table()
        {
            Columns =new List<Column>();
        }
    }

    public class Column
    {
        public string ColumnName { get; set; }
        public string ColumnDisplayName { get; set; }

        public int ColumnOrder { get; set; } 
    }

    public class DataSource
    {
        
    }
}
