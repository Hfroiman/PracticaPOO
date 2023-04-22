using System;

namespace EjmploAnimales
{
    class Program
    {
        static void Main(string[] args)
        {
            Gato g1 = new Gato();

            Animal a1 = g1; //Copia todo lo del objeto g1, ya que la variable apunta a la misma direccion que el objeto G1

            Gato p2 = (Gato)a1; //Se puede hacer el casteo ya que uno sabe que la variable a1 posee un animal:gato
        }
    }
}
