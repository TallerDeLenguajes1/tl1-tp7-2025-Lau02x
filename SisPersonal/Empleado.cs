namespace Empleado
{
    enum Cargos
    {
        Auxiliar = 0,
        Administrativo = 1,
        Ingeniero = 1,
        Especialista = 2,
        Investigador = 3
    }
    public class Empleado
    {
        public string nombre;
        public string apellido;
        public DateTime fechaDeNacimiento;
        public char estadoCivil;
        public DateTime fechaDeIngreso;
        public double sueldo;
        public Cargos cargo;
    }
    public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }
        public double Sueldo
        {
            get => sueldo;
            set => sueldo = value;
        }
        public DateTime FechaDeNacimiento
        {
            get => fechaDeNacimiento;
            set => fechaDeNacimiento = value;
        }
         public DateTime FechaDeIngreso
        {
            get => fechaDeIngreso;
            set => fechaDeIngreso = value;
        }

 }