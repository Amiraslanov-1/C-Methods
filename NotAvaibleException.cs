using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp29
{
    class NotAvaibleException:Exception
    {
        public NotAvaibleException(string msg):base(msg)
        {

        }
    }
}
