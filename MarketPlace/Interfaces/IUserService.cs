using MarketPlace.Dtos;
using MarketPlace.Dtos.NewFolder;
using MarketPlace.Dtos.Requests;
using Microsoft.AspNetCore.Mvc;

namespace MarketPlace.Interfaces
{
    public interface IUserService
    {
        public Task<string> Register(RegisterRequestDto registerRequest);
        public Task<LoginResponse> Login(LoginRequest loginRequest);
    }
}
