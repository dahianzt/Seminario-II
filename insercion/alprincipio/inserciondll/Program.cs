using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inserciondll
{
    internal class Program
    {

    //en este aprenderemos a insertar en el comienzo, veamos:

        class Node
        
        {
            public int info;
            public Node previo;
            public Node siguiente;
        };

        class listita
        {
            Node cabeza;

            public listita()
            {
                cabeza = null;

            }

            public void veadelante(int elementonuevo)
            {
                Node newNode = new Node();
                newNode.info = elementonuevo;
                newNode.siguiente = null;
                newNode.previo = null;

                if (cabeza == null)
                {
                    cabeza = newNode;
                }
                else
                {
                    cabeza.previo = newNode;
                    newNode.siguiente = cabeza;
                    cabeza = newNode;

                }

            }

            //con este m. vamos a mostrar
            public void presentarlist()
            {
                Node temporal = new Node();
                temporal = this.cabeza;

                if (temporal != null)
                {
                    Console.WriteLine("Este es su resultado ");
                    while (temporal != null)
                    {
                        Console.WriteLine($"{temporal.info} ");
                        temporal = temporal.siguiente;
                    }

                    Console.WriteLine();
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("No hay nada que mostrar");
                }

            }
        };

        //vamos a ver resultado
        class muestra
        {
            static void Main(string[] args)
            {
                listita nuevlista = new listita();

                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("Bienvenidos, inserte las cantidades ❄️");

                Console.WriteLine("Inserte una cantidad:");
                int no1= int.Parse(Console.ReadLine());
                nuevlista.veadelante(no1);

                Console.WriteLine("Inserte otra cantidad:");
                int no2 = int.Parse(Console.ReadLine());
                nuevlista.veadelante(no2);

                Console.WriteLine("Inserte la tercera cantidad:");
                int no3= int.Parse(Console.ReadLine());
                nuevlista.veadelante(no3);

                Console.WriteLine("Inserte la cuarta cantidad:");
                int no4 = int.Parse(Console.ReadLine());
                nuevlista.veadelante(no4);

                nuevlista.presentarlist();
                
             
            }
        }
    }
}


