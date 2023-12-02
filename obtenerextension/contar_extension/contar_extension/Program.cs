using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contar_extension
{
    internal class Program
    {
        class Nodo
        {
            public Nodo sgte;
            public Nodo anterior;
            public int info;
        }

        class listita
        {
            Nodo primero;

            public listita()
            {
                primero = null;
            }

            public void patras(int elementito)
            {
                Nodo nuevonodo = new Nodo();
                nuevonodo.info = elementito;
                nuevonodo.sgte = null;
                nuevonodo.anterior = null;
                if (primero == null)
                {
                    primero = nuevonodo;
                }
                else
                {
                    Nodo temporal = new Nodo();
                    temporal = primero;

                    while (temporal.sgte != null)
                        temporal = temporal.sgte;
                    temporal.sgte = nuevonodo;
                    nuevonodo.anterior = temporal;
                }
            }

            //para contar
            public int paracontar()
            {
                Nodo temp = new Nodo();
                temp = this.primero;
                int i = 0;
                while (temp != null)
                {
                    i++;
                    temp = temp.sgte;
                }
                return i;
            }

            public void mostrar()
            {
                Nodo temp = new Nodo();
                temp = this.primero;
                if (temp != null)
                {
                    Console.Write("Estos son los números: ");
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
                listita misresultados = new listita();

                
                misresultados.patras(5);
                misresultados.patras(8);
                misresultados.patras(100);
                misresultados.patras(25);
                misresultados.patras(65);

                misresultados.mostrar();

                Console.WriteLine($"\nEl número de elementos es {misresultados.paracontar()}");
                Console.ReadLine();
            }
        }
    }
}
