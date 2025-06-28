// See https://aka.ms/new-console-template for more information
using EspacioCalculadora;
Calculadora miCalculadora = new Calculadora();
miCalculadora.Sumar(23);
miCalculadora.Sumar(10);
miCalculadora.Sumar(50);
miCalculadora.Sumar(2);

Console.WriteLine($"El resultado es :  {miCalculadora.GetResultado()}");
