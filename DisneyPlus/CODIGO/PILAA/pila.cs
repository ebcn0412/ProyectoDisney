using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisneyPlus.CODIGO.PILAA
{
    class Pila
    {

        public nodoPila primero;

        public Pila()
        {
            primero = null;
        }


        public Boolean verificarPila()
        {
            return primero == null;
        }


        public void ingresarP(object elemento)
        {
            nodoPila nuevo;
            nuevo = new nodoPila(elemento);
            nuevo.siguiente = primero;
            primero = nuevo;
        }



        public void vaciarP()
        {
            nodoPila noP;

            while (!verificarPila())
            {
                noP = primero;
                primero = primero.siguiente;
                noP.siguiente = null;
            }
        }




        public object deleteP()
        {
            object variableP;
            try
            {
                if (!verificarPila())
                {
                    variableP = primero.elemento;
                    primero = primero.siguiente;
                }
                else
                {
                    throw new Exception("No se puede eliminar de una pila vacia");
                }
            }
            catch (Exception)
            {

                variableP = null;
            }
            return variableP;
        }


        public object primeroPila()
        {
            if (verificarPila())
            {
                throw new Exception("Pila vacia, no se puede leer ningun elemento");
            }

            return primero.elemento;
        }

        public object recorrerPila(object x)
        {
            nodoPila actual = new nodoPila(x);
            actual = primero;
            object datos;
            if (primero != null)
            {
                while (actual != null)
                {
                    Console.WriteLine(" " + actual.elemento);
                    actual = actual.siguiente;
                }
            }
            else
            {
                Console.WriteLine("pila vacia");
            }
            return primero.elemento;
        }



    }
}
