using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 
namespace RegistroGrupos;

[Table("Tutores")]
class Tutor
{
    public int Id { get; private set; }

    [Required, MaxLength(50)]
    public string? Nombre { get; set; }
    
    [NotMapped]
    public List<Grupo> Grupos { get; set; }
    
    public Tutor()
    {
        this.Id = new Random().Next(1,100);
        this.Grupos = new List<Grupo>();    
    }
}