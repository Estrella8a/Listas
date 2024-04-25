using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ListasSimplementeLigadas
{
    public class Nodo
    {
        public string Value { get; set; }
        public Nodo Link { get; set; }
        public Nodo(string value = "", Nodo link = null)
        {
            Value = value;
            Link = link;
        }

    }
}
