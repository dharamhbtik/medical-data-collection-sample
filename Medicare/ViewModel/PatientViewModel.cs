using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Medicare.Models;
using Xamarin.Forms;

namespace Medicare.ViewModel
{
    public class PatientViewModel : BaseViewModel
    {
        public User CurrentPatient { get;  set; }
        public List<string> Sources { get => new List<string> { "News Paper","Friend","TV Ad","Social Media","Other" }; }
        public PatientViewModel()
        {
            CurrentPatient = new User();
            
        }

        public ICommand OnSave {
            get=> new Command(async() =>
        {
            if (await IsValidData())
            {
               if(PatientService?.SavePatientData(CurrentPatient) == true)
                {
                    await App.Current.MainPage.DisplayAlert("Success", "Data has been saved", "Ok!");
                }
                else
                {
                    await App.Current.MainPage.DisplayAlert("Error", "Error while saving data", "Ok!");
                }
            }
        }); }

        private async Task<bool> IsValidData()
        {
            if (!string.IsNullOrWhiteSpace(CurrentPatient.EmailAddress)) return true;
            else
            {
              await  App.Current.MainPage.DisplayAlert("Error", "Email Address is required", "Ok!");
                return false;
            }
        }
    }
}
