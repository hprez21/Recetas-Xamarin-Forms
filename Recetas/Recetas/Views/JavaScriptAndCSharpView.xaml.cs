using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Recetas.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class JavaScriptAndCSharpView : ContentPage
    {
        public JavaScriptAndCSharpView()
        {
            InitializeComponent();
            webView.Source = LoadHTMLFileFromResource();
        }
        HtmlWebViewSource LoadHTMLFileFromResource()
        {
            var source = new HtmlWebViewSource();

            // Carga el archivo HTML embebido como un recurso en el PCL
            var assembly = typeof(JavaScriptAndCSharpView).GetTypeInfo().Assembly;
            var stream = assembly.GetManifestResourceStream("Recetas.test.html");
            using (var reader = new StreamReader(stream))
            {
                source.Html = reader.ReadToEnd();
            }
            return source;
        }
        private void OnbtnCallJSClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumber.Text))
            {
                return;
            }
            int number = int.Parse(txtNumber.Text);
            webView.Eval(string.Format("printFactorial({0})", number));
        }
    }
}
