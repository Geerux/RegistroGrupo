using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 
namespace RegistroGrupos;

[Table("Carreras")]
class Carrera
{
    public int Id { get; private set; }

    [Required, MaxLength(50)]
    public string Nombre { get; set; }
    
    [NotMapped]
    public List<Grupo> Grupos { get; set; }

    
    
}