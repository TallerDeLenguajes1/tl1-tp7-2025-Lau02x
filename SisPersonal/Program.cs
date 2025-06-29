using Empleados;

Empleado[] empleados = new Empleado[3];
double totalSalarios=0;
 empleados[0]= new Empleado
{
    nombre = "Pancracio",
apellido = "Castro",
estadoCivil = 'c',
fechaDeNacimiento = new DateTime(2002, 12, 22, 17, 45, 05),
fechaDeIngreso = new DateTime(2025, 12, 23, 18, 35, 07),
sueldo = 350000,
cargo = Cargos.Ingeniero,
};

 empleados[1]= new Empleado
{
    nombre = "Carlos",
apellido = "Villagran",
estadoCivil = 's',
fechaDeNacimiento= new DateTime(1970, 12, 22, 17, 45, 05),
fechaDeIngreso =   new DateTime(2007, 12, 23, 18,45,07),
sueldo = 1500000,
cargo = Cargos.Administrativo
};
empleados[2] = new Empleado
{
nombre = "Claudio",
apellido = "Rodriguez",
estadoCivil = 's',
fechaDeNacimiento = new DateTime(2000, 12, 22, 17, 45, 05),
fechaDeIngreso = new DateTime(2025, 11, 21, 18, 35, 07),
sueldo = 450000,
cargo = Cargos.Especialista,
};


Empleado Proximo_jubilado= null;
int menorTiempo = 100;
foreach (Empleado emp in empleados)
{

    Mostrar(emp);
    totalSalarios += Salario(emp);
    if (emp.Jubilacion <= menorTiempo)
    {
        Proximo_jubilado = emp;
        menorTiempo = emp.Jubilacion;
    }
     
}
Console.WriteLine($"El total de los salarios es : {totalSalarios}");
if (Proximo_jubilado != null)
{
    Console.WriteLine($"Y el proximo a jubilarse es : {Proximo_jubilado.nombre} {Proximo_jubilado.apellido}");
}
else
{
    System.Console.WriteLine("No hay proximo empleado");
 }



     void Mostrar(Empleado empleadoMostrar)
    {
        Console.WriteLine($"Nombre: {empleadoMostrar.Nombre}");
        Console.WriteLine($"Cargo: {empleadoMostrar.cargo}");
        Console.WriteLine($"Estado civil: {empleadoMostrar.estadoCivil}");
        Console.WriteLine($"Edad: {empleadoMostrar.Edad}");
        Console.WriteLine($"Antigüedad: {empleadoMostrar.Antiguedad} años");
        Console.WriteLine($"Años para jubilarse: {empleadoMostrar.Jubilacion}");
        Console.WriteLine($"Salario: ${Salario(empleadoMostrar)}");
        Console.WriteLine("-------------------------------------");
    }


     double Salario(Empleado emp)
        {
            double adicional=1;
            double adicional_casado=0;
            if (emp.Antiguedad <= 15)
            {
                adicional += (double)emp.Antiguedad / 100;
            }
            else
            {
                adicional = 1.25;
            }
            if (emp.cargo == Cargos.Ingeniero || emp.cargo == Cargos.Especialista)
            {
                adicional +=0.50;   
            }
            if (emp.estadoCivil == 'c')
            {
                adicional_casado = 150000;
            }

        }  