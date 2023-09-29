namespace ExamenEric_SLE
{
    internal class Program
    {
        static void Main(string[] args)
        {

            otraClase otraClase1 = new otraClase();
            //CURP
            /*
            Console.WriteLine("Esribe la curp");
            string curp= Convert.ToString(Console.ReadLine());

            otraClase1.CurpPersona(curp);
            
            
            */

            //INTERVALO DE NUMEROS
            // QUE NO JALA DEL 25 AL 20 PERO SI ALREVEZ :(
            /*
            Console.WriteLine("Escribe el primer numero");
            int numero1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escribe el segundo");
            int numero2=Convert.ToInt32(Console.ReadLine());

            otraClase1.IntervaloNumeros(numero1, numero2);

            */

            //PROBLEMA RECURSIVO
            
            Console.WriteLine("Escribe el numero");
            int numero2= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(otraClase1.TablasMultiplicar(numero2));
            
        }

    }
}