using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolesConPeso
{
    public static class ArbolEstatico
    {
        //nodo generico se puede modificar a gusto para realizar pruebas sobre el codigo
        public static Nodo Raiz
        {
            get
            {
                var Arbol = new Nodo()
                {
                    Valor = 4,
                    izquierda = new Nodo()
                    {
                        Valor = 2,
                        izquierda = new Nodo()
                        {
                            Valor = 3

                        }
                    },
                    derecha = new Nodo()
                    {
                        Valor = 1
                    }
                };
                return Arbol;  
            }
        }
    }
}
