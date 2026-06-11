using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasSimplesConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista ListaSimple = new Lista();
            ListaSimple.insertarNodo();
            ListaSimple.insertarNodo();
            ListaSimple.insertarNodo();
            ListaSimple.insertarNodo();
            ListaSimple.insertarNodo();
            ListaSimple.desplegarLista();
            Console.ReadLine();
        }
    }
}
