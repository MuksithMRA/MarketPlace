using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MarketPlace.Models
{
[Table("Sub_Category")]
public class SubCategory
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id {
        get;
        set;
    }

    [Required]
    [Column("name")]
    [MaxLength(255)]
    public string Title {
        get;
        set;
    } = string.Empty;

    [Required]
    [Column("description")]
    public string Description {
        get;
        set;
    } = string.Empty;

    [Required]
    [Column("image")]
    [MaxLength(255)]
    public string Image {
        get;
        set;
    } = string.Empty;

    [Required]
    [Column("brand_id")]
    public int BrandId {
        get;
        set;
    }

    [Required]
    [Column("category_id")]
    public int CategoryId {
        get;
        set;
    }

    [ForeignKey("BrandId")]
    public virtual Brand Brand {
        get;
        set;
    } = new Brand();

    [ForeignKey("CategoryId")]
    public virtual Category Category {
        get;
        set;
    } = new Category();

    public static implicit operator SubCategory(List<SubCategory> v)
    {
        throw new NotImplementedException();
    }
}
}
