﻿using AutoMapper;
using MarketPlace.Dtos;
using MarketPlace.Dtos.Responses;
using MarketPlace.Dtos.Requests;
using MarketPlace.Interfaces;
using MarketPlace.Models;
using MarketPlace.Utils;

namespace MarketPlace.Services
{
    public class UserService : IUserService
    {
        private readonly DataContext _context;
        private IMapper _mapper;
        private readonly IJwtUtils _jwtUtil;

        public UserService(DataContext context, IMapper mapper, IJwtUtils jwtUtil)
        {
            _context = context;
            _mapper = mapper;
            _jwtUtil = jwtUtil;
        }

        public UserDTO GetById(int id)
        {
            User? user = _context.Users.Find(id);
            if (user == null)
                return new UserDTO();
            user.Member = _context.Members.First(x => x.Id == user.MemberId);
            user.Member.Location =
                _context.Locations.First(x => x.Id == user.Member.LocationId);
            return _mapper.Map<UserDTO>(user);
        }

        public Task<LoginResponse> Login(LoginRequest loginRequest)
        {
            LoginResponse response = new LoginResponse();
            if (_context.Users.Any(x => x.Email == loginRequest.Email))
            {
                User user = _context.Users.First(x => x.Email == loginRequest.Email);
                user.Member = _context.Members.First(x => x.Id == user.MemberId);
                user.Member.Location = _context.Locations.First(x => x.Id == user.Member.LocationId);
                UserDTO userDto = _mapper.Map<UserDTO>(user);
                bool verified = BCrypt.Net.BCrypt.Verify(loginRequest.Password, userDto.Password);

                if (verified)
                {
                    response.User = userDto;
                    response.Token = _jwtUtil.GenerateToken(user);
                    response.Message = "Login Success";
                    response.StatusCode = StatusCodes.Status200OK;
                }
                else
                {
                    response.Message = "Wrong Password ! Please try again.";
                    response.StatusCode = StatusCodes.Status401Unauthorized;
                }
            }
            else
            {
                response.Message = "User doesn't exist for this Email";
                response.StatusCode = StatusCodes.Status404NotFound;

            }
            return Task.FromResult(response);
        }

        public Task<CommonResponse<RegisterRequestDto>> Register(RegisterRequestDto registerRequest)
        {
            CommonResponse<RegisterRequestDto> registerResponse = new CommonResponse<RegisterRequestDto>();
            registerRequest.Password = BCrypt.Net.BCrypt.HashPassword(registerRequest.Password);
            User user = _mapper.Map<User>(registerRequest);

            _context.Users.Add(user);
            _context.SaveChanges();
            registerRequest.Password = "";
            registerResponse.StatusCode = StatusCodes.Status201Created;
            registerResponse.Message = "User Registered Successfully";
            registerResponse.Data = registerRequest;
            return Task.FromResult(registerResponse);
        }
    }
}
