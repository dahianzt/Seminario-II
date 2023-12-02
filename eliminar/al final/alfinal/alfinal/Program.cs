using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alfinal
{
    internal class Program
    {

        class Nodo
        {
            public int info;
            public Nodo anterior;
            public Nodo siguiente;
            
        }

        class listita
        {
            Nodo cabeza;

            public listita()
            {
                cabeza = null;
            }

          
            public void patras(int numerito)
            {
                Nodo nuevonodo = new Nodo();
                nuevonodo.info = numerito;
                nuevonodo.siguiente = null;
                nuevonodo.anterior = null;
                if (cabeza == null)
                {
                    cabeza = nuevonodo;
                }
                else
                {
                    Nodo numtemporal = new Nodo();
                    numtemporal = cabeza;
                    while (numtemporal.siguiente != null)
                        numtemporal = numtemporal.siguiente;
                    numtemporal.siguiente = nuevonodo;
                    nuevonodo.anterior = numtemporal;
                }
            }

            
            public void interc()
            {
                if (this.cabeza != null)
                {
                    if (this.cabeza.siguiente == null)
                    {
                        this.cabeza = null;
                    }
                    else
                    {
                        Nodo nutemporal = new Nodo();
                        nutemporal = this.cabeza;
                        while (nutemporal.siguiente.siguiente != null)
                            nutemporal = nutemporal.siguiente;
                        Nodo ultimou = nutemporal.siguiente;
                        nutemporal.siguiente = null;
                        ultimou = null;
                    }
                }
            }

           
            public void mostrar()
            {
                Nodo temp = new Nodo();
                temp = this.cabeza;
                if (temp != null)
                {
                    Console.Write("Su resultado es: ");
                    while (temp != null)
                    {
                        Console.Write(temp.info + " ");
                        temp = temp.siguiente;
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Na por mostrar");
                }
            }
        }

        class resultadoo
        {
            static void Main(string[] args)
            {
                listita miresultado = new listita();

                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("Escriba una cantidad 🔢: ");
                int no1=int.Parse(Console.ReadLine());
                miresultado.patras(no1);

                Console.WriteLine("Escriba una cantidad 🔢: ");
                int no2 = int.Parse(Console.ReadLine());
                miresultado.patras(no2);

                Console.WriteLine("Escriba una cantidad 🔢: ");
                int no3 = int.Parse(Console.ReadLine());
                miresultado.patras(no3);

                
                miresultado.interc();
                miresultado.mostrar();
                Console.ReadLine();
            }
        }
    }
}
