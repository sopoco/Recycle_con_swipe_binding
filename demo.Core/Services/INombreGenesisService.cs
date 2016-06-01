using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Core.Services
{
    public interface INombreGenesisService
    {
        List<Nombre> CreateNewNombre();
        void deleteItem(int index);
    }
}
