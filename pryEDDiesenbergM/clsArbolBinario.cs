using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDDiesenbergM
{
    internal class clsArbolBinario
    {
        private clsNodo PrimerNodo;
        public clsNodo Raiz
        {
            get { return PrimerNodo; }
            set { PrimerNodo = value; }
        }

        public void Agregar (clsNodo Nvo)
        {
            if (Raiz == null)
            {
                Raiz = Nvo;
            }
            else
            {
                clsNodo Ant = Raiz;
                clsNodo Aux = Raiz;
                while (Aux != null)
                {
                    Ant = Aux;
                    if (Nvo.Codigo < Aux.Codigo) Aux = Aux.Izquierdo;
                    else Aux = Aux.Derecho;
                }
                if (Nvo.Codigo< Ant.Codigo) Ant.Izquierdo = Nvo;
                else Ant.Derecho = Nvo;
            }
        }

        public void Agregar (DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenAsc(Grilla, Raiz);
        }

        private void InOrdenAsc(DataGridView Dgv, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(Dgv, R.Izquierdo);
            Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Derecho != null) InOrdenAsc(Dgv, R.Derecho);

        }
        public void Recorrer (DataGridView Grilla )
        {
            Grilla.Rows.Clear();
            InOrdenAsc(Grilla, Raiz);
        }

        public void Recorrer (TreeView tree)
        {
            tree.Nodes.Clear();
            TreeNode NodoPadre = new TreeNode("Árbol");
            tree.Nodes.Add(NodoPadre);
            PreOrden(Raiz, NodoPadre);
            tree.ExpandAll();
        }
        public void Recorrer(ComboBox cmb)
        {
            cmb.Items.Clear();
            CargarCombo(Raiz, cmb);
        }

        private void CargarCombo(clsNodo R, ComboBox cmb)
        {
            if (R != null)
            {
                CargarCombo(R.Izquierdo, cmb);
                cmb.Items.Add(R.Codigo);
                CargarCombo(R.Derecho, cmb);
            }
        }

        private void PreOrden(clsNodo R, TreeNode nodoTreeView)
        {
            TreeNode NodoPadre = new TreeNode(R.Codigo.ToString());
            nodoTreeView.Nodes.Add(NodoPadre);
            if (R.Izquierdo != null) PreOrden(R.Izquierdo, NodoPadre);
            if(R.Derecho != null) PreOrden(R.Derecho, NodoPadre);
        }

        
        
        public void InOrdenDesc(ListBox Lst, clsNodo R)
        {
            if (R.Derecho != null)
            {
                InOrdenDesc(Lst, R.Derecho);
            }
            Lst.Items.Add(R.Codigo);
            if (R.Izquierdo != null)
            {
                InOrdenDesc(Lst, R.Izquierdo);
            }
        }
        public void Eliminar(int codigo)
        {
            Raiz = EliminarNodo(Raiz, codigo);
        }

        private clsNodo EliminarNodo(clsNodo nodo, int codigo)
        {
            if (nodo == null)
                return null;

            if (codigo < nodo.Codigo)
            {
                nodo.Izquierdo = EliminarNodo(nodo.Izquierdo, codigo);
            }
            else if (codigo > nodo.Codigo)
            {
                nodo.Derecho = EliminarNodo(nodo.Derecho, codigo);
            }
            else
            {
                // Sin hijos
                if (nodo.Izquierdo == null && nodo.Derecho == null)
                    return null;

                // Un hijo
                if (nodo.Izquierdo == null)
                    return nodo.Derecho;

                if (nodo.Derecho == null)
                    return nodo.Izquierdo;

                // Dos hijos
                clsNodo sucesor = nodo.Derecho;

                while (sucesor.Izquierdo != null)
                    sucesor = sucesor.Izquierdo;

                nodo.Codigo = sucesor.Codigo;
                nodo.Nombre = sucesor.Nombre;
                nodo.Tramite = sucesor.Tramite;

                nodo.Derecho = EliminarNodo(nodo.Derecho, sucesor.Codigo);
            }

            return nodo;
        }
    }
}
//