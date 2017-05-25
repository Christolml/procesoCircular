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
            Primero = Primero.Siguiente;
            Ultimo.Siguiente = Primero;

        }

        Proceso Actual = null;
        public Proceso verActual()
        {

            Primero.Siguiente = Actual;

            Primero = Primero.Siguiente;
            return Primero;
        }

        public Proceso siguiente(Proceso entra)
        {
            Proceso sale = entra.Siguiente;

            return sale;
        }

        public Proceso moverActual()
        {
            Proceso Actual = Primero;

            Actual = Actual.Siguiente;

            return Actual;
        }



    }
}
