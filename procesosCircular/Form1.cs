using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace procesosCircular
{
    public partial class Form1 : Form
    {
        static Random aleatorio = new Random();
        int probabilidad, tiempo;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Proceso circular
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProcesoCircular_Click(object sender, EventArgs e)
        {
            //

            Ciclo miCiclo = new Ciclo();

            bool avisado = false;
            string mostrar = "", mostrar2 = "";   //cadenas en las cuales mostrare los reusltados
            int contadorAgregados = 0, contadorAtendidos = 1, contadorCiclosVacios = 0, lugar=1;
            int sumaCiclosAgregados = 0, sumaCiclosAtendidos = 0;

            Proceso actual = miCiclo.verActual();    //este actual me sirve para saber en que elemento estoy durante el proceso circular, lo inicializo como null
            //que tiene el valor de miciclo.veracutal para que dentro del for le pueda estar asignando valores de nuestro nodo en este caso el proceso


            for (int i = 1; i <= 200; i++)
            {

                probabilidad = aleatorio.Next(1, 5);     //debe ser 5
                tiempo = aleatorio.Next(1,13);        //debe ser 13

                mostrar2 += "La probabilidad fue: " + probabilidad + " y el tiempo fue: " + tiempo + "\r\n";

                try    //este me sirve para que cuando ya hemos estado haciendo los procesos del for llegara en casos en que solamente habra un ciclo y cuando ese se
                {        //se acabe tengo que volver a poner mi actual como null para después asignarle un valor nuevo del que se genere
                    if (actual.Tiempo == 0)
                        if (actual != miCiclo.verActual())     //vere si ese ultimo que tiene tiempo de 0 es el primero de la lista o de los que estan despues de primero
                        {
                            actual = actual.Siguiente;
                            avisado = true;
                        }
                        else   //con este me dice que el ultimo proceso con tiempo 0 es el primero de la lista, osea que es el unico proceso que existia y por lo tanto
                        {     //ponemos el ciclo nuevamente en null para despues poderle darle nuevos valores
                            miCiclo.ponerVacio();
                            actual = miCiclo.verActual();
                        }
                }
                catch { }


                if (probabilidad == 1)   //con este agrego
                {
                    Proceso nuevo = new Proceso(tiempo,lugar);
                    miCiclo.agregarProceso(nuevo);
                    sumaCiclosAgregados += nuevo.Tiempo;
                    contadorAgregados++;
                    lugar++;

                }


                if(avisado==false)        //este me sirve para estar cambiando la posición del actual de los elementos de mi lista
                {                         //si actual es nulo le agrego lo primero que hay en la lista con verActual (esto gracias a que lo pusimos abajo de nuestra función de agregar)
                    if (actual == null)
                        actual = miCiclo.verActual();
                    else
                        actual = actual.Siguiente;
                }



                if (actual == null)      //con este veo si en cada ciclo esta vacio
                {
                    contadorCiclosVacios++;
                }

                if (actual != null)        //con este muestro los procesos unos y les resto de su tiempo y elimino cuando tengan 0 de tiempo
                {

                    mostrar += "Proceso: " + Convert.ToString(actual.Lugar) + " ciclo # " + Convert.ToString(actual.Tiempo) + "\r\n";
                    sumaCiclosAtendidos++;

                    actual.Tiempo--;

                    if(actual.Tiempo == 0)    //con este saco de la lista
                    {
                        miCiclo.sacarPrimero(actual);
                        contadorAtendidos++;
                    }

                }

                avisado = false;
            }

            txtResultadoProcesos.Text = mostrar;

            txtInformación.Text = " Ciclos vacios: " + contadorCiclosVacios + "\r\n Procesos atendidos: " + (contadorAtendidos - 1) + "\r\n Procesos no " +
                "atendidos y/o no terminados: " + (contadorAgregados - contadorAtendidos + 1) + "\r\n Ciclos no atendidos: " + (sumaCiclosAgregados - sumaCiclosAtendidos);

            txtCiclos.Text = mostrar2;
        }
    }
}
