using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model;

public class LocationsEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdLocation { get; set; }
    
    [Required]
    [StringLength(45)]
    public string Name { get; set; }
    
    [Required]
    [StringLength(45)]
    public string Type { get; set; }
    
    [Required]
    public int Capacity { get; set; }
    
    
    
    public ICollection<AnimalsEntity> Animals { get; set; }
    
}