using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    public class Data
    {
        public  String Mensaje ="Estos son los numeros: ";
        public int Num1 = 5;
        public int Num2 = 8;
    }

    public class Metodo
    {
        Data Datos = new Data();
        public String Concatenar ()
        {
            return Datos.Mensaje + Datos.Num1 + " y " + Datos.Num2;
        }
    }
}
