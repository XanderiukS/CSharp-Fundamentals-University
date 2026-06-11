using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasSimplesConsola
{
    public class Lista
    {
        // Se declaran dos punteros principales que nos dirán dónde empieza y dónde termina la lista.
        // Al usar 'new Nodo()', se está creando un espacio en memoria para ellos desde el inicio.
        public Nodo primero =new Nodo();
        public Nodo ultimo = new Nodo();
        
        // El constructor de la clase.
        public Lista()
        {
            primero = null;
            ultimo = null;
        }
        // primero = null ---> ultimo = null
        //50
        //lista: 50 ---> 50
        //100
        //lista: 50 ---> 50 ---> 100 ---> null
        public void insertarNodo()
        {
            Nodo Nuevo = new Nodo();
            Console.WriteLine("Ingrese el dato que contendra el nuevo NODO");
            Nuevo.Dato = int.Parse(Console.ReadLine());

            if (primero == null )
            {
                primero = Nuevo;
                primero.Siguiente = null;
                ultimo = Nuevo;
            }
            else
            {
                ultimo.Siguiente = Nuevo;
                Nuevo.Siguiente = null;
                ultimo = Nuevo;
            }
            Console.WriteLine("\n Nodo Ingresado correctamente \n");
        }
        public void desplegarLista()
        {
            Nodo actual = new Nodo();
            actual = primero;
            if ( primero != null )
            {
                while (actual != null)
                {
                    Console.WriteLine("{0}", actual.Dato);
                    actual = actual.Siguiente;
                }
            }
            else
            {
                Console.WriteLine("\n La lista se encuentra vacia \n");
            }
        }
    }
}
    

