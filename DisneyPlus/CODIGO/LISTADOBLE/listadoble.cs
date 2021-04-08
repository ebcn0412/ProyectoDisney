using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisneyPlus.CODIGO.LISTADOBLE
{
    class listadoble
    {
        public nodo cabeza;
        public nodo fin;


        public listadoble()
        {
            cabeza = null;
            fin = null;
        }

        //verificar listadoble
        public Boolean verificarL()
        {
            return cabeza == null;
        }

        //AQUI ES DONDE SE INGRESA LA LISTA DOBLE AL INICIO
        //ESTE NO SE UTILIZA EN EL PROYECTO
        public listadoble ingresarL(object entrada)
        {
            nodo nuevo;
            nuevo = new nodo(entrada);
            nuevo.adelante = cabeza;
            if (cabeza != null)
            {
                cabeza.atras = nuevo;
                cabeza = nuevo;
            }
            return this;
        }


        //ESTE ES PARA INGRESAR AL FINAL
        public listadoble agregarAlFinal(object entrada)
        {

            nodo nuevo = new nodo();
            nuevo.dato = entrada;
            if (cabeza == null)
            {
                cabeza = nuevo;
                cabeza.adelante = null;
                cabeza.atras = null;
                fin = cabeza;
            }
            else
            {
                fin.adelante = nuevo;
                nuevo.adelante = null;
                nuevo.atras = fin;
                fin = nuevo;
            }

            return this;

        }


        public void recorrerLista()
        {
            nodo actual = new nodo();
            actual = cabeza;
            while (actual != null)
            {
                Console.WriteLine(" " + actual.dato);
                actual = actual.adelante;
            }
        }



        public void eliminar()
        {
            nodo actual;
            Boolean encontrado = false;
            actual = cabeza;

            while ((actual != null) && (!encontrado))
            {
                if (!encontrado)
                {
                    actual = actual.adelante;
                }
            }
            if (actual != null)
            {

                if (actual == cabeza)
                {
                    cabeza = actual.adelante;
                    if (actual.adelante != null)
                    {
                        actual.adelante.atras = null;
                    }
                }
                else if (actual.adelante != null)
                {
                    actual.atras.adelante = actual.adelante;
                    actual.adelante.atras = actual.atras;
                }
                else
                {
                    actual.atras.adelante = null;
                }
                actual = null;
            }
        }




    }
}
