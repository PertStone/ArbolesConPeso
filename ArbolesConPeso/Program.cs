using System;
using System.Collections.Generic;
using System.Linq;

namespace ArbolesConPeso
{
    class Program
    {
        //Declaracion de variables
        private static int altura;
        private static int suma;
        private static Nodo raiz;
        private static float promedio;
        private static int nodos;

        static void Main(string[] args)
        {
            raiz = ArbolEstatico.Raiz;
            var pesoArbol = RetornarPesoArbol();
            var alturaArbol = RetornarAltura();
            var promedioArbol = RetornarPromedio();

            Console.WriteLine(
                "El arbol tiene un peso total de: " + pesoArbol + ", \n" +
                "Un promedio total de: " + promedioArbol+ ", \n" +
                "y Una altura total de: " + alturaArbol);
            
        }

        //metodo encargado de devolver la suma de los valores de los nodos
        public static int RetornarPesoArbol()
        {
            suma = 0;
            sumaNodos(raiz, 1);
            return suma;
        }

        //metodo encargado de devolver el promedio de los valores de los nodos
        public static float RetornarPromedio()
        {
            sumaNodos(raiz, 1);
            promedio =  suma/ (float)nodos;
            return promedio;
        }

        //metodo encargado de devolver la altura del arbol
        public static int RetornarAltura()
        {
            altura = 0;
            sumaNodos(raiz, 1);
            return altura;
        }

        //metodo encargado de recorrer los nodos y devolver valores
        private static void sumaNodos(Nodo arbol, int nivel)
        {          
            if (arbol != null)
            {
                nodos++;
                suma = suma + arbol.Valor;
                sumaNodos(arbol.izquierda, nivel + 1);
                if (nivel > altura)
                    altura = nivel;
                sumaNodos(arbol.derecha, nivel + 1);
            }
        }       
    }
}
