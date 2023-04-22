using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerEjemplo
{
    class Producto
    {
        Producto(float precio, int codigo)
        {
            this.Precio = precio;
            this.CodigoProducto = codigo;
        }

        Producto() {}

        public int CodigoProducto { get; set; }
        public float Precio { get; set; }
        
        private int Marca;

        public int marca
        {
            get { return Marca; }
            set { if (value > 0 && value < 11)
                    Marca = value;
                else
                    Marca = -1;
            }
        }
    }