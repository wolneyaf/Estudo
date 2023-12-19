

using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace WafSistemas.GerenciadorCliente.Security.JWT
{
    public static class JwtSecurity
    {
        private static string GenerateToken(string id, string user, string email, int expires = 8)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(Settings.Secret);
            var tokenDescripton = new SecurityTokenDescriptor
            {
                Expires = DateTime.UtcNow.AddDays(expires),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(key), algorithm: SecurityAlgorithms.HmacSha256Signature),
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(type: ClaimTypes.Name, value: user),
                    new Claim(type: ClaimTypes.Email, value: email),
                    new Claim(type: ClaimTypes.SerialNumber, value: id)
                })
            };

            var token = tokenHandler.CreateToken(tokenDescripton);
            return tokenHandler.WriteToken(token);
        }

        public static string GenerateTokenConfirmad(string id, string user, string email)
        {
            return GenerateToken(id: id, user: user, email: email, expires: 12);
        }

        public static string GenerateTokenAutoriza(string id, string user, string email)
        {
            return GenerateToken(id: id, user: user, email: email);
        }

        public static IEnumerable DecodeToken(string token)
        {
            var handler = new JwtSecurityTokenHandler();
            var jwtSecurityToken = handler.ReadJwtToken(token);
            return jwtSecurityToken.Claims;
        }

        public static bool ValidateToken(string authToken)
        {
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var validationParameters = GetValidationParameters();

                SecurityToken validatedToken;
                var principal = tokenHandler.ValidateToken(authToken, validationParameters, out validatedToken);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private static TokenValidationParameters GetValidationParameters()
        {
            return new TokenValidationParameters()
            {
                ValidateLifetime = false, // Because there is no expiration in the generated token
                ValidateAudience = false, // Because there is no audiance in the generated token
                ValidateIssuer = false,   // Because there is no issuer in the generated token
                ValidIssuer = "Sample",
                ValidAudience = "Sample",
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Settings.Secret)) // The same key as the one that generate the token
            };
        }

    }
}
