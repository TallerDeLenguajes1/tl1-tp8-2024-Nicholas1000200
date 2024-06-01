namespace EspacioTareas
{
    public class Tarea
    {
        private int tareaID { get => TareaID; set => TareaID = value;}
        private string descripcion { get => Descripcion; set => Descripcion = value;}
        private int duracion { get => Duracion; set => Duracion = value; }
        public int TareaID; 
        public string Descripcion; 
        public int Duracion; 

        

        public Tarea(int duracion, string descripcion, int tareaID)
        {
            Duracion = duracion;
            Descripcion = descripcion;
            TareaID = tareaID;
        }

    };
/*     public class MoverTareas(int id){
        
    } */
}
