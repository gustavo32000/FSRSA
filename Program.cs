using System;

namespace FSRSA
{
    class Program
    {
        static void Main(string[] args){

        dataHora();   

        }
        /// <summary>
        /// A função dataHora exibe na tela de console a data e a hora do sistema. 
        /// </summary>
        
        static void dataHora(){

            Console.WriteLine(DateTime.Now);
                    
        }
    }
}
