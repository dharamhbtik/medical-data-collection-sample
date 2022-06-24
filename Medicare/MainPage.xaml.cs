using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Medicare.ViewModel;
using Xamarin.Forms;

namespace Medicare
{
    public partial class MainPage : ContentPage
    {
        PatientViewModel vm;
        public MainPage()
        {
            InitializeComponent();
            vm = new PatientViewModel();
            this.BindingContext = vm;
        }
    }
}
