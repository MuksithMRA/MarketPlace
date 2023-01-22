using MarketPlace.Models;

namespace MarketPlace.Interfaces
{
    public interface IJwtUtils
    {
        public string GenerateToken(User user);
        public int? ValidateToken(string token);
    }
}
