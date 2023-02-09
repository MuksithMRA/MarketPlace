using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarketPlace.Models
{
[Table("Member")]
public class Member
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id {
        get;
        set;
    }

    [Required, MaxLength(255)]
    [Column("first_name")]
    public string FirstName {
        get;
        set;
    } = string.Empty;

    [Required, MaxLength(255)]
    [Column("last_name")]
    public string LastName {
        get;
        set;
    } = string.Empty;

    [Column("phone_number")]
    public int PhoneNumber {
        get;
        set;
    }

    [Required]
    [Column("location_id")]
    public int LocationId {
        get;
        set;
    }

    [ForeignKey("LocationId")]
    public virtual Location Location {
        get;
        set;
    } = new Location();

}
}
