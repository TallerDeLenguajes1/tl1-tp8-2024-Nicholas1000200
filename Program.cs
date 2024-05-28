using EspacioTareas;
string parseUsage;
int cantTareas,idTarea;
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
        int TareaID = 4545563;
        int Duracion = 60;
        Tarea tarea = new Tarea(Duracion,Descripcion,TareaID);
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
if (control)
{
    
}

}else{
    Console.WriteLine("El numero que ingreso no es valido");
}
