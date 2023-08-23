using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Clase
{
    internal class Expendedora
    {
        #region  Atributos 

        private string marca;
        private ushort cantproductos;
        private float precio;
        #endregion

        #region Metodos
        private void Saludar()
        {
            Console.WriteLine(" Bienvenido, elige un producto");
        }

        private void LimpiarDisplay()
        {
            Thread.Sleep(2000);
            Console.Clear();
        }

        public string MostrarProducto()
        {
            string codigo = "";
            Console.WriteLine(" 3A: Doritos \n 3B: Churrumais ");
            Console.WriteLine("Ingresa el código del producto:");
            codigo = Console.ReadLine();
            return codigo;
        }

        public void MostrarPrecio(string codigo)
        {
            switch (codigo)
            {
                case "3A":
                    Console.WriteLine("Precio: {0}", precio);
                    break;
                case "3B":
                    Console.WriteLine("Precio: {0}", precio - 6);
                    break;
                default:
                    Console.WriteLine("No ingresaste un producto válido");
                    break;

            }
        }

            #endregion

            #region Constructor

        public Expendedora()
            {
                marca = "AMS";
                precio = 18;
                Saludar();
                LimpiarDisplay();
                Console.WriteLine("Marca: {0}", marca);
                LimpiarDisplay();
                string codigo = MostrarProducto();
                LimpiarDisplay();
                MostrarPrecio(codigo);



            }
            #endregion
        
    }
}
