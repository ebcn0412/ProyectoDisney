using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisneyPlus.CODIGO.COLA
{
    class cola
    {

        nodoCola prim;
        nodoCola ultimo;

        public cola()
        {
            prim = ultimo = null;
        }


        public Boolean verificarCola()
        {
            return (prim == null);
        }



        public void ingresar(Object elemento)
        {
            nodoCola a;
            a = new nodoCola(elemento);
            if (verificarCola())
            {
                prim = a;
            }
            else
            {
                ultimo.siguiente = a;
            }
            ultimo = a;
        }


        public object eliminar()
        {
            object obc;
            try
            {
                if (!verificarCola())
                {
                    obc = prim.elemento;
                    prim = prim.siguiente;
                }
                else
                {
                    throw new Exception("No se puede eliminar de una cola vacia");
                }
            }
            catch (Exception)
            {
                obc = null;
            }
            return obc;
        }


        public object primeroCola()
        {
            if (verificarCola())
            {
                throw new Exception("Pila vacia, no se puede leer ningun elemento");
            }

            return prim.elemento;
        }

    }
}
