using ManageSystem.DataManage.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageSystem.Extensions
{
    public static class ListExtensions
    {
        public static DataTable ToDataTable<T>(this List<T> data)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
            {
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                {
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                }
                table.Rows.Add(row);
            }
            return table;
        }

        public static List<T> ToExtensionList<T>(this System.Collections.Generic.List<T> lst)
        {
            List<T> newList = new List<T>();
            lst.ForEach(x => newList.Add(x));
            return newList;
        }

        public static T CreateNewEntity<T>(this List<T> data,bool AddEntityTiList = true) where T :ModelBase ,new ()
        {
            T entity = new T();
            if (AddEntityTiList)
                data.Add(entity);
            entity.EditState = EnumEditState.eInsert;
            return entity;
        }
    }

    public class List<T> : BindingList<T>,IList<T>,ICollection<T>,IEnumerable<T>,IEnumerable,IList,ICollection,IBindingList
    {
        public List() : base()
        {

        }
        private bool IsSortCore;
        private ListSortDirection _SortDirectionCore;
        private PropertyDescriptor _SortPropertyCore;

        protected override bool SupportsSortingCore => true;
        protected override bool SupportsSearchingCore => true;
        protected override bool IsSortedCore => IsSortCore;
        protected override ListSortDirection SortDirectionCore => _SortDirectionCore;
        protected override PropertyDescriptor SortPropertyCore => _SortPropertyCore;
        protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
        {
            IsSortCore = true;
            _SortDirectionCore = direction;
            _SortPropertyCore = prop;
            System.Collections.Generic.List<T> sortedList = Items.ToList();
            if (direction == ListSortDirection.Ascending)
                sortedList = sortedList.OrderBy(x => prop.GetValue(x)).ToList();
            else
                sortedList = sortedList.OrderByDescending(x => prop.GetValue(x)).ToList();
            Items.Clear();
            for (int i = 0; i < sortedList.Count; i++)
            {
                Items.Add(sortedList[i]);
            }
        }
        protected override void RemoveSortCore()
        {
            IsSortCore = false;
            _SortDirectionCore = ListSortDirection.Ascending;
            _SortPropertyCore = null;
        }

        public void ForEach(Action<T> action)
        {
            System.Collections.Generic.List<T> sortedList = Items.ToList();
            sortedList.ForEach(action);
        }

        public T Find(Predicate<T> action)
        {
            System.Collections.Generic.List<T> sortedList = Items.ToList();
            return sortedList.Find(action);
        }
    } 
}
