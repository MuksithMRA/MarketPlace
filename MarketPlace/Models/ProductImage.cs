using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MarketPlace.Models {
public class ProductImage {
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id {
        get;
        set;
    }

    [Required]
    [Column("image")]
    public string Image {
        get;
        set;
    } = string.Empty;

    [Required]
    [Column("product_id")]
    public int ProductId {
        get;
        set;
    } = 0;

    [ForeignKey("ProductId")]
    public virtual Product product {
        get;
        set;
    } = new Product();
}
}
