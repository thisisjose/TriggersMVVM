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
        #region VARIABLES
        string _Texto;
        ObservableCollection<VMcategoria> _listaCategorias;
        #endregion

        #region CONSTRUCTOR
        public VMcategoria(INavigation navigation)
        {
            Navigation = navigation;
            MostrarCategorias();
        }
        #endregion
        #region OBJETOS
        public ObservableCollection<VMcategoria> ListaCategorias
        {
            get { return _listaCategorias; }
            set { SetValue(ref _listaCategorias, value); }
        }

        #endregion
        #region PROCESOS
        public async Task ProcesoAsyncrono()
        {

        }
        public void MostrarCategorias()
        {
            //al hacer esto jalamos la data cawn
            ListaCategorias = new ObservableCollection<Mcategorias>(Datos.Dcategorias.MostrarCategorias());
        }
        #endregion
        #region COMANDOS
        public ICommand ProcesoAsynccomand => new Command(async () => await ProcesoAsyncrono());
        public ICommand ProcesoSimpcomand => new Command(MostrarCategorias);
        #endregion
    }
}
