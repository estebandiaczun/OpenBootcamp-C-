using System;

namespace Program
{
    class Program1
    {
        static void Main(string[] args)
        {
            float PrecioHeladera = 100000;
            float DescuentoPorCupon = 20;

            Console.WriteLine("Ingrese su Nombre: ");
            var Nombre = (Console.ReadLine());

            Console.WriteLine("Ingrese su mail: ");
            var Mail = (Console.ReadLine());

            Console.WriteLine("Ingrese un si tiene cupon de descuento ('si' o 'no'): ");
            string? CuponSiNo = (Console.ReadLine());

            if (CuponSiNo == "si")
            {
                    Console.WriteLine("Ingrese su cupon: ");
                    var cuponIngresado = (Console.ReadLine());

                    //Aca abria que comprobar si el cupon ingresado es correcto o no, por ahora todo ingresado es correcto

                    bool cupon = true;

                    switch (cupon)
                    {
                    case true:

                        float ValorDeDescuento = PrecioHeladera * DescuentoPorCupon / 100;
                        Console.WriteLine($"Su precio final es de {PrecioHeladera - ValorDeDescuento}");
                        //Comprar
                        break;

                    case false:
                        Console.WriteLine("Cupon invalido");
                        break;
                    }
            }
            else
            {
                Console.WriteLine($"Su precio final es de {PrecioHeladera}");
            }

        }
    }
    class program2
    {
        public static void Main(string[] args)
        {
            List<string> Progamminglanguage = new List<string>(){
            "C#",
            "Java",
            "C++",
            "Python",
            "Javascript",
            "Php"
            };

            Console.WriteLine("Los lenguajes disponibles son :");
            Console.WriteLine(string.Join(", ", Progamminglanguage) + "\n");

            Console.WriteLine("Selecciones el lenguaje mediante numeros o letras por posicion(1, 2, 3, o a, b, c, etc)");
            string? PosicionIngresada = (Console.ReadLine());
 
                switch (PosicionIngresada?.ToLower())
                {
                    case "1":
                    case "a":
                        Console.WriteLine($"Seleccionaste {Progamminglanguage[0]}");
                        Console.WriteLine("Hola Mundo!");
                        break;
                    case "2":
                    case "b":
                        Console.WriteLine($"Seleccionaste {Progamminglanguage[1]}");
                        break;
                    case "3":
                    case "c":
                        Console.WriteLine($"Seleccionaste {Progamminglanguage[2]}");
                        break;
                    case "4":
                    case "d":
                        Console.WriteLine($"Seleccionaste {Progamminglanguage[3]}");
                        break;
                    case "5":
                    case "e":
                        Console.WriteLine($"Seleccionaste {Progamminglanguage[4]}");
                        break;
                    case "6":
                    case "f":
                        Console.WriteLine($"Seleccionaste {Progamminglanguage[5]}");
                        break;
                    default:
                        Console.WriteLine("Invalido!");
                        break;
                }
            }
        }
    }

