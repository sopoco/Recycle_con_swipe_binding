using demo.Core.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Core.ViewModels
{
    public class RecyclerViewModel : BaseViewModel
    {
        //private IList<Nombre> Items;
        NombreGenesisService lista;

        public RecyclerViewModel()
        {
            //Nombres lista = new Nombres();
            lista = new NombreGenesisService();

            Items = new ObservableCollection<Nombre>
            {
                new Nombre()
                {
                    _name = lista._names[0]._name,
                },

                 new Nombre()
                {
                    _name = lista._names[1]._name,
                },

                new Nombre()
                {
                    _name = lista._names[2]._name,
                },
                new Nombre()
                {
                    _name = lista._names[3]._name,
                },
            };
        }

        private ObservableCollection<Nombre> _items;

        public ObservableCollection<Nombre> Items
        {
            get { return _items; }
            set
            {
                _items = value;
                RaisePropertyChanged(() => Items);
            }
        }
    }
}
   



