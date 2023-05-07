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
            set { nombre = value; }
        }
        public int Dni 
        {
            get { return dni; }
            set { dni = value; }    
        }

        public string Contraseña 
        {
            get { return contraseña; }
            set { contraseña = value; }
        }

        public bool ComprobarContra(string datoIngresado)
        {
            return (!string.IsNullOrEmpty(datoIngresado) && datoIngresado.Trim() == contraseña.Trim());
        }
    }
}