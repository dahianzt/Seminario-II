using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace p_especifica
{
    internal class Program
    {
        class Node
        {
            public int info;
            public Node siguiente;
            public Node anterior;
        };

        class listaenlazada
        {
            Node cabeza;
            public listaenlazada()
            {
                cabeza = null;

            }


            //

            public void patras(int elementito)
            {
                Node newNode = new Node();
                newNode.info = elementito;
                newNode.siguiente = null;
                newNode.anterior = null;

                if (cabeza == null)
                {
                    cabeza= newNode;
                }
                else
                {
                    Node temp = new Node();
                    temp = cabeza;
                    while (temp.siguiente != null)
                    temp = temp.siguiente;
                    temp.siguiente = newNode;
                    newNode.anterior = temp;
                }
            }

            public void colocar (int elementito, int lugar)
            {
                Node newNode = new Node();
                newNode.info = elementito;
                newNode.siguiente = null;
                newNode.anterior = null;

                if (lugar < 1)
                {
                    Console.WriteLine("\nEl lugar es >=1.");
                }
                else if (lugar == 1)
                {
                    newNode.siguiente = cabeza;
                    cabeza.anterior = newNode;
                    cabeza = newNode;
                }
                else 
                {
                    Node temporal = new Node();
                    temporal = cabeza;
                    for (int i = 1; i < lugar-1; i++)
                    {
                        if (temporal != null)
                        {
                            temporal = temporal.siguiente;
                        }
                    }

                    if (temporal != null)
                    {
                        newNode.siguiente = temporal.siguiente;
                        newNode.anterior= temporal;
                        temporal.siguiente= newNode;
                        if (newNode.siguiente != null)
                            newNode.siguiente.anterior= newNode;
                    }
                    else
                    {
                        Console.WriteLine("\nNodo invalido");
                    }
                }
            }
            
            public void mostrar()
            {
                Node temporal = new Node();
                temporal = this.cabeza;
                if (temporal != null)
                {
                    Console.WriteLine("El resultado es: ");
                 
                while (temporal != null)
                    {
                        Console.WriteLine(temporal.info + "");
                        temporal = temporal.siguiente;
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Esta lista no tiene algo");
                }
            }
        }

        class resultados
        {
        static void Main(string[] args)
            {
                listaenlazada milista = new listaenlazada();
                //mis cantidades
                milista.patras(11);
                milista.patras(12);
                milista.patras(13);
                //para mostrar mis listas en terminal
                milista.mostrar();

                //para colocar un nuevo nodo en el segundo lugar
                milista.colocar(25, 2);
                milista.mostrar();
                //para colocar un nuevo nodo en el tercer lugar
                milista.colocar(46, 3);
                milista.mostrar();
                //para que no desaparezca mi terminal
                Console.ReadLine();
            }
        }
    }
}
