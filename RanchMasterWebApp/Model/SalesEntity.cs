using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model;

public class SalesEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdSale { get; set; }
   
    [Required]
    [DataType(DataType.Date)]
    public DateTime SaleDateTime { get; set; }
   
    //llave foranea
    public string IdBuyer { get; set; }
    public BuyersEntity Buyer { get; set; }
   
   
   
    public string IdAnimal { get; set; }
    public AnimalsEntity Animals { get; set; }

}