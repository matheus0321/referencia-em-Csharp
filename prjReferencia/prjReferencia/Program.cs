using System;

namespace prjReferencia
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int anoNasc,anoatual=2020;
            Console.WriteLine("Seja Bem Vindo");
            
            Console.WriteLine("Informe seu Nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Informe o ano de Nascimento ");
            anoNasc = int.Parse(Console.ReadLine());
            ano(ref anoNasc,anoatual,nome);
                                 
            Console.ReadKey();
        
        
        }
        static void ano (ref int anoNasc,int anoAtual,string nome){
            anoNasc = anoAtual - anoNasc;
            if (anoNasc >= 18)
            {
                Console.WriteLine("Ola {0} ,  você e maior  de idade {1}",nome,anoNasc);

            }
            else
            {
                Console.WriteLine("Ola {0} ,  você e menor   de idade {1}", nome, anoNasc);
            }
        
        }
    }
}
