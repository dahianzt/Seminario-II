using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eliminar_especifico
{
    internal class Program
    {
        class Nodo
        {
            public int info;
            public Nodo siguiente;
            public Nodo anterior;
        }

        class listita
        {
            Nodo cabeza;

            public listita()
            {
                cabeza = null;
            }

            public void patras(int elemento)
            {
                Nodo nuevonodo = new Nodo();
                nuevonodo.info = elemento;
                nuevonodo.siguiente = null;
                nuevonodo.anterior = null;

                if (cabeza == null)
                {
                    cabeza = nuevonodo;
                }
                else
                {
                    Nodo temporal = cabeza;

                    while (temporal.siguiente != null)
                        temporal = temporal.siguiente;

                    temporal.siguiente = nuevonodo;
                    nuevonodo.anterior = temporal;
                }
            }

            // Eliminar por posición
            public void posicion(int lugar)
            {
                if (lugar < 1)
                {
                    Console.Write("\nLa posicion deberia ser >= 1");
                }
                else if (lugar == 1 && cabeza != null)
                {
                    Nodo nodoborrar = cabeza;
                    cabeza = cabeza.siguiente;
                    nodoborrar = null;
                    if (cabeza != null)
                        cabeza.anterior = null;
                }
                else
                {
                    Nodo temporal = cabeza;

                    for (int i = 1; i < lugar - 1; i++)
                    {
                        if (temporal != null)
                        {
                            temporal = temporal.siguiente;
                        }
                    }

                    if (temporal != null && temporal.siguiente != null)
                    {
                        Nodo nodoborrad = temporal.siguiente;
                        temporal.siguiente = temporal.siguiente.siguiente;

                        if (temporal.siguiente != null)
                            temporal.siguiente.anterior = temporal;

                        nodoborrad = null;
                    }
                    else
                    {
                        Console.Write("\nNo hay nada para borrar en esa posición.");
                    }
                }
            }

            public void mostrar()
            {
                Nodo temp = cabeza;
                if (temp != null)
                {
                    Console.Write("La lista es: ");
                    while (temp != null)
                    {
                        Console.Write(temp.info + " ");
                        temp = temp.siguiente;
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Nada que mostrar.");
                }
            }
        }

        class resultado
        {
            static void Main(string[] args)
            {
                listita miresultado = new listita();

                Console.WriteLine("Escriba una cantidad:");
                int no1 = int.Parse(Console.ReadLine());
                miresultado.patras(no1);

                Console.WriteLine("Escriba una cantidad:");
                int no2 = int.Parse(Console.ReadLine());
                miresultado.patras(no2);

                Console.WriteLine("Escriba una cantidad:");
                int no3 = int.Parse(Console.ReadLine());
                miresultado.patras(no3);

                Console.WriteLine("Escriba la posición a eliminar (debe ser 1, 2 o 3):");
                int deletep = int.Parse(Console.ReadLine());
                miresultado.posicion(deletep);
                miresultado.mostrar();

                Console.ReadLine();
            }
        }
    }
}
