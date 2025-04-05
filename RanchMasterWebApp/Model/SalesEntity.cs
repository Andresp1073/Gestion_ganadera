using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model;

public class SalesEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdSale { get; set; }
   
    [Required]
    [DataType(DataType.DateTime)]
    public DateTime SaleDateTime { get; set; }
    
    
    //llave foraneas
    public int IdBuyer { get; set; } 
    [ForeignKey("IdBuyer")]
    public BuyersEntity Buyer { get; set; }
   
    
    public int IdAnimal { get; set; }
    [ForeignKey("IdAnimal")]
    public AnimalsEntity Animal { get; set; }
}