using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetProjects.Models
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, Meu nome é {Nome}, e minha idade é {Idade} anos");
            // Console.WriteLine($"Olá, Meu nome é {Nome}\n e minha idade é {Idade} anos");
        }
    }
}