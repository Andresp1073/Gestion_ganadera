using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model;

public class FeedingSchedulesEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdSchedule { get; set; }

    [Required]
    public DateTime FeedingTime { get; set; }
    
    public int IdFeedingDetail { get; set; }
    
    //lave foranea
    [ForeignKey("IdFeedingDetail")]
    public FeedingDetailsEntity FeedingDetail { get; set; }

    public ICollection<AnimalsEntity> Animals { get; set; }
    
}
