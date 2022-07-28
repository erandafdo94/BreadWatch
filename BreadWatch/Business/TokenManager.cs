using BreadWatch.Business.Interfaces;
using BreadWatch.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace BreadWatch.Business
{
    public class TokenManager : ITokenManager
    {
        private readonly UserManager<ApplicationUser> userManger;
        private readonly IConfiguration configuration;

        public TokenManager(UserManager<ApplicationUser> userManger,
            IConfiguration configuration)
        {
            this.userManger = userManger;
            this.configuration = configuration;
        }

        public async Task<string> GenerateTokenAsync(ApplicationUser user)
        {
            var claims = new List<Claim>
            {
                new Claim (ClaimTypes.Email, user.Email),
                new Claim (ClaimTypes.Name, user.UserName),
            };

            var roles = await userManger.GetRolesAsync(user);

            foreach (var role in roles)
            {
                claims.Add(new Claim (ClaimTypes.Role, role));
            }

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Secret"]));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512);

            var tokenOptions = new JwtSecurityToken(
                issuer: null,
                audience: null,
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(tokenOptions);
        }
    }
}
