using System;
using System.Collections.Generic;
using System.Text;

namespace Student
{
    class CapacityLimitException:Exception
    {
        public CapacityLimitException(string msg) : base(msg)
        {

        }
    }
}
