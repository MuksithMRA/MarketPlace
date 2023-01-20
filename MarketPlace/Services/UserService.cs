using AutoMapper;
using MarketPlace.Dtos;
using MarketPlace.Dtos.NewFolder;
using MarketPlace.Dtos.Requests;
using MarketPlace.Interfaces;
using MarketPlace.Models;
using MarketPlace.Utils;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace MarketPlace.Services
{
    public class UserService : IUserService
    {
        private readonly DataContext _context;
        private IMapper _mapper;

        public UserService(DataContext context , IMapper mapper) {
            _context = context;
            _mapper = mapper;
         
        }

        public async Task<LoginResponse> Login(LoginRequest loginRequest)
        {   
            LoginResponse response = new LoginResponse();
            if(_context.Users.Any(x => x.Email == loginRequest.Email))
            {
                User user = _context.Users.First(x => x.Email == loginRequest.Email);
                user.Member = _context.Members.First(x => x.Id == user.MemberId);
                user.Member.Location = _context.Locations.First(x => x.Id == user.Member.LocationId);
                UserDTO userDto = _mapper.Map<UserDTO>(user);
                bool verified = BCrypt.Net.BCrypt.Verify(loginRequest.Password,userDto.Password);

                if (verified)
                {
                    response.UserDTO = userDto;
                    response.message = "Login Success";
                }
                else
                {
                    response.message = "Wrong Password ! Please try again.";
                }
            }
            else
            {
                response.message = "User doesn't exist for this Email";
            }
            return response;
        }

        public async Task<string> Register(RegisterRequestDto registerRequest)
        {
                registerRequest.Password = BCrypt.Net.BCrypt.HashPassword(registerRequest.Password);
                User user = _mapper.Map<User>(registerRequest);

                _context.Users.Add(user);
                _context.SaveChanges();
            
            return "";
        }
    }
}
