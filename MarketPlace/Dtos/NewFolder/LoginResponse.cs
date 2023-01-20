namespace MarketPlace.Dtos.NewFolder
{
    public class LoginResponse
    {
        public UserDTO UserDTO { get; set; }
        public String token { get; set; }
        public String message { get; set; } = "Something went wrong !";
    }
}
