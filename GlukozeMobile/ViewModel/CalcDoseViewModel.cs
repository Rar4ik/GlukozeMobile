using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using GlukozeMobile.Model;
using System.Windows.Input;






namespace GlukozeMobile.ViewModel
{
    public class CalcDoseViewModel : INotifyPropertyChanged
    {
        Validation Validation = new Validation();
        #region 
        /// <summary>
        /// Ввод параметров для модели
        /// </summary>
        private string _mass;
        public string Mass
        {
            get { return _mass; }
            set
            {
                if (Validation.CheckLenght(value) == true)
                    _mass = value;
                else
                    _mass = null;
                OnPropertyChanged("Dose");
            }
        }
        private string _speed;
        public string Speed
        {
            get { return _speed; }
            set
            {
                if (Validation.CheckLenght(value) == true)
                    _speed = value;
                else
                    _speed = null; OnPropertyChanged("Dose"); OnPropertyChanged("VVDose");
            }
        }
        private string _enteralno;
        public string Enteralno
        {
            get { return _enteralno; }
            set
            {
                if (Validation.CheckLenght(value) == true)
                    _enteralno = value;
                else
                    _enteralno = null; OnPropertyChanged("VVDose");
            }

        }
        public string Dose
        {
            get
            {
                CalcDoseModel calcDoseModel = new CalcDoseModel();
                if (Mass == "" | Speed == "")
                    return null;
                else
                    return calcDoseModel.GetDose(Mass, Speed).ToString("F");
            }
        }
        private string _vvDose;
        public string VVDose
        {
            get
            {
                CalcDoseModel calcDoseModel = new CalcDoseModel();
                if (Dose == null | Enteralno == "")
                    return null;
                else
                {
                    calcDoseModel.GetVVDose(Dose, Enteralno);
                    return DoseObject.Dose.ToString();
                }
            }
            set { _vvDose = value; }
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
