using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
//sgregamos un espacio de nombre
//que tiene los metodos de procesamiento de archivos 

namespace pryEDDiesenbergM
{
    internal class clsArchivoTexto
    {
        //creamos una variable para guardar el nombre del archivo
        public string NomArchi = "Colores.txt";

        //Desarrollar los procedimientos
        public void Grabar()
        {
            StreamWriter AD = new StreamWriter(NomArchi, true); //Abrir AD para escritura
            AD.WriteLine("Hola!!!!"); //Escribe Hola!!!! y enter
            AD.Close(); //Cierra el archivo AD
        }
        public void Grabar(String Dato)
        {
            StreamWriter AD = new StreamWriter(NomArchi, true); //Abrir AD para escritura
            AD.WriteLine(Dato); //Escribe el contenido de la variable + <ENTER>
            AD.Close(); //Cierra el archivo AD
        }
        public void Grabar(String Codigo, String Nombre)
        {
            StreamWriter AD = new StreamWriter(NomArchi, true); //Abrir AD para escritura
            AD.Write(Codigo); //Escribe el contenido de la variable SIN enter
            AD.Write(";"); //Escribe punto y coma sin enter
            AD.WriteLine(Nombre); //Escribe el contenido de la variable + <ENTER>
            AD.Close(); //Cierra el archivo AD
        }
        public void Recorrer(ListBox lst)
        {
            String DatoLeido;
            lst.Items.Clear(); //Limpia el ListBox
            StreamReader AD = new StreamReader(NomArchi); //Abrir AD para lectura
            DatoLeido= AD.ReadLine(); //Lee la primera linea del archivo
            while (DatoLeido != null) //Mientras no se llegue al final del archivo
            {
                lst.Items.Add(DatoLeido); //Agrega el dato leido al ListBox
                DatoLeido = AD.ReadLine(); //Lee la siguiente linea del archivo
            }
            AD.Close(); //Cierra el archivo AD
        }















    }
}
