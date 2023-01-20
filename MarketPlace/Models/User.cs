using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MarketPlace.Models
{
    [Table("User")]
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity) , Key]
        [Column("id")]
        public int Id { get; set; }

        [Required , MaxLength(255)]
        [Column("email")]
        public string Email { get; set; } = string.Empty;

        [EnumDataType(typeof(Role)) , Required]
        [Column("role")]
        public string Role { get; set; } = string.Empty;

        [Required , MaxLength(20)]
        [Column("password")]
        public string Password { get; set; } = string.Empty;

        [Required]
        [Column("member_id")]
        public int MemberId { get; set; }

        [ForeignKey("MemberId")]
        [Required]
        public virtual  Member Member { get; set; } = new Member();
    }
}
