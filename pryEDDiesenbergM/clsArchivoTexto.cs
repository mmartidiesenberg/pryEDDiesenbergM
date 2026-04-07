using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //sgregamos un espacio de nombre
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
        public void Recorrer()
        {
        }















    }
}
