using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppTravelRecorder
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void logInButton_Clicked(object sender, EventArgs e)
        {
            bool entryEmailValue = string.IsNullOrEmpty(emailEntry.Text);
            bool entryPasswordValue = string.IsNullOrEmpty(passwordEntry.Text);

            if (entryEmailValue || entryPasswordValue)
            {
                test.Text = "VACIO!";
            }
            else
            {
                Navigation.PushAsync(new HomePage());
            }
        }
    }
}
