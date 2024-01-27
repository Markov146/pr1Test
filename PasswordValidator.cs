using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp42
{
    public class PasswordValidator
    {
        public int VerifyPassword(string password)
        {
            int score = 0;
            if (Regex.IsMatch(password, @"\d"))
            {
                score++;
            }
            if (Regex.IsMatch(password, @"[a-z]"))
            {
                score++;
            }
            if (Regex.IsMatch(password, @"[A-Z]"))
            {
                score++;
            }
            if (Regex.IsMatch(password, @"[!@#$%^&*(),.?\:{ }|<_>]"))
            {
                score++;
            }
            if (password.Length > 7)
            {
                score++;
            }
            return score;
        }
    }
}
