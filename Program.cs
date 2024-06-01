using System.Xml.XPath;
using EspacioTareas;
string parseUsage, descBusqueda;
int cantTareas, idTarea;
bool control;
Console.WriteLine("Ingrese la cantidad de tareas a realizar");
parseUsage = Console.ReadLine();
control = int.TryParse(parseUsage, out cantTareas);
if (control)
{
    List<Tarea> ListaTareasPendientes = new List<Tarea>();
    List<Tarea> ListaTareasRealizadas = new List<Tarea>();
    for (int i = 0; i < cantTareas; i++)
    {
        string Descripcion = "hc";
        int TareaID = i + 1;
        int Duracion = 60;
        Tarea tarea = new Tarea(Duracion, Descripcion, TareaID);
        ListaTareasPendientes.Add(tarea);
    }
    foreach (Tarea tarea in ListaTareasPendientes)
    {
        Console.WriteLine($"{tarea.Descripcion}");
        Console.WriteLine($"{tarea.TareaID}");
        Console.WriteLine($"{tarea.Duracion}");

    }
    Console.WriteLine("Inserte el id de la tarea que desee mover");
    parseUsage = Console.ReadLine();
    control = int.TryParse(parseUsage, out idTarea);
    Console.WriteLine();
    if (control)
    {
        Tarea nodoResultanteId = ListaTareasPendientes.Find(delegate (Tarea tr) { return tr.TareaID == idTarea; });
        ListaTareasRealizadas.Add(nodoResultanteId);
        ListaTareasPendientes.Remove(nodoResultanteId);
        Console.WriteLine("Lista Pendientes");
        foreach (Tarea tarea in ListaTareasPendientes)
        {
            Console.WriteLine($"{tarea.Descripcion}");
            Console.WriteLine($"{tarea.TareaID}");
            Console.WriteLine($"{tarea.Duracion}");

        }
        Console.WriteLine();
        Console.WriteLine("Lista Realizadas");
        foreach (Tarea tarea in ListaTareasRealizadas)
        {
            Console.WriteLine($"{tarea.Descripcion}");
            Console.WriteLine($"{tarea.TareaID}");
            Console.WriteLine($"{tarea.Duracion}");

        }

    }
    else
    {
        Console.WriteLine("Ingrese un id valido");
    }
    Console.WriteLine("Ingrese la descripcion de la tarea");
    descBusqueda = Console.ReadLine();
    Tarea nodoResultanteDescr = ListaTareasPendientes.Find(delegate (Tarea tr) { return tr.Descripcion == descBusqueda; });
    Console.WriteLine();
    Console.WriteLine("Nodo encontrado");
    Console.WriteLine(nodoResultanteDescr.TareaID);
    Console.WriteLine(nodoResultanteDescr.Descripcion);
    Console.WriteLine(nodoResultanteDescr.Duracion);

}
else
{
    Console.WriteLine("El numero que ingreso no es valido");
}
