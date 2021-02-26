using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operaciones_CSharp
{
    public class Clase_CSharp
    {
        public string operacionSuma(double numero1, double numero2)
        {
            return Convert.ToString(numero1 + numero2);
        }
        public string operacionResta(double numero1, double numero2)
        {
            return Convert.ToString(numero1 - numero2);
        }
    }
}
