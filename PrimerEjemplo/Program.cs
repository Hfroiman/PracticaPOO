using System;

namespace PrimerEjemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cargar informacion de 10 productos
            Producto[] Vecpro = new Producto[10];

            for(int x = 0; x < 10; x++)
            {
                Vecpro[x] = new Producto();
                Console.WriteLine("Agregar codigo de producto: ");
                Vecpro[x].CodigoProducto = int.Parse(Console.ReadLine());
                Console.WriteLine("Agregar precio del producto: ");
                Vecpro[x].Precio = float.Parse(Console.ReadLine());
                Console.WriteLine("Agregar marca del producto, el rango debe de ser entre 1 a 10: ");
                Vecpro[x].marca = int.Parse(Console.ReadLine());
            }


            Ventas venta1 = new Ventas();
            Console.WriteLine("Ingresar el numero de cliente que realizo la compra: ");
            venta1.Cte = int.Parse(Console.ReadLine());
            while(venta1.Cte > 0)
            {
                Console.WriteLine("Ingresar codigo del producto: ");
                venta1.CodigoPro = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresar precio: ");
                venta1.Precio = float.Parse(Console.ReadLine());

                ///Se puedeen generar funciones, en donde solo se encien el objeto para trabajar-

                Console.WriteLine("Ingresar el numero de cliente que realizo la compra: ");
                venta1.Cte = int.Parse(Console.ReadLine());
            }
        }
    }
}
