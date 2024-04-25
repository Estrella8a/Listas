using ListasSimplementeLigadas;

Console.WriteLine("Listas Simplemente Ligadas");

Lista miLista = new Lista();
miLista.Agregar("Cero");
miLista.Agregar("Uno");
miLista.Agregar("Dos");
miLista.Agregar("Tres");
miLista.Agregar("Cuatro");

string elementos = miLista.Recorrer();
Console.WriteLine(elementos);

Console.WriteLine();
Nodo encontrado = miLista.Buscar("Dos");

