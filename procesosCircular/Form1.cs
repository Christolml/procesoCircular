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

        private void btnProcesoCircular_Click(object sender, EventArgs e)
        {

            Ciclo miCiclo = new Ciclo();
            Ciclo mover = new Ciclo();

            string mostrar = "", mostrar2 = "";
            int contadorAgregados = 0, contadorAtendidos = 1, contadorCiclosVacios = 0;
            int sumaCiclosAgregados = 0;
            int sumaCiclosAtendidos = 0;

            for (int i = 1; i <= 200; i++)
            {
                probabilidad = aleatorio.Next(1, 5);
                tiempo = aleatorio.Next(1, 5);        //debe ser 15

                mostrar2 += "La probabilidad fue: " + probabilidad + " y el tiempo fue: " + tiempo + "\r\n";

                if (probabilidad == 1)   //con este agrego
                {
                    Proceso nuevo = new Proceso(tiempo);
                    miCiclo.agregarProceso(nuevo);
                    sumaCiclosAgregados += nuevo.Tiempo;
                    contadorAgregados++;

                }


                if (miCiclo.verActual() == null)      //con este veo si en cada ciclo esta vacio
                {
                    contadorCiclosVacios++;
                }

                if (miCiclo.verActual() != null)        //con este muestro los procesos unos y les resto de su tiempo y elimino cuando tengan 0 de tiempo
                {
                    mostrar += "Proceso: " + contadorAtendidos + " ciclo # " + Convert.ToString(miCiclo.verActual().Tiempo) + "\r\n";
                    sumaCiclosAtendidos++;


                    miCiclo.siguiente(miCiclo.verActual()).Tiempo--;
                    
                    if (miCiclo.verActual().Siguiente != null)
                    {
                        miCiclo.moverActual()
                    }
                        miCiclo.verActual().Siguiente.Tiempo--;
                    else
                        miCiclo.verActual().Tiempo--;



                    if (miCiclo.verActual().Tiempo == 0)
                    {

                        miCiclo.sacarPrimero();
                        contadorAtendidos++;
                    }

                }

            }

            txtResultadoProcesos.Text = mostrar;

            txtInformación.Text = " Ciclos vacios: " + contadorCiclosVacios + "\r\n Procesos atendidos: " + (contadorAtendidos - 1) + "\r\n Procesos no " +
                "atendidos y/o no terminados: " + (contadorAgregados - contadorAtendidos + 1) + "\r\n Ciclos no atendidos: " + (sumaCiclosAgregados - sumaCiclosAtendidos);

            txtCiclos.Text = mostrar2;
        }
    }
}
