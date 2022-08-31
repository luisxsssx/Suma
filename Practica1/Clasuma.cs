using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    internal class Clasuma
    {
        //campos propiedades, como es
        private int n1;
        private int n2;

        //constructor
        public Clasuma(int n1, int n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }

        // métodos, acción, lo que hace
        public int sumar()
        {
            return (n1 + n2);
        }
    }
}