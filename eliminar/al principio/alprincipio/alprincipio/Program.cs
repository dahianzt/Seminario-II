using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace alprincipio
{
    internal class Program
    {
        class Nodo
        {
            public int info;
            public Nodo sgte;
            public Nodo anterior;
        }

        class listitaenlazada
        {
            Nodo cabeza;

            public listitaenlazada()
            {
                cabeza = null;
            }

            // Insertar un elemento al final
            public void paratras(int elementito)
            {
                Nodo nodonuevo = new Nodo();
                nodonuevo.info = elementito;
                nodonuevo.anterior = null;
                nodonuevo.sgte = null;

                if (cabeza == null)
                {
                    cabeza = nodonuevo;
                }
                else
                {
                    Nodo temporal = cabeza;

                    while (temporal.sgte != null)
                    {
                        temporal = temporal.sgte;
                    }

                    temporal.sgte = nodonuevo;
                    nodonuevo.anterior = temporal;
                }
            }

            // Borrar el primero
            public void noprimero()
            {
                if (this.cabeza != null)
                {
                    Nodo temporal = this.cabeza;
                    this.cabeza = this.cabeza.sgte;
                    temporal = null;
                    if (this.cabeza != null)
                        this.cabeza.anterior = null;
                }
            }

            // Mostrar la lista
            public void mostrar(bool mostrarEncabezado = true)
            {
                Nodo temporal = this.cabeza;
                if (temporal != null)
                {
                    if (mostrarEncabezado)
                    {
                        Console.WriteLine("\nEstos son sus numeros: ");
                    }

                    while (temporal != null)
                    {
                        Console.WriteLine(temporal.info + "");
                        temporal = temporal.sgte;
                    }

                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("No hay nada para mostrar");
                }
            }
        }

        class resultado
        {
            static void Main(string[] args)
            {   
                Console.OutputEncoding = Encoding.UTF8;
                listitaenlazada milista = new listitaenlazada();

                Console.WriteLine("Ingrese una cantidad 🐦");
                int num1 = int.Parse(Console.ReadLine());
                milista.paratras(num1);

                Console.WriteLine("\nIngrese una cantidad 🐦");
                int num2 = int.Parse(Console.ReadLine());
                milista.paratras(num2);

                Console.WriteLine("\nIngrese una cantidad 🐦");
                int num3 = int.Parse(Console.ReadLine());
                milista.paratras(num3);

                milista.mostrar();

                milista.noprimero();

                Console.WriteLine("\nSus numeros sin el primero:");
                milista.mostrar(false); 

                Console.ReadLine();
            }
        }
    }
}
