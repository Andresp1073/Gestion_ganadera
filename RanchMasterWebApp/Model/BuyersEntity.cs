
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model;

public class BuyersEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdBuyer { get; set; }
    
    [Required]
    [StringLength(45)]
    public string Name { get; set; }
    
    [Required]
    [StringLength(45)]
    public string Cc { get; set; }
    
    [Required]
    [StringLength(45)]
    public string PhoneNumber { get; set; }
    
    public ICollection<SalesEntity> Sales { get; set; }

}