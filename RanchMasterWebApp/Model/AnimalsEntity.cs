using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model;

public class AnimalsEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdAnimal { get; set; }

    [Required]
    [Column(TypeName = "char(1)")]
    public string Gender { get; set; }
    
    [Required]
    public int Age { get; set; }
    
    [Required]
    [StringLength(10)]
    public string Status { get; set; }
    
    //llave foranea
    
    [ForeignKey("IdSchedule")]
    public FeedingSchedulesEntity Schedule { get; set; }
    public int IdSchedule { get; set; } 
    
    // Relación con LocationsEntity
    public int IdLocation { get; set; }
    [ForeignKey("IdLocation")]
    public LocationsEntity Location { get; set; }

    // Relación con ReproductionsEntity
    [ForeignKey("IdReproduction")]
    public ReproductionsEntity Reproduction { get; set; }
    public int IdReproduction { get; set; }
    
    // Relación con RacesEntity
    public int IdRace { get; set; }
    [ForeignKey("IdRace")]
    public RacesEntity Race { get; set; }

    // Relación con SalesEntity (uno a muchos)
    public ICollection<SalesEntity> Sales { get; set; }
}

