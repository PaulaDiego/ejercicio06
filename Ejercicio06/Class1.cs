using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    public class Data
    {
        protected  String Mensaje ="Estos son los numeros: ";
        protected int Num1 = 5;
        protected int Num2 = 8;
    }

    public class Metodo : Data
    {

        public String Concatenar ()
        {
            return Mensaje + Num1 + " y " + Num2;
        }
    }
}
