using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace Recetas.Views
{
    public class EntryKeyboardFlags : ContentPage
    {
        public EntryKeyboardFlags()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Keyboard Flags" },
                    new Entry { Keyboard = Keyboard.Create(KeyboardFlags.CapitalizeSentence), Placeholder = "Entry Capitalizado" },
                    new Entry {Keyboard = Keyboard.Create(KeyboardFlags.Spellcheck), Text="Entry con corrección ortográfica" },
                    new Entry {Keyboard = Keyboard.Create(KeyboardFlags.Suggestions), Text= "Entry con sugerencias" },
                    new Entry {Keyboard = Keyboard.Create(KeyboardFlags.All), Text = "Entry con todas las banderas" }
                }
            };
        }
    }
}
