using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace demo.Core.Services
{
        public class NombreGenesisService : INombreGenesisService
        {
            public List<Nombre> _names;

        public NombreGenesisService()
        {
            _names = new List<Nombre>
                {
                    new Nombre()
                    {
                        _name = "Sebastian",
                    },
                    new Nombre()
                    {
                        _name = "Angelica",
                    },
                    new Nombre()
                    {
                        _name = "Natalia",
                    },
                    new Nombre()
                    {
                        _name = "Octavio",
                    },
               };

        }

        public List<Nombre> CreateNewNombre()
            {
               // _names = new List<Nombre>
               // {
               //     new Nombre()
               //     {
               //         _name = "Sebastian",
               //     },
               //     new Nombre()
               //     {
               //         _name = "Angelica",
               //     },
               //     new Nombre()
               //     {
               //         _name = "Natalia",
               //     },
               //     new Nombre()
               //     {
               //         _name = "Octavio",
               //     },
               //};

            return _names;
            }


       public void deleteItem(int index)
        {
            this._names.RemoveAt(index);
        }

        public int numbItems()
        {
            return _names.Count();
        }

    }
}
