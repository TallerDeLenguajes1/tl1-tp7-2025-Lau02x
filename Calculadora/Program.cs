  using EspacioCalculadora;
Calculadora miCalculadora = new Calculadora();
miCalculadora.Sumar(23);
miCalculadora.Sumar(10);
miCalculadora.Sumar(50);
miCalculadora.Sumar(2);
miCalculadora.Restar(35);
miCalculadora.Dividir(2);

Console.WriteLine($"El resultado es :  {miCalculadora.Resultado()}");