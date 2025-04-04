using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model;

public class FeedingSchedulesEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int  IdSchedule { get; set; }
    
    [Required]
    [Column(TypeName = "DATE")]
    public DateOnly FeedingTime { get; set; }
    
    [Required]
    public int IdFeedingDetail { get; set; }
    
    [ForeignKey("IdFeedingDetails")]
    public FeedingDetailEntity FeedingDetail { get; set; }
    
    public ICollection<AnimalsEntity> Animals { get; set; }

}