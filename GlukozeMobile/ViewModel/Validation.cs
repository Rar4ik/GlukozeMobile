using System;
using System.Collections.Generic;
using System.Text;

namespace GlukozeMobile.ViewModel
{
    class Validation
    {
        public bool CheckLenght(string parametr)
        {
            if (parametr == null)
                return false;
            else return true;
        }
    }
}
