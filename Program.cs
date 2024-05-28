using EspacioTareas;
string parseUsage;
int cantTareas;
bool control;
Console.WriteLine("Ingrese la cantidad de tareas a realizar");
parseUsage = Console.ReadLine();
control = int.TryParse(parseUsage, out cantTareas);
if (control)
{
    Tarea[] tareas = new Tarea[cantTareas];
    for (int i = 0; i < cantTareas; i++)
    {
        string Descripcion = "hc";
        int TareaID = 4545563;
        int Duracion = 60;
        tareas[i] = new Tarea(Duracion,Descripcion,TareaID);
    }
foreach (Tarea tarea in tareas)
{
    Console.WriteLine($"{tarea.Descripcion}");
    Console.WriteLine($"{tarea.TareaID}");
    Console.WriteLine($"{tarea.Duracion}");
}
}else{
    Console.WriteLine("El numero que ingreso no es valido");
}
