using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MarketPlace.Models {
[Table("Brand")]
public class Brand {
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id {
        get;
        set;
    }

    [Required]
    [Column("name")]
    [MaxLength(255)]
    public string title {
        get;
        set;
    } = string.Empty;

    [Required]
    [Column("description")]
    public string description {
        get;
        set;
    } = string.Empty;

    [Required]
    [Column("image")]
    [MaxLength(255)]
    public string image {
        get;
        set;
    } = string.Empty;
}
}
