using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buscar_elemento
{
    internal class Program
    {
        class Nodo
        {
            public int info;
            public Nodo siguiente;
            public Nodo antes;
        };

        class listita
        {
            Nodo arrib;

            public listita()
            {
                arrib = null;
            }

            public void addend(int cantidad)
            {
                Nodo nodonuevo = new Nodo();
                nodonuevo.info = cantidad;
                nodonuevo.siguiente = null;
                nodonuevo.antes = null;
                if (arrib == null)
                {
                    arrib = nodonuevo;
                }
                else
                {
                    Nodo temporal = new Nodo();
                    temporal = arrib;
                    while (temporal.siguiente != null)
                        temporal = temporal.siguiente;
                    temporal.siguiente = nodonuevo;
                    nodonuevo.antes = temporal;
                }
            }

            public void busqueda(int buscarcant)
            {
                Nodo temporal = new Nodo();
                temporal = this.arrib;
                int encontrar = 0;
                int i = 0;

                if (temporal != null)
                {
                    while (temporal != null)
                    {
                        i++;
                        if (temporal.info == buscarcant)
                        {
                            encontrar++;
                            break;
                        }
                        temporal = temporal.siguiente;
                    }
                    if (encontrar == 1)
                    {
                        Console.WriteLine(buscarcant + " se encuentra en la posicion = " + i + ".");
                    }
                    else
                    {
                        Console.WriteLine(buscarcant + " no se encuentra en la lista");
                    }
                }
                else
                {
                    Console.WriteLine("No hay cantidades");
                }
            }

            public void mostrar()
            {
                Nodo ntemporal = new Nodo();
                ntemporal = this.arrib;
                if (ntemporal != null)
                {
                    Console.Write("\nEstos son sus números ");
                    while (ntemporal != null)
                    {
                        Console.Write(ntemporal.info + " ");
                        ntemporal = ntemporal.siguiente;
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("No hay nada para mostrar");
                }
            }
        }//

        class resultado
        {
            static void Main(string[] args)
            {
                listita miresultado = new listita();

                //numeros para insertar
                Console.WriteLine("Escribe una cantidad: ");
                int cant1 = int.Parse(Console.ReadLine());
                miresultado.addend(cant1);

                Console.WriteLine("\nEscribe una cantidad: ");
                int cant2 = int.Parse(Console.ReadLine());
                miresultado.addend(cant2);

                Console.WriteLine("\nEscribe una cantidad: ");
                int cant3 = int.Parse(Console.ReadLine());
                miresultado.addend(cant3);

                //muestra
                miresultado.mostrar();

                //buscar algo

                Console.WriteLine("\nEscriba la cantidad a buscar:");
                int busc1= int.Parse(Console.ReadLine());
                miresultado.busqueda(busc1);

                Console.WriteLine("\nEscriba otra cantidad a buscar:");
                int busc2 = int.Parse(Console.ReadLine());
                miresultado.busqueda(busc2);

                Console.WriteLine("\nEscriba otra cantidad a buscar:");
                int busc3 = int.Parse(Console.ReadLine());
                miresultado.busqueda(busc3);

                Console.ReadLine();
                
            }
        }
    }
}
