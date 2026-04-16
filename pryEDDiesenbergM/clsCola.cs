using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryEDDiesenbergM
{
    internal class clsCola
    {
        //campos de la clase
        private clsNodo pri;
        private clsNodo ult;

        //propiedades de la clase
        public clsNodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }

        public clsNodo Ultimo
        {
            get { return ult; }
            set { ult = value; }
        }
        public void Agregar(clsNodo Nuevo)
        {
            if (pri == null)
            {
                pri = Nuevo;
                ult = Nuevo;
            }
            else
            {
                ult.Siguiente = Nuevo;
                ult = Nuevo;
            }
        }
        public void Eliminar()
        {
            if (Primero == Ultimo)
            {
                Primero = null;
                Ultimo = null;
            }
            else
            { 
            Primero = Primero.Siguiente;
            }
        }
    }
}