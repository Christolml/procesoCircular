using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace procesosCircular
{
    class Proceso
    {
        public Proceso Siguiente { get; set; }
        //public Proceso Anterior { get; set; }


        public int Tiempo { get; set; }


        public Proceso(int tiempo)
        {
            this.Tiempo = tiempo;
        }
    }
}
