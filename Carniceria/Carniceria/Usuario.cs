namespace Carniceria
{
    public class Usuario
    {
        string nombre;
        int dni;
        string usuario;
        int contraseña;

        public Usuario(string nombre, int dni, string user, int contraseña)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.usuario = user;
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
        public string User 
        {
            get { return usuario; }
        }
        public int Contraseña 
        {
            get { return contraseña; }
        }

        public bool ComprobarContra(string datoIngresado)
        {
            return (!string.IsNullOrEmpty(datoIngresado) && datoIngresado.Trim() == contraseña.Trim());
        }
    }
}