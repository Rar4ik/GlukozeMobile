using System;
using System.Collections.Generic;
using System.Text;

namespace GlukozeMobile.Model
{
    static class CheckNegative
    {
        public static bool IsNegative(double parametr)
        {
            if (parametr < 0)
                return false;
            else
                return true;
        }
    }
}
