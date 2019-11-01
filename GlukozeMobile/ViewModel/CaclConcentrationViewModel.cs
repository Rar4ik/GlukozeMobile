using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using GlukozeMobile.Model;


namespace GlukozeMobile.ViewModel
{
    class CaclConcentrationViewModel : INotifyPropertyChanged
        {
        Validation Validation = new Validation();

        #region
        /// <summary>
        /// Ввод параметров для модели
        /// </summary>
        private string _overalAmount;
        public string OveralAmount
        {
            get { return _overalAmount; }
            set
            {
                if (Validation.CheckLenght(value) == true)
                    _overalAmount = value;
                else
                    _overalAmount = null; OnPropertyChanged("BiggerConAmount"); OnPropertyChanged("LesserConAmount");
            }
        }
        private string _biggerCon;
        public string BiggerCon
        {
            get { return _biggerCon; }
            set
            {
                if (Validation.CheckLenght(value) == true)
                    _biggerCon = value;
                else
                    _biggerCon = null; OnPropertyChanged("BiggerConAmount"); OnPropertyChanged("LesserConAmount");
            }
        }
        private string _lesserCon;
        public string LesserCon
        {
            get { return _lesserCon; }
            set
            {
                if (Validation.CheckLenght(value) == true)
                    _lesserCon = value;
                else
                    _lesserCon = null; OnPropertyChanged("BiggerConAmount"); OnPropertyChanged("LesserConAmount");
            }
        }
        private string _biggerConAmount;
        public string BiggerConAmount
        {
            get
            {
                CalcConcentrationModel calcConcentrationModel = new CalcConcentrationModel();
                if (LesserCon == "" | BiggerCon == "" | OveralAmount == "")
                    return null;
                else
                    return calcConcentrationModel.GetBiggerAmount(LesserCon, BiggerCon, OveralAmount).ToString();
            }
            set { _biggerConAmount = value; }
        }
        public string LesserConAmount
        {
            get
            {
                CalcConcentrationModel calcConcentrationModel = new CalcConcentrationModel();
                if (OveralAmount == "" | BiggerConAmount == null)
                    return null;
                else
                    return calcConcentrationModel.GetLesserAmount(OveralAmount, BiggerConAmount).ToString();
            }
        }
        #endregion
        public event PropertyChangedEventHandler PropertyChanged;
            protected virtual void OnPropertyChanged(string propertyName)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
