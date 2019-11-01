using System;
using System.Collections.Generic;
using System.Text;

namespace GlukozeMobile.Model
{
    class CalcConcentrationModel
    {
        private const double coeff = 100;
        private double biggerV = 0;
        private double lesserV = 0;
        public int GetBiggerAmount(string lesserCon, string biggerCon, string overallV)
        {
            biggerV = (DoseObject.Dose * coeff - Convert.ToInt32(lesserCon) * Convert.ToInt32(overallV))
                / (Convert.ToInt32(biggerCon) - Convert.ToInt32(lesserCon));
            //DoseObject.BiggerCon = biggerV;
            return (int)biggerV;
        }
        public int GetLesserAmount(string overallV, string biggerV)
        {
            lesserV = Convert.ToInt32(overallV) - Convert.ToInt32(biggerV);
            //DoseObject.LesserCon = lesserV;
            return (int)lesserV;
        }
    }
}
