using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model;

public class FeedingDetailsEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdFeedingDetail { get; set; }
    
    [Required]
    public int Quantity { get; set; }
    
    [Required]
    [StringLength(45)]
    public string FoodType{get; set; }
    
    public ICollection<FeedingSchedulesEntity> FeedingSchedules { get; set; }
}