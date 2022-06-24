using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Medicare.Services;
using Xamarin.Forms;

namespace Medicare.ViewModel
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public PatientService PatientService
        {
            get; private set;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public BaseViewModel()
        {
            PatientService = DependencyService.Resolve<PatientService>();
        }
        protected void OnPropertyChanged([CallerMemberName] string propName = "")
        {
            var changed = PropertyChanged;

            changed?.Invoke(this, new PropertyChangedEventArgs(propName));
        }


    }
}
