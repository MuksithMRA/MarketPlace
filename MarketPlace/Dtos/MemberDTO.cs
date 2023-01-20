
namespace MarketPlace.Dtos
{
    public class MemberDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int LocationId { get; set; }
        public int PhoneNumber { get; set; }
        public LocationDTO LocationDTO { get; set; } = new LocationDTO();
    }
}
