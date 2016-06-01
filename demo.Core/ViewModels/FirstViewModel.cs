using System;
using System.Collections.Generic;
using MvvmCross.Core.ViewModels;
using demo.Core.Services;

namespace demo.Core.ViewModels
{
    public class FirstViewModel : BaseViewModel
    {

        public FirstViewModel(INombreGenesisService service)
        {
            //var newList = new List<Nombre>();
            //for (int i = 0; i < 15; i++)
            //{
            //    var newName =  service.CreateNewNombre(i.ToString());
            //    newList.Add(newName);
            //}

            //Nombres = newList;
        }

        private List<Nombre> _nombres;
        public List<Nombre> Nombres
        {
            get { return _nombres; }
            set { _nombres = value; RaisePropertyChanged(()  => Nombres); }
        }

        public void ShowMenu()
        {
            ShowViewModel<RecyclerViewModel>();
        }
    }
}
