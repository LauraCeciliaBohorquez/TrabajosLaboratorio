using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Archivos
{
    public class Texto : IArchivo<string>
    {
        private string ArchivoString;

        public Texto(string archivo)
        {
            ArchivoString = archivo;           
        }

        public bool Guardar(string datos)
        {
            bool respuesta= false;

            using(StreamWriter sw = new StreamWriter(ArchivoString, true))
            {
                sw.WriteLine(datos);
                respuesta = true;
            }
            return respuesta;
        }

        public bool Leer(out List<string> lista)
        {
            lista = new List<string>();
            bool respuesta = false;
            
            using (StreamReader sr = new StreamReader(ArchivoString))
            {
                while (!sr.EndOfStream)
                {
                    lista.Add(sr.ReadLine());
                }
                respuesta = true;
            }

            return respuesta;
        }
    }
}
