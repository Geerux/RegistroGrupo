using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 
namespace RegistroGrupos;

[Table("Alumno")]
class Alumno
{
    public int Id { get; private set; }
    public int Matricula { get; set; }

    [Required, MaxLength(50)]
    public string? Nombre { get; set; }

    [Required, MaxLength(50)]
    public string? Apellidos { get; set; }
    
    [NotMapped]
    public List<GrupoAlumno> GrupoAlumnos { get; set; }
    
    public Alumno()
    {
        this.Matricula = new Random().Next(1,100);
        this.GrupoAlumnos = new List<GrupoAlumno>();  
    }
    //No lleva este random, es consecutivo
}