namespace ejemploClase2.Model
{
    public class Carrera
    {
        public int Id { get; set; } 
        public string Nombre { get; set; }
        public int Duracion { get; set; }

        public Carrera(int id, string nombre, int duracion)
        {
            Id = id;
            Nombre = nombre;
            Duracion = duracion;
        }
    }
}
