using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TriggersMVVM_JSVE.Modelo;
using Xamarin.Forms;
using TriggersMVVM_JSVE.VistaModelo;


namespace TriggersMVVM_JSVE.VistaModelo
{
    public class VMcategoria : BaseViewModel
    {
        string _Texto;
        ObservableCollection<Mcategorias> _listaCategorias;

        public VMcategoria(INavigation navigation)
        {
            Navigation = navigation;
            MostrarCategoria();
        }


        public ObservableCollection<Mcategorias> ListaCategorias
        {
            get { return _listaCategorias; }
            set { SetProperty(ref _listaCategorias, value); }
        }



        public async Task ProcesoAsyncrono()
        {

        }

        public void MostrarCategoria()
        {
            _listaCategorias = new ObservableCollection<Mcategorias>(Datos.Dcategorias.MostrarCategorias());

        }


        public ICommand ProcesoAsyncomand => new Command(async () => await ProcesoAsyncrono());
        public ICommand ProcesoSimpcomand => new Command(MostrarCategoria);

    }
}