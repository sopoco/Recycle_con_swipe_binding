using System.Collections.ObjectModel;

namespace demo.Core.Services
{
    public class Nombre
    {
        public string _name;
        public string name
        {
            get { return _name; }
        }
    }

    //public class Nombres
    //{
    //    ObservableCollection<Nombre> _nombres = new ObservableCollection<Nombre>
    //    {
    //        new Nombre { _name = "Sebastian" },
    //        new Nombre { _name = "Natalia" },
    //        new Nombre { _name = "Angelica" },
    //        new Nombre { _name = "Miguel" },
    //        new Nombre { _name = "Octavio" }
    //    };

    //    private ObservableCollection<Nombre> mNombres;

    //    public Nombres()
    //    {
    //        mNombres = _nombres;
    //    }

    //    public int NumItems
    //    {
    //        get { return _nombres.Count; }
    //    }

    //    public Nombre this[int i]
    //    {
    //        get { return _nombres[i]; }
    //    }
    //}
}
