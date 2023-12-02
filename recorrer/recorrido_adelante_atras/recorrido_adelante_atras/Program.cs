using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recorrido_adelante_atras
{
    internal class Program
    {


        class Nodo
        {
            public int cantidad;
            public Nodo sgte;
            public Nodo antes;
        }

        class listita
        {
            private Nodo cabeza;

            //con esto ponemos al final
            public void addfinal(int valor)
            {
                Nodo nuevonodo = new Nodo { cantidad = valor, sgte = null, antes = null };

                if (cabeza == null)
                {
                    cabeza = nuevonodo;
                }
                else
                {
                    Nodo ultimo = conseguirultimo();
                    nuevonodo.antes = ultimo;
                    ultimo.sgte = nuevonodo;
                }
            }


            private Nodo conseguirultimo()
            {
                Nodo actual = cabeza;
                while (actual.sgte != null)
                {
                    actual = actual.sgte;
                }
                return actual;
            }


            public void presentoadelante()
            {
                Nodo actual = cabeza;
                while (actual != null)
                {
                    Console.Write(actual.cantidad + " ");
                    actual = actual.sgte;
                }
                Console.WriteLine();
            }

            // hacia atras
            public void presentoatras()
            {
                Nodo actual = conseguirultimo();
                while (actual != null)
                {
                    Console.Write(actual.cantidad + " ");
                    actual = actual.antes;
                }
                Console.WriteLine();
            }
        }

        class resultado
        {
            static void Main()
            {
                listita miresultado = new listita();

                //ingresar cantidades
                Console.WriteLine("Escriba una cantidad: ");
                int cant1 = int.Parse(Console.ReadLine());
                miresultado.addfinal(cant1);

                Console.WriteLine("\nEscriba una cantidad: ");
                int cant2 = int.Parse(Console.ReadLine());
                miresultado.addfinal(cant2);

                Console.WriteLine("\nEscriba una cantidad: ");
                int cant3 = int.Parse(Console.ReadLine());
                miresultado.addfinal(cant3);

                // recorrido adelante
                Console.WriteLine("\nLista hacia adelante:");
                miresultado.presentoadelante();

                // recorrido atrás 
                Console.WriteLine("\nLista hacia atrás:");
                miresultado.presentoatras();
                Console.ReadLine();
            }
        }

    }
}
