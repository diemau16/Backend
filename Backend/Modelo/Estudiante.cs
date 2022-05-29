using System.ComponentModel.DataAnnotations;

namespace Backend.Modelo
{
    public class Estudiante
    {
        [Key]
        public int idEstudiante { get; set; }
        public string nombre { get; set; }
        public string carrera { get; set; }
        public int semestre { get; set; }
        public string correo { get; set; }
    }
}
