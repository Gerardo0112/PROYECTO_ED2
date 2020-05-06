using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROYECTO_ED2.COMPRESION_LZW
{
    public class TablaComprimir
    {
        public string path { get; set; }
        public string name { get; set; }
        public TablaComprimir(string t, string path)
        {
            name = t;
            this.path = path;
        }
    }
}
