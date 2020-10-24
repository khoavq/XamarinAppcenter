using Microsoft.AppCenter.Crashes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HelloWorld
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Button_Clicked(object sender, EventArgs e)
        {
            greetingLabel.Text = "Welcome " + nameEntry.Text + "!!! It is good to have you.";
            
        }

        void Button_Crash_Clicked(object sender, EventArgs e)
        {
            var crashInt = int.Parse(nameEntry.Text);
            greetingLabel.Text = crashInt.ToString();
        }

        
    }
}
