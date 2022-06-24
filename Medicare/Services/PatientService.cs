using System;
using Medicare.Models;

namespace Medicare.Services
{
    public class PatientService
    {
        public PatientService()
        {

        }
        public bool SavePatientData(User user)
        {
            Xamarin.Essentials.Preferences.Set("UserData", user.ToDataString());
            return true;
        }
    }
}
