using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeRange
{
    class BindingListUtils
    {
        public static void Swap<T>(BindingList<T> p_list, int p_first, int p_second)
        {
            T temp = p_list[p_first];
            p_list[p_first] = p_list[p_second];
            p_list[p_second] = temp;
        }
    }
}
