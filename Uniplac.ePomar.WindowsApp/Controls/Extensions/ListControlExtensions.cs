using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uniplac.ePomar.WindowsApp.Controls.Extensions
{
    public static class ListControlExtensions
    {
        public static void OverrideAll<T>(this IList listControl, IEnumerable<T> sourceList)
        {
            listControl.Clear();

            foreach (T item in sourceList)
            {
                if (item != null)
                    listControl.Add(item);
            }
        }
    }
}
