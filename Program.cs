using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_19_siesa
{
    class Nodo
    {
        public int Valor { get; set; }
        public int Peso { get; set; }
        public List<Nodo> Subarboles { get; set; }

        public Nodo(int valor, int peso)
        {
            Valor = valor;
            Peso = peso;
            Subarboles = new List<Nodo>();
        }
    }
    internal class Program
    {
        static void Main()
        {
            // Crear el árbol de ejemplo
            Nodo raiz = new Nodo(1, 10);
            Nodo nodo2 = new Nodo(2, 5);
            Nodo nodo3 = new Nodo(3, 8);
            Nodo nodo4 = new Nodo(4, 3);
            Nodo nodo5 = new Nodo(5, 12);

            raiz.Subarboles.Add(nodo2);
            raiz.Subarboles.Add(nodo3);
            nodo2.Subarboles.Add(nodo4);
            nodo3.Subarboles.Add(nodo5);

            // Imprimir el peso total del árbol
            int pesoTotal = CalcularPesoTotal(raiz);
            Console.WriteLine("El peso total del árbol es: " + pesoTotal);

            Console.ReadKey();
        }

        static int CalcularPesoTotal(Nodo nodo)
        {
            int pesoTotal = nodo.Peso;

            foreach (Nodo subarbol in nodo.Subarboles)
            {
                pesoTotal += CalcularPesoTotal(subarbol);
            }

            return pesoTotal;
        }
    }
}
