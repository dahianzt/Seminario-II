using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invertir_nodos
{
    internal class Program
    {
        class Nodo
        {
            public Nodo anterior;
            public int info;
            public Nodo sgte;
        }

        class listita
        {
            Nodo cabeza;

            public listita()
            {
                cabeza = null;
            }

 
            public void patras(int elementito)
            {
                Nodo nuevonodo= new Nodo();
                nuevonodo.info = elementito;
                nuevonodo.sgte = null;
                nuevonodo.anterior = null;
                if (cabeza == null)
                {
                    cabeza = nuevonodo;
                }
                else
                {
                    Nodo temporal = new Nodo();
                    temporal = cabeza;
                    while (temporal.sgte != null)
                    temporal = temporal.sgte;
                    temporal.sgte = nuevonodo;
                    nuevonodo.anterior = temporal;
                }
            }

            public void parareversa()
            {
                if (this.cabeza != null)
                {
                    Nodo anteriornodo = this.cabeza;
                    Nodo nodotemporal = this.cabeza;
                    Nodo cnodo = this.cabeza.sgte;

                    anteriornodo.sgte = null;
                    anteriornodo.anterior = null;

                    while (cnodo != null)
                    {
                        nodotemporal = cnodo.sgte;
                        cnodo.sgte = anteriornodo;
                        anteriornodo.anterior = cnodo;
                        anteriornodo = cnodo;
                        cnodo = nodotemporal;
                    }

                    this.cabeza = anteriornodo;
                }
            }

            public void mostrar()
            {
                Nodo temp = new Nodo();
                temp = this.cabeza;
                if (temp != null)
                {
                    Console.Write("\nEsta es su lista de forma inversa: ");
                    while (temp != null)
                    {
                    Console.Write(temp.info + " ");
                    temp = temp.sgte;
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("No hay elementos");
                }
            }
        }

        class resultado
        {
            static void Main(string[] args)
            {
                listita milistaa = new listita();

                Console.WriteLine("Escriba una cantidad: ");
                int no1=int.Parse(Console.ReadLine());
                milistaa.patras(no1);

                Console.WriteLine("\nEscriba otra cantidad: ");
                int no2 = int.Parse(Console.ReadLine());
                milistaa.patras(no2);

                Console.WriteLine("\nEscriba otra cantidad: ");
                int no3 = int.Parse(Console.ReadLine());
                milistaa.patras(no3);

                Console.WriteLine("\nEscriba otra cantidad: ");
                int no4 = int.Parse(Console.ReadLine());
                milistaa.patras(no4);

                milistaa.parareversa();

                //resultado
                milistaa.mostrar();

                Console.ReadLine();
            }
        }
    }
}
