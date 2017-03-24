using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Recetas.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ToolBarItemsView : ContentPage
    {
        public ToolBarItemsView()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            this.ToolbarItems.Add(new ToolbarItem
            {
                Text = "¡Desde C#!",
                Icon = "settings.png"
            });
            base.OnAppearing();
        }
    }
}
