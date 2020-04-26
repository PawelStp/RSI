using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace RSIWebApi.Handlers
{
    public class JWTTokenHandler
    {
        public JWTTokenHandler()
        {

        }

        public string Generate(string name)
        {
            var jwtSecurityHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes("123456789201112131161617181920");
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                    {
                        new Claim(ClaimTypes.Name, name)
                    }),
                Expires = DateTime.UtcNow.AddDays(30),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = jwtSecurityHandler.CreateToken(tokenDescriptor);

            return jwtSecurityHandler.WriteToken(token);
        }
    }
}
