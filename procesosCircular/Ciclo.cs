using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace procesosCircular
{
    class Ciclo
    {
        private Proceso Primero;
        private Proceso Ultimo;

        public Ciclo()
        {
            Primero = null;
            Ultimo = null;
        }


        public void agregarProceso(Proceso nuevo)
        {

            if (Primero == null)
            {
                Primero = nuevo;
                Primero.Siguiente = nuevo;
                Ultimo = Primero;
                //contador++;
            }
            else
            {
                    Ultimo.Siguiente = nuevo;
                    nuevo.Siguiente = Primero;
                    Ultimo = nuevo;
                    //contador++;
            }

        }

        public void ponerVacio()
        {
            Primero = null;
            Ultimo = null;
        }

        public void sacarPrimero(Proceso sacado)
        {
            Proceso Actual = Primero;
            Proceso Anterior = null;
            bool encontrado = false;            //sirve para indicarme cuando el codigo coincida con el que busco

            do
            {
                if (Actual == sacado)
                {
                    if (Actual == Primero)
                    {
                        Primero = Primero.Siguiente;
                        Ultimo.Siguiente = Primero;
                    }
                    else if (Actual == Ultimo)
                    {
                        Anterior.Siguiente = Primero;
                        Ultimo = Anterior;
                    }
                    else
                    {
                        Anterior.Siguiente = Actual.Siguiente;
                    }
                    encontrado = true;
                }
                Anterior = Actual;
                Actual = Actual.Siguiente;
            }
            while (Actual != Primero && encontrado != true);



            //if (Primero == Ultimo)
            //{
            //    Primero = null;
            //    Ultimo = null;
            //}
            //else
            //{
            //    Primero = Primero.Siguiente;
            //    Ultimo.Siguiente = Primero;
            //}


        }


        public Proceso verActual()
        {
            return Primero;
        }


    }
}
