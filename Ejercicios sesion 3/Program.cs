using Ejercicios_sesion_3;


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario NewUser = new Usuario("Esteban", "Nicolas", "Diaczun", "11232323", "callelibertador", "estebandiaczun@gmail.com", true);

            NewUser.Presentar();

        }
    }
}
