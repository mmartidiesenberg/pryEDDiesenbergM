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
            if (R == null) return;

            InOrdenAsc(Dgv, R.Izquierdo);
            Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            InOrdenAsc(Dgv, R.Derecho);
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
            if (R == null) return;

            TreeNode NodoPadre = new TreeNode(R.Codigo.ToString());
            nodoTreeView.Nodes.Add(NodoPadre);

            PreOrden(R.Izquierdo, NodoPadre);
            PreOrden(R.Derecho, NodoPadre);
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
        public void InOrden(ListBox lst, clsNodo R)
        {
            if (R == null) return;

            InOrden(lst, R.Izquierdo);
            lst.Items.Add(R.Codigo);
            InOrden(lst, R.Derecho);
        }

        public void PreOrden(ListBox lst, clsNodo R)
        {
            if (R == null) return;

            lst.Items.Add(R.Codigo);
            PreOrden(lst, R.Izquierdo);
            PreOrden(lst, R.Derecho);
        }

        public void PostOrden(ListBox lst, clsNodo R)
        {
            if (R == null) return;

            PostOrden(lst, R.Izquierdo);
            PostOrden(lst, R.Derecho);
            lst.Items.Add(R.Codigo);
        }
        public void PreOrdenGrilla(DataGridView dgv, clsNodo R)
        {
            if (R == null) return;

            dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            PreOrdenGrilla(dgv, R.Izquierdo);
            PreOrdenGrilla(dgv, R.Derecho);
        }

        public void PostOrdenGrilla(DataGridView dgv, clsNodo R)
        {
            if (R == null) return;

            PostOrdenGrilla(dgv, R.Izquierdo);
            PostOrdenGrilla(dgv, R.Derecho);
            dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
        }
        public void Equilibrar()
        {
            List<clsNodo> lista = new List<clsNodo>();
            RecolectarInOrden(Raiz, lista);
            Raiz = null;
            InsertarEquilibrado(lista, 0, lista.Count - 1);
        }

        private void RecolectarInOrden(clsNodo R, List<clsNodo> lista)
        {
            if (R == null) return;
            RecolectarInOrden(R.Izquierdo, lista);
            clsNodo nvo = new clsNodo();
            nvo.Codigo = R.Codigo;
            nvo.Nombre = R.Nombre;
            nvo.Tramite = R.Tramite;
            lista.Add(nvo);
            RecolectarInOrden(R.Derecho, lista);
        }

        private void InsertarEquilibrado(List<clsNodo> lista, int inicio, int fin)
        {
            if (inicio > fin) return;
            int medio = (inicio + fin) / 2;
            Agregar(lista[medio]);
            InsertarEquilibrado(lista, inicio, medio - 1);
            InsertarEquilibrado(lista, medio + 1, fin);
        }
    }
}
//