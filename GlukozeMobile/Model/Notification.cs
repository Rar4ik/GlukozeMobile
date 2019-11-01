using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GlukozeMobile.Model
{
    class Notification:Page
    {
        protected string message = "Результат получился меньше нуля, измените входные параметры!";
        protected string caption = "Ошибка!";
        protected string cancel = "OK";
        public async Task CheckError(double parametr)
        {
            if (parametr < 0)
                await DisplayAlert(caption, message, cancel);
        }
    }
}
