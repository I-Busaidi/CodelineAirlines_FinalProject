using CodelineAirlines.Helpers;
using CodelineAirlines.Models;

namespace CodelineAirlines.Services
{
    public interface IAuthService
    {
        JwtTokenResponse GenerateToken(User user);
        Task SaveTokenToCookie(string token);
        Task Logout();
    }
}