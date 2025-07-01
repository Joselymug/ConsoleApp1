using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Bodega
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public List<Producto> Productos { get; set; }
        public Bodega(string nombre, string direccion, string telefono)
        {
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            Productos = new List<Producto>();
        }
        public void AgregarProducto(Producto producto)
        {
            Productos.Add(producto);
        }
        public void MostrarProductos()
        {
            foreach (var producto in Productos)
            {
                Console.WriteLine($"Nombre: {producto.Nombre}, Precio: {producto.Precio}");
            }
        }
    }
}
