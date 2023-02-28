using System.Threading.Tasks;
namespace Ejercicios_sesion_3
{
    public class Usuario
    {
        public Usuario(string firtsName, string secondName, string surName, string? contactPhone, string? address, string? email, bool isNew)
        {
            FirtsName = firtsName;
            SecondName = secondName;
            SurName = surName;
            ContactPhone = contactPhone;
            Address = address;
            Email = email;
            IsNew = isNew;
        }

        public string FirtsName { get; set; } = null!;
        public string SecondName { get; set; } = null!;
        public string SurName { get; set; } = null!;
        public string? ContactPhone { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public bool IsNew { get; set; }

        public void Presentar()
        {
            if (IsNew == true)
            Console.WriteLine("Bienvenido " + FirtsName + " " + SecondName + " " + SurName + ", su telefono de contacto es:" + " " + ContactPhone + " Su direccion:" + " " + Address + " Email:" + Email + " Y es un usuario nuevo");
            else
            Console.WriteLine("Bienvenido " + FirtsName + " " + SecondName + " " + SurName + ", su telefono de contacto es:" + ContactPhone + " Su direccion:" + Address + "Email:" + Email + "Y no es un usuario nuevo");
        }



    }
}