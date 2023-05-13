using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Carniceria
{
    public class Validaciones
    {
        public static bool ValidarMail(string email) 
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (Regex.IsMatch(email, emailPattern) && !String.IsNullOrEmpty(email))
            {
                // La dirección de correo electrónico es válida
                return true;
            }
            else
            {
                // La dirección de correo electrónico es inválida
                return false;
            }
        }
        public static void ValidarIngreso(Usuario userIngresado, string email, string contra)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (Regex.IsMatch(email, emailPattern) && !String.IsNullOrEmpty(email))
            {
                // La dirección de correo electrónico es válida
                userIngresado = Negocio.LoguearUsuario(email, contra);
            }
            else if (!Regex.IsMatch(email, emailPattern))
            {
                // La dirección de correo electrónico es inválida
            }


        }
    }
}
