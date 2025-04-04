using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model;

public class HealthsRecordsEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdHealth { get; set; }
    
    [Required]
    [StringLength(100)]
    public string Diagnosis { get; set; }
    
    [Required]
    [StringLength(45)]
    public string Treatment { get; set; }
    
    [Required]
    public int IdVeterinarian { get; set; }
    
    [ForeignKey("IdVeterinarian")]
    public VeterinariansEntity Veterinarians { get; set; }
    
    [Required]
    [StringLength(45)]
    public string Vaccines { get; set; } 
    
    [Required]
    public int IdAnimal { get; set; }
    
    [ForeignKey("IdAnimal")]
    public AnimalsEntity Animals { get; set; }
}