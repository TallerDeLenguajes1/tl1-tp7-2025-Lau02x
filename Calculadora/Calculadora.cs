namespace EspacioCalculadora
{
    public class Calculadora
    {
        private double dato;
        public double resultado =0;
        public void Sumar(double termino)
        {
            dato += termino;
        }
        public void Dividir(double termino)
        {
            if (termino != 0)
            {
                dato = dato / termino;
             }
        }
        public double GetResultado()
        {
            return dato;
         }
     }
}
