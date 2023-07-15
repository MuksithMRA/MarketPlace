using MarketPlace.Dtos;
using MarketPlace.Dtos.Responses;
using MarketPlace.Dtos.Requests;

namespace MarketPlace.Interfaces
{
public interface IUserService
{
    public Task<CommonResponse<RegisterRequestDto>> Register(RegisterRequestDto registerRequest);
    public Task<LoginResponse> Login(LoginRequest loginRequest);
    public UserDTO GetById(int id);
}
}
