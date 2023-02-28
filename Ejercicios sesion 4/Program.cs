using System;

namespace Program
{
    class Program1
    {
        static void Main(string[] args)
        {
            //Primer Ejercicio

            Console.WriteLine("Ingrese un numero para la tabla: ");
            var NumInString = (Console.ReadLine());
            int num;
            Int32.TryParse(NumInString, out num);


            int NumeroMultiplicador = 0;

            while (NumeroMultiplicador <10)
            {
                NumeroMultiplicador++;
                Console.WriteLine(num + " X " + NumeroMultiplicador + " = " + (num * NumeroMultiplicador));
            }

            //Segundo ejercicio

            float? numero;
            int contador = 100;

            Console.WriteLine("Ingrese un numero: ");
            numero = float.Parse(Console.ReadLine());

            var NumeroPositivoNegativo = (numero > 0) ? $"El numero {numero} es positivo" : $"El numero {numero} es negativo";
            Console.WriteLine(NumeroPositivoNegativo);

            do
            {
                Console.WriteLine(numero);
                numero++;
            }while (numero < contador);

            //Tercer ejercicio

            Console.WriteLine("Ingrese un simbolo: ");
            int simbolo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el ancho: ");
            int ancho = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el alto: ");
            int alto = Convert.ToInt32(Console.ReadLine());
 
            for (int fila = 1; fila <= alto; fila++)
            {
                for (int columna = 1; columna <= ancho; columna++)
                {
                    if ((fila == 1) || (fila == alto))
                    {
                        Console.Write(simbolo);
                    }
                    else
                    {
                        if ((columna == 1) || (columna == ancho))
                        {
                            Console.Write(simbolo);
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}