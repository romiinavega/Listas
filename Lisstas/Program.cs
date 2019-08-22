using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lisstas
{
    class Program
    {
        private static object indiceColor;

        static void Main(string[] args)
        {
            List<string> colores =
                new List<string>();
            colores.Add("rojo");
            colores.Add("verde");
            colores.Add("rosa");
            colores.Add("azul");

            colores.RemoveAt(1);

            Console.WriteLine("Numero de elementos: " + colores.Count);
            int indiceColor = 1;
        foreach(string color in colores)

            {
                Console.WriteLine ("Elemento " + indiceColor.ToString() + ";" + color );
                indiceColor++;
            }



            Console.Read();
        }
    }
}
