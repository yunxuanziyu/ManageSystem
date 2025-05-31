using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageSystem.Extensions
{
    public static class DataTableExtensions
    {
        public static List<T> ToList<T>(this DataTable dataTable)
        {
            List<T> list = new List<T>();
            foreach (DataRow row in dataTable.Rows)
            {
                T item = Activator.CreateInstance<T>();
                foreach (DataColumn column in dataTable.Columns)
                {
                    if (row[column.ColumnName] != DBNull.Value)
                    {
                        item.GetType().GetProperty(column.ColumnName).SetValue(item, row[column.ColumnName], null);
                    }
                }
                list.Add(item);
            }
            return list;
        }
    }
}
