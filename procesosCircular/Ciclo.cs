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


        public void sacarPrimero()
        {
            if(Primero == Ultimo)
            {
                Primero = null;
                Ultimo = null;
            }
            else
            {
                Primero = Primero.Siguiente;
                Ultimo.Siguiente = Primero;
            }


        }


        public Proceso verActual()
        {
            if (Primero != null)
            {
                Ultimo = Ultimo.Siguiente;
                Primero = Primero.Siguiente;
            }
            else
                return Primero;


            return Primero;
        }


    }
}
