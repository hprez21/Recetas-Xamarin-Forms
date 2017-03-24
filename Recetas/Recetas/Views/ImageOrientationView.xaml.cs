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
    public partial class ImageOrientationView : ContentPage
    {
        public ImageOrientationView()
        {
            InitializeComponent();
            SizeChanged += ImageOrientationView_SizeChanged;
        }

        private void ImageOrientationView_SizeChanged(object sender, EventArgs e)
        {
            imgBackground.Source = ImageSource.FromFile(Height > Width ? "Horizontal.png" : "Vertical.png");
            
            //Código equivalente con if:
            //if(Height > Width)
            //{
            //    imgBackground.Source = "Vertical.png";
            //}
            //else
            //{
            //    imgBackground.Source = "Horizontal.png";
            //}
        }
    }
}
