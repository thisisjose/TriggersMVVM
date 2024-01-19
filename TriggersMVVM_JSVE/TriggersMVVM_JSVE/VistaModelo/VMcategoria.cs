using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TriggersMVVM_JSVE.Modelo;
using Xamarin.Forms;
using TriggersMVVM_JSVE.VistaModelo;
using System.Linq;
using Xamarin.Forms.Internals;

namespace TriggersMVVM_JSVE.VistaModelo
{
    public class VMcategoria : BaseViewModel
    {
        #region VARIABLES
        bool _activadorAnimacionImg;
        string _imagen;
        ObservableCollection<Mcategorias> _listaCategorias;
        #endregion
        #region CONSTRUCTOR
        public VMcategoria(INavigation navigation)
        {
            Navigation = navigation;
            MostrarCategorias();
        }
        #endregion
        #region OBJETOS
        public string Imagen
        {
            get { return _imagen; }
            set { SetValue(ref _imagen, value); }
        }
        public bool ActivadorAnimacionImg
        {
            get { return _activadorAnimacionImg; }
            set { SetValue(ref _activadorAnimacionImg, value); }
        }
        public ObservableCollection<Mcategorias> ListaCategorias
        {
            get { return _listaCategorias; }
            set { SetValue(ref _listaCategorias, value); }
        }
        #endregion
        #region PROCESOS
        public void Seleccionar(Mcategorias modelo)
        {
            var index = ListaCategorias
                .ToList()
                .FindIndex(p => p.descripcion == modelo.descripcion);
            Imagen = modelo.imagen;
            if (index > -1)
            {
                Deseleccionar();
                ActivadorAnimacionImg = true;
                ListaCategorias[index].selected = true;
                ListaCategorias[index].textColor = "FFFFFF";
                ListaCategorias[index].backgroundColor = "FF506B";
            }
        }
        public void Deseleccionar()
        {
            ListaCategorias.ForEach((item) =>
            {
                ActivadorAnimacionImg = false;
                item.selected = false;
                item.textColor = "#000000";
                item.backgroundColor = "#EAEDF6";
            });
        }

        public async Task ProcesoAsyncrono()
        {

        }
        public void MostrarCategorias()
        {
            //Para agarrar todos los datos
            ListaCategorias = new ObservableCollection<Mcategorias>(Datos.Dcategorias.MostrarCategorias());
        }
        #endregion


        public ICommand ProcesoAsyncomand => new Command(async () => await ProcesoAsyncrono());
        public ICommand ProcesoSimpcomand => new Command(MostrarCategorias);
        public ICommand Seleccionarcomand => new Command<Mcategorias>((p) => Seleccionar(p));

    }
}