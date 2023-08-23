using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosExtensao.Extensions
{
    internal static class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime thisObj)
        {

            TimeSpan duracao = DateTime.Now.Subtract(thisObj);

            if(duracao.TotalDays < 24.0)
            {
                return duracao.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " Horas ";

            }
            else
            {
                return duracao.TotalDays.ToString("F1",CultureInfo.InvariantCulture) + " Dias ";
            }
        }
    }
}
