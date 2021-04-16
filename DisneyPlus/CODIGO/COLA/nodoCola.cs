using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisneyPlus.CODIGO.COLA
{
    class nodoCola
    {

        //declaracion de atributos :V
        public Object elemento;
        public nodoCola siguiente;


        //declaracion del nodo :v
        public nodoCola(Object x)
        {
            elemento = x;
            siguiente = null;
        }


    }
}
