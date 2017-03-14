using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Recetas.Views
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();            
        }

        private void btnJavascriptAndCSharp_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new JavaScriptAndCSharpView());
        }

        private void btnEntryTypes_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EntryKeyboardsView());
        }

        private void btnEntryFlags_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EntryKeyboardFlags());
        }

        private void btnImageOrientation_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ImageOrientationView());
        }
    }  
}
