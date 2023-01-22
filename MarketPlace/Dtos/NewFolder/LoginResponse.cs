namespace MarketPlace.Dtos.NewFolder
{
    public class LoginResponse
    {
        public UserDTO UserDTO { get; set; }
        public String Token { get; set; }
        public String Message { get; set; } = "Something went wrong !";
        public int StatusCode { get; set; } = StatusCodes.Status500InternalServerError;
        
    }
}
