using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 
namespace RegistroGrupos;

[Table("Grupos")]
class Grupo
{
    public int Id { get; private set; }

    [Required, MaxLength(50)]
    public string? Nombre { get; set; }

    public int CarreraId { get; set; }
    
    [NotMapped]
    public Carrera? Carrera { get; set; }
    
    public string? Periodo { get; set; }
    
    [Required, MaxLength(50)]
    public string? CicloEscolar { get; set; }
    
    public int TutorId { get; set; }
    
    [NotMapped]
    public Tutor? Tutores { get; set; }
    
    [NotMapped]
    public List<GrupoAlumno> GrupoAlumnos { get; set; }
    
    public Grupo()
    {
        this.Id = new Random().Next(1,100);
        this.GrupoAlumnos = new List<GrupoAlumno>(); 
    }
}