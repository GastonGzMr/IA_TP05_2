using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA_TP05_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Estado> listaEstado1 = new List<Estado>
            {
                new Estado1(new bool[]{false,false}),
                new Estado1(new bool[]{true,true})
            };
            List<Estado> listaEstado2 = new List<Estado>
            {
                new Estado2(new bool[]{false,false,true,false,false}),
                new Estado2(new bool[]{true,true,true,false,false}),
                new Estado2(new bool[]{false,false,false,false,false}),
                new Estado2(new bool[]{false,false,true,false,false}),
                new Estado2(new bool[]{true,true,true,true,true}),
                new Estado2(new bool[]{true,false,true,true,false}),
                new Estado2(new bool[]{false,false,true,false,true}),
                new Estado2(new bool[]{false,true,true,true,false}),
            };
            Estado solucion;

            solucion = Algoritmo.Resolver(listaEstado1);
            if (solucion == null)
            {
                Console.WriteLine("No se ha encontrado una solución.");
            }
            else
            {
                Console.WriteLine("Solución encontrada:");
                Escribir(solucion.Clausulas);
            }

            solucion = Algoritmo.Resolver(listaEstado2);
            if (solucion == null)
            {
                Console.WriteLine("No se ha encontrado una solución.");
            }
            else
            {
                Console.WriteLine("Solución encontrada:");
                Escribir(solucion.Clausulas);
            }
            Console.ReadLine();
        }

        static void Escribir(bool[] clausulas)
        {
            foreach (bool clausula in clausulas)
            {
                Console.Write(clausula + " ");
            }
        }
    }
}
