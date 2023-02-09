using MarketPlace.Dtos;
using MarketPlace.Dtos.Responses;
using MarketPlace.Dtos.Requests;
using MarketPlace.Models;
using Microsoft.AspNetCore.Mvc;

namespace MarketPlace.Interfaces {
public interface IUserService {
  public Task<string> Register(RegisterRequestDto registerRequest);
  public Task<LoginResponse> Login(LoginRequest loginRequest);
  public UserDTO GetById(int id);
}
}
