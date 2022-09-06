using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosCriados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TelaFilme telinha = new TelaFilme();
            telinha.Show();
            Console.ReadKey();
        }
    }
}
