using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisneyPlus.CODIGO.LISTADOBLE
{
    class nodo
    {
        public object dato;
        public nodo adelante;
        public nodo atras;

        public nodo() 
        {

        }

        public nodo(object entrada)
        {
            dato = entrada;
            adelante = atras = null;
        }
    }

}
