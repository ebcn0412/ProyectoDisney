using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisneyPlus.CODIGO.PILAA
{
    class nodoPila
    {
        public object elemento;
        public nodoPila siguiente;

        public nodoPila(object x)
        {
            elemento = x;
            siguiente = null;
        }

    }
}
