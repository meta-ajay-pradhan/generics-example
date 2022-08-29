using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generics
{
    public class CompareClass<T>
    {
        public bool Compare(T value1, T value2)
        {
            if(value1 == null || value2 == null) {
                throw new Exception();
            }
            return value1.Equals(value2);
        }

        public bool EmptyOrNot<T>(List<T> data)
        {
            if (data.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}