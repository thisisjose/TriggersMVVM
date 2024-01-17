using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TriggersMVVM_JSVE.Modelo;

namespace TriggersMVVM_JSVE.Datos
{
    public class Dcategorias
    {
        public static ObservableCollection<Mcategorias> MostrarCategorias()
        {
            return new ObservableCollection<Mcategorias>()
            {
                new Mcategorias()
                {
                    descripcion = "Cena",
                    numeroItem = 4512,
                    imagen="https://imgbb.su/images/2023/02/08/flores92fa336d49b7eeb4.png",
                    backgroundColor="EAEDF6",
                    textColor="#000000"
                },
                new Mcategorias()
                {
                    descripcion="Hotel",
                    numeroItem=4512,
                    imagen="https://imgbb.su/images/2023/02/08/flores92fa336d49b7eeb4.png",
                    backgroundColor="EAEDF6",
                    textColor="#00000"
                },
                new Mcategorias()
                {
                    descripcion="Fiesta",
                    numeroItem=4215,
                    imagen="https://imgbb.su/images/2023/02/08/flores92fa336d49b7eeb4.png",
                    backgroundColor="EAEDF6",
                    textColor="000000",
                },
                new Mcategorias()
                {
                    descripcion="Flores",
                    numeroItem=4215,
                    imagen="https://imgbb.su/images/2023/02/08/flores92fa336d49b7eeb4.png",
                    backgroundColor="EAEDF6",
                    textColor="000000",
                }
            };
        }
    }
}
