using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace fin
{
    internal class Program
    {
        //ahora toca hacer la insercion al final
        class Node
        {
            public int info;
            public Node siguiente;
            public Node anterior;
        }//;

        class listita
        {
            Node cabeza;

            public listita()
            {
                cabeza = null;
            }

            public void enviaratras(int elementito)
            {
                Node elnodo = new Node();
                elnodo.info = elementito;
                elnodo.siguiente = null;
                elnodo.anterior = null;
                if (cabeza == null)
                {
                  cabeza = elnodo;
                }
                else
                {
                Node ntemporal = new Node();
                ntemporal = cabeza;
                while (ntemporal.siguiente != null)
                ntemporal = ntemporal.siguiente;
                ntemporal.siguiente = elnodo;
                elnodo.anterior = ntemporal;
                }
            }

            public void verlista()
            {
                Node eltemporal = new Node();
                eltemporal = this.cabeza;
                if (eltemporal != null)
                {
                    Console.Write("Este es el resultado: ");
                    while (eltemporal != null)
                    {
                        Console.Write(eltemporal.info + " ");
                        eltemporal = eltemporal.siguiente;
                    }
                    Console.WriteLine();
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("No hay nada para mostrar");
                }
            }
        };

        class resultado
        {
            static void Main(string[] args)
            {
                listita lalistaf = new listita();
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("Bienvenido ❄️");

                Console.WriteLine("Escriba la primera cantidad");
                int no1=int.Parse(Console.ReadLine());
                lalistaf.enviaratras(no1);

                Console.WriteLine("Escriba la segunda cantidad");
                int no2 = int.Parse(Console.ReadLine());
                lalistaf.enviaratras(no2);

                Console.WriteLine("Escriba la tercera cantidad");
                int no3 = int.Parse(Console.ReadLine());
                lalistaf.enviaratras(no3);

                Console.WriteLine("Escriba la cuarta cantidad");
                int no4 = int.Parse(Console.ReadLine());
                lalistaf.enviaratras(no4);

                lalistaf.verlista();
            }
        }
    }
}

