namespace MarketPlace.Dtos.Requests {
public class RegisterRequestDto {
  public string Email { get; set; } = string.Empty;
  public string Role { get; set; } = string.Empty;
  public string Password { get; set; } = string.Empty;
  public MemberDTO Member { get; set; } = new MemberDTO();
}
}
