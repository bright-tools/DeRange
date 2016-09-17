using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeRange
{
    public interface UserNotifier
    {
        void Notify(String title, String notification);
    }
}
