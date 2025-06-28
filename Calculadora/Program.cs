  using EspacioCalculadora;
int num = 0;
int activo = 1;
double resultado = 0;
int eleccion = 0;
string buff;
bool numerosCorrectos = false;
Calculadora miCalculadora = new Calculadora();
do
{
    Console.WriteLine("Dar un numero para hacer una operacion:");
    buff = Console.ReadLine();
    if (!int.TryParse(buff, out num))
    {
        System.Console.WriteLine("De un numero, no una cadena");
     }
} while (!int.TryParse(buff, out num));
miCalculadora.Sumar(num);


while (activo == 1){

    Console.WriteLine("--Elegir operacion --");
    Console.WriteLine("1:Suma\n2:Resta\n3:Multiplicacion\n4:Division\n5:Limpiar");
    buff = Console.ReadLine();
    eleccion = int.Parse(buff);
    if (eleccion == 4)
    {
        do
        {
            Console.WriteLine("Dar otro numero distinto de 0 para aplicarle la operacion:");
            buff = Console.ReadLine();
            num = int.Parse(buff);
        } while (num == 0);
    }
    else if (eleccion == 5) { Console.WriteLine("Se limpiara el resultado"); }
    else
    {
        Console.WriteLine("Dar otro numero para aplicarle la operacion:");
        buff = Console.ReadLine();
        num = int.Parse(buff);
    }
    switch (eleccion)
    {
        case 1:
            miCalculadora.Sumar(num);
            resultado = miCalculadora.Resultado();
            Console.WriteLine($"Se sumo el numero {num}, el resultado: {resultado} ");
            break;

        case 2:
            miCalculadora.Restar(num);
            resultado = miCalculadora.Resultado();
            Console.WriteLine($"Se resto el numero {num}, el resultado: {resultado} ");
            break;

        case 3:
            miCalculadora.Multiplicar(num);
            resultado = miCalculadora.Resultado();
            Console.WriteLine($"Se multiplico el numero {num}, el resultado: {resultado} ");
            break;

        case 4:
            miCalculadora.Dividir(num);
            resultado = miCalculadora.Resultado();
            Console.WriteLine($"Se dividio el numero {num}, el resultado: {resultado} ");
            break;

        case 5:
            miCalculadora.Limpiar();
            resultado = miCalculadora.Resultado();
            Console.WriteLine($"Se reseteo la calculadora, el resultado: {resultado} ");
            break;
        default: break;
    }
    do
    {
        Console.WriteLine("Seguir elegiendo numeros? 1:SI, 0: Salir");
        buff = Console.ReadLine();
        eleccion = int.Parse(buff);
        activo = eleccion;
        if (eleccion == 1 || eleccion == 0)
        {
            numerosCorrectos = true;
         }
     } while (!int.TryParse(buff,out  activo) && numerosCorrectos==false);
}