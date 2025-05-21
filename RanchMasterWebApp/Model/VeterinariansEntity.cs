using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model;

public class VeterinariansEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdVeterinarian { get; set; }
    
    [Required]
    [StringLength(45)]
    public string Name { get; set; }
    
    [Required]
    [StringLength(45)]
    public string Phone { get; set; }
    
    [Required]
    [StringLength(45)]
    public string Email { get; set; }
    
    public ICollection<HealthsRecordsEntity> HealthsRecords { get; set; }
    
}