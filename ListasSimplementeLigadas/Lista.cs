using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasSimplementeLigadas
{
    internal class Lista
    {
        private Nodo _nodoInicial;

        public Lista()
        {
            _nodoInicial = new Nodo();
        }

        public bool EstaVacio()
        {
            if (_nodoInicial.Enlace == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Vaciar()
        {
            _nodoInicial.Enlace = null;
        }

        public string Recorrer()
        {
            string elementos = string.Empty;
            Nodo nodoActual = _nodoInicial;
            while (nodoActual.Enlace != null)
            {
                nodoActual = nodoActual.Enlace;
                //elementos = elementos + nodoActual.Valor + Environment.NewLine;
                elementos += $"{nodoActual.Valor}\n";
            }

            return elementos;
        }

        public void Agregar(string valor)
        {
            Nodo nodoActual = _nodoInicial;
            while (nodoActual.Enlace != null)
            {
                nodoActual = nodoActual.Enlace;
            }

            Nodo nodoNuevo = new Nodo(valor);
            nodoActual.Enlace = nodoNuevo;
        }

        public Nodo Buscar(string valor)
        {
            if (EstaVacio() == false)
            {
                Nodo nodoActual = _nodoInicial;
                while (nodoActual.Enlace != null)
                {
                    nodoActual = nodoActual.Enlace;
                    if (nodoActual.Valor == valor)
                    {
                        return nodoActual;
                    }
                }
            }
            return null;
        }

        public Nodo BuscarNodoAnterior(string valor)
        {
            if (EstaVacio() == false)
            {
                Nodo nodoActual = _nodoInicial;
                while (nodoActual.Enlace != null && nodoActual.Enlace.Valor != valor)
                {
                    nodoActual = nodoActual.Enlace;
                    if (nodoActual.Enlace.Valor == valor)
                    {
                        return nodoActual;
                    }
                }
            }
            return null;
        }

        public void Borrar(string valor)
        {
            if (EstaVacio() == false)
            {
                Nodo nodoActual = Buscar(valor);
                if (nodoActual != null)
                {
                    Nodo nodoAnterior = BuscarNodoAnterior(valor);
                    nodoAnterior.Enlace = nodoActual.Enlace;
                    nodoActual.Enlace = null;
                }
            }
        }
    }
}