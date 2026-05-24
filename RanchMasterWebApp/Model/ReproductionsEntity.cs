using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Model;

public class ReproductionsEntity
{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdBreeding { get; set; }
        
        [Required]
        [DataType(DataType.Date)]
        public DateTime MatingDate { get; set; }
        
        [Required]
        public int NumberOffspring { get; set; }
        
        [Required]
        [StringLength(45)]
        public string Status { get; set; }
        
        [Required]
        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }

}