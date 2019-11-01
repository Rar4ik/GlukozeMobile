using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace GlukozeMobile.Model
{
    class CalcDoseModel:Page
    {
        Notification notify = new Notification();
        private const double coeff = 1.44;
        private double _vvDose;
        public double GetDose(string mass, string speed) => Convert.ToDouble(speed) * (Convert.ToDouble(mass) / 1000) * coeff;
        public void GetVVDose(string dose, string enteralno)
        {
            _vvDose = Convert.ToDouble(dose) - Convert.ToDouble(enteralno);
            notify.CheckError(_vvDose);
            DoseObject.Dose = _vvDose;
        }
    }
}
