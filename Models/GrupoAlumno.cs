using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 
namespace RegistroGrupos;

[Table("GruposAlumnos")]
class GrupoAlumno
{
    public int Id { get; set; }
    
    public int GrupoId { get; set; }
    
    public int AlumnoId { get; set; }

    [NotMapped]
    public Grupo? Grupo { get; set; }
    
    [NotMapped]
    public Alumno? Alumno { get; set; }
    
}