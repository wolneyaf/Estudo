using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WafSistemas.GerenciadorCliente.Util
{
    public static class Function
    {
        public static string ReturnHexa(int Numeric)
        {
            return Numeric.ToString("X6");
        }

        public static string GenerateGuid()
        {
            Guid g = Guid.NewGuid();
            return g.ToString();
        }

        public static string EncodePassword(string password)
        {
            var senha64 = Encoding.ASCII.GetBytes(password);
            return  Convert.ToBase64String(senha64);
        }

        public static string DecodePassword(string password)
        {           
            var senha64 = Convert.FromBase64String(password);            
            return Encoding.ASCII.GetString(senha64); ;
        }

    }
}
