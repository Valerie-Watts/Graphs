using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            int opt;
            string opt2;
            bool directed;
            int number;
            int vert1, vert2;

            // Pregunta si el grafo será dirigido o no
            Console.WriteLine("Do you wish your graph be directed? (Y/N)");
            opt2 = Console.ReadLine();

            directed = (opt2 == "Y" || opt2 == "y");

            Graph graph = new Graph(directed); // Crea el grafo según la opción del usuario

            while (true)
            {
                // Menú de opciones
                Console.WriteLine("\n ===Graphs!=== ");
                Console.WriteLine("Select an option: ");
                Console.WriteLine("1.Add vertix\n2.Add an Arc\n3.Show Adjacency list\n4.Delete Vertix\n5.Delete an Arc\n6.BFS\n7.DFS\n8.Exit");

                opt = Convert.ToInt32(Console.ReadLine());

                switch (opt)
                {
                    case 1:
                        Console.WriteLine("Write the number you wish to add: ");
                        number = Convert.ToInt32(Console.ReadLine());
                        graph.InsertVertix(number);
                        break;

                    case 2:
                        Console.WriteLine("Write the origin of the arc: ");
                        vert1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Write the destination of the arc: ");
                        vert2 = Convert.ToInt32(Console.ReadLine());

                        graph.InsertArcs(vert1, vert2);
                        break;

                    case 3:
                        graph.IMprint(); // Imprime la lista de adyacencia
                        break;

                    case 4:
                        Console.WriteLine("Write the vertix you want to erase: ");
                        number = Convert.ToInt32(Console.ReadLine());
                        graph.eraseVertix(number);
                        break;

                    case 5:
                        Console.WriteLine("Write the origin of the arc: ");
                        vert1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Write the destination of the arc: ");
                        vert2 = Convert.ToInt32(Console.ReadLine());

                        graph.eraseArcs(vert1, vert2);
                        break;

                    case 6:
                        Console.WriteLine("Write the origin of the search: ");
                        number = Convert.ToInt32(Console.ReadLine());

                        graph.BFS(number); // Ejecuta BFS
                        break;

                    case 7:
                        Console.WriteLine("Write the origin of the search: ");
                        number = Convert.ToInt32(Console.ReadLine());

                        graph.DFS(number); // Ejecuta DFS
                        break;

                    case 8:
                        Console.WriteLine("Goodbye!"); // Sale del programa
                        return;
                }
            }
        }
    }
}

