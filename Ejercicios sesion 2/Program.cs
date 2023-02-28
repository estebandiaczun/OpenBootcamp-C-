using System;
namespace HelloWorld
{
    class Program1
    {
        static void Main(string[] args)
        {
            //Ejercicio 1
            Console.WriteLine("Ingrese su nombre");
            var nombre = (Console.ReadLine());

            Console.WriteLine("Ingrese su apellido");
            var apellido = (Console.ReadLine());

            Console.WriteLine("Ingrese su edad");
            var edad = (Console.ReadLine());

            Console.WriteLine("Ingrese si sabe programar, SI O NO");
            var programar = (Console.ReadLine());

            Console.WriteLine("Usted es "+ nombre + " " + apellido + " " + "Y tiene "+ edad + " " + "Y dijo que " + programar + " sabe programar?");

        /*Ejercicio 2
        *Se podrian crear objetos pero lo hago sencillo
        */
        //Coche

        int puertas = 4;
        int ruedas = 4;
        string marca = "Ford";
        bool ITV = true;

        if (ITV == true)
        {
            Console.WriteLine("El coche tiene "+ puertas + " y " + ruedas + "Ruedas, Es de la marca " + marca + "Y tiene la itv actualizada");
        }
        else
        {
            Console.WriteLine("El coche tiene "+ puertas + " " + ruedas + " Es de la marca " + marca + " Y no tiene la itv actualizada");
        }
        //Mesa

        double peso = 20.2;
        int largo = 20;
        string material = "Madera";

        Console.WriteLine("La mesa pesa "+ peso + " " + "Mide " + largo + "Y es de " + material);

        //Ejercicio 3

        Console.WriteLine("Ingrese un numero");
        var num1String = (Console.ReadLine());
        int num1;
        Int32.TryParse(num1String, out num1);

        Console.WriteLine(num1 >= 18);

        Console.WriteLine("a" == "a");

        Console.WriteLine(100 < 150 && 100 > 160);

        Console.WriteLine(100 < 150 && 100 > 60);
        }
}
}