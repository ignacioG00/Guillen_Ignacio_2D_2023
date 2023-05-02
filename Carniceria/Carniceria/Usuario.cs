namespace Carniceria
{
    public class Usuario
    {
        string nombre;
        int dni;
        string contraseña;

        public Usuario(string nombre, int dni ,string contraseña)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.contraseña = contraseña;
        }
        public string Nombre
        {
            get { return nombre; }
        }
        public int Dni 
        {
            get { return dni; }
        }

        public string Contraseña 
        {
            get { return contraseña; }
        }

        public bool ComprobarContra(string datoIngresado)
        {
            return (!string.IsNullOrEmpty(datoIngresado) && datoIngresado.Trim() == contraseña.Trim());
        }
    }
}