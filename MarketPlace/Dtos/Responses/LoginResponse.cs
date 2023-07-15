namespace MarketPlace.Dtos.Responses;

public class LoginResponse {
    public UserDTO User {
        get;
        set;
    }
    public String Token {
        get;
        set;
    }
    public String Message {
        get;
        set;
    } = "Something went wrong !";
    public int StatusCode {
        get;
        set;
    } =
        StatusCodes.Status500InternalServerError;
}
