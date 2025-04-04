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
    public char Gender { get; set; }
    
    [Required]
    public int Age { get; set; }
    
    
    [Required]
    [StringLength(8)]
    public string Status { get; set; }
    
    // Claves foráneas
    public string IdLocation { get; set; }
    public LocationsEntity Location { get; set; }

    
    public string IdSchedule { get; set; }
    public SchedulesEntity Schedule { get; set; }


    
    public string IdReproduction { get; set; }
    public ReproductionsEntity  Reproduction { get; set; }

    
    public string IdRace  { get; set; }
    public RacesEntity Race { get; set; }
    
    //Lista
    
    public ICollection<SalesEntity> Sales { get; set; }

}