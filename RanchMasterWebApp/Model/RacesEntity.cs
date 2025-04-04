using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model;

public class RacesEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdRace { get; set; }
    
    
    [Required]
    [StringLength(100)]
    public string Description { get; set; }
    
    [Required]
    [StringLength(45)]
    public string Name { get; set; }
    
    public ICollection<AnimalsEntity> Animals { get; set; }
    
}