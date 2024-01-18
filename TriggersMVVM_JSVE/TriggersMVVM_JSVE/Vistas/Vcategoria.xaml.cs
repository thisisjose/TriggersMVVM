using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriggersMVVM_JSVE.VistaModelo;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TriggersMVVM_JSVE.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Vcategoria : ContentPage
    {
        public Vcategoria()
        {
            InitializeComponent();
            BindingContext = new VMcategoria(Navigation);
        }
    }
}