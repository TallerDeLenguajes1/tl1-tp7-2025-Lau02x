using System.Reflection.Metadata.Ecma335;

namespace Empleados
{
    public enum Cargos
    {
        Auxiliar = 0,
        Administrativo = 1,
        Ingeniero = 2,
        Especialista = 3,
        Investigador = 4
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

        public int Edad
        {
            get
            {
                int edad = DateTime.Now.Year - FechaDeNacimiento.Year;
                if (DateTime.Now < FechaDeNacimiento.AddYears(edad))
                {
                    edad--;
                }
                return edad;
            }
        }
        static int Antiguedad(Empleado emp) => DateTime.Now.Year- emp.fechaDeIngreso.Year;
        static int Jubilacion(Empleado emp) => 65 - emp.Edad;
        static double Salario(Empleado emp)
        {
            double adicional;
            double adicional_casado=0;
            if (Antiguedad(emp) <= 15)
            {
                adicional = (double)Antiguedad(emp) / 100;
            }
            else
            {
                adicional = 0.25;
            }
            if (emp.cargo == Cargos.Ingeniero || emp.cargo == Cargos.Especialista)
            {
                adicional += 0.50;   
            }
            if (emp.estadoCivil == 'c')
            {
                adicional_casado = 150000;
            }
            return emp.sueldo * adicional + adicional_casado;
        }  

    
    }
   

 }