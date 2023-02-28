namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su nombre");

            var nomb = (Console.ReadLine());

            Console.WriteLine("Bienvendo "+nomb);

            Console.WriteLine("Ingrese la hora actual");

            var hora = (Console.ReadLine());

            Console.WriteLine("La hora es :"+hora);



        }
    }
}