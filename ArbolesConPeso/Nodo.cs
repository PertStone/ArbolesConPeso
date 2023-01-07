using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolesConPeso
{
    //modelo del nodo para la creacion del arbol generico 
    public class Nodo
    {
        public int Valor { get; set; }
        public  Nodo izquierda { get; set; }
        public  Nodo derecha { get; set; }
    }
}
