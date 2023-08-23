using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetodosExtensao.Extensions;

namespace MetodosExtensao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2023,07,21,8,10,45);
            Console.WriteLine(dt.ElapsedTime());
            // criando string utilizando o metodo Cut / corte
            string s1 = "Bom dia queridos estudantes!";
            Console.WriteLine(s1.Cut(10));

        }
    }
}
