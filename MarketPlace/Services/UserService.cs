using AutoMapper;
using MarketPlace.Dtos;
using MarketPlace.Dtos.Requests;
using MarketPlace.Interfaces;
using MarketPlace.Models;
using MarketPlace.Utils;
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
        public async Task<string> Register(RegisterRequestDto registerRequest)
        {
                User user = _mapper.Map<User>(registerRequest);

                _context.Users.Add(user);
                _context.SaveChanges();
            
            return "";
        }
    }
}
