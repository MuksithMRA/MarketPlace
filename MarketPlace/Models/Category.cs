using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MarketPlace.Models {
[Table("Category")]
public class Category {
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

    public ICollection<SubCategory> SubCategories {
        get;
        set;
    }
}
}
