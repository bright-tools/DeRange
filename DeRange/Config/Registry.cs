using System;
using System.Collections.Generic;
using System.Linq;

namespace DeRange.Config
{
    class Registry<T> where T : ParentItem
    {
        private static Dictionary<Guid, T> m_dict = new Dictionary<Guid, T>();

        public static void Register( T p_item )
        {
            m_dict[p_item.GUID] = p_item;
        }

        public static void UnRegister( T p_item )
        {
            m_dict.Remove(p_item.GUID);
        }

        public static T Query( Guid p_guid )
        {
            T retVal = null;

            if (m_dict.ContainsKey(p_guid))
            {
                retVal = m_dict[p_guid];
            }

            return retVal;
        }
    }
}
