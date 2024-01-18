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
        string _Texto;
        ObservableCollection<Mcategorias> _listaCategorias;
        bool _activadorAnimacionImg;
        string _imagen;

        public VMcategoria(INavigation navigation)
        {
            Navigation = navigation;
            MostrarCategoria();
        }

        public string Imagen
        {
            get { return _imagen; }
            set { SetValue(ref _imagen, value); }
        }

        public ObservableCollection<Mcategorias> ListaCategorias
        {
            get { return _listaCategorias; }
            set { SetProperty(ref _listaCategorias, value); }
        }

        public bool ActivadorAnimacionImg
        {
            get { return _activadorAnimacionImg; }
            set { SetValue(ref _activadorAnimacionImg, value); }
        }
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
                ListaCategorias[index].textColor = "#FFFFFF";
                ListaCategorias[index].backgroundColor = "#FF506B";
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

        public void MostrarCategoria()
        {
            _listaCategorias = new ObservableCollection<Mcategorias>(Datos.Dcategorias.MostrarCategorias());

        }


        public ICommand ProcesoAsyncomand => new Command(async () => await ProcesoAsyncrono());
        public ICommand ProcesoSimpcomand => new Command(MostrarCategoria);

    }
}