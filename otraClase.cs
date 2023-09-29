using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenEric_SLE
{
    internal class otraClase
    {
        //curp[curp.Length/2]

        /*
        public void CurpPersona(string curp)
        {
            if (  curp.Length > 18)
            {
                Console.WriteLine("No puede existir esa curp");
            }

            //DateOnly fecha = DateOnly.ParseExact(year, "yy/MM/dd", CultureInfo.InvariantCulture);

            else if (curp[curp.Length /2] = "F")
            {

                Console.WriteLine("Mujer");
            }
        */

        //INTERVALO DE VALORES

        public void IntervaloNumeros(int numero1, int numero2)
        {
            if (numero1 == numero2)
            {
                Console.WriteLine("El intervalo de valores son iguales");
            }
          else  if (numero1 < numero2)
            {
                for (int i = numero1; i <= numero2; i++)
                {
                    numero1 = +i;
                    Console.WriteLine("la secuencia de los números es " + numero1);
                }
            }
            //NO JALA ALREVEZ
            else if (numero1 > numero2) 
            {
                for (int i = numero2; i <= numero1; i++)
                {
                    numero2 = +i;
                    Console.WriteLine("la secuencia de los números es " + numero2);
                }
            }

        }


        public int TablasMultiplicar(int numero2)
        {
            

            if (numero2 ==0)
            {
                return 1;
            }

            return   numero2 * TablasMultiplicar(numero2 -1);
        }















    }
}
