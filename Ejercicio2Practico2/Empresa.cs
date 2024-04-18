using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Practico2
{
    internal class Empresa
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public void getDatoEmpresa()
        {
            Console.WriteLine("Empresa {0} con Id {1}", Name, ID);
        }
    }
}
