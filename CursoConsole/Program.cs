using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoConsole
{
    class Program
    {
        static void Main(string[] args)
        {//
            int opcao, operacao=0;
            String cliente="", produto="";

            Console.Clear();
            Console.WriteLine("1- Cliente");
            Console.WriteLine("2- Produto");
            Console.WriteLine("3- Sair");

            opcao = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            switch(opcao){

                case 1:
                    Console.WriteLine("1- Cadastrar Cliente");
                    Console.WriteLine("2- Consultar Cliente");
                    operacao= Convert.ToInt32(Console.ReadLine());
                    break;
                case 2:
                    Console.WriteLine("1- Cadastrar Produto");
                    Console.WriteLine("2- Consultar Produto");
                    operacao= Convert.ToInt32(Console.ReadLine());
                    break;
                case 3:
                    Console.WriteLine("Saindo...");
                   
                    break;
                default:
                    Console.WriteLine("Operação Inválida!");
                    break;
            }
            Console.Clear();
            if(opcao==1){
                if (operacao == 1)
                {
                    Console.Write("Informe o nome:"); 
                    cliente = Console.ReadLine();
                }else if(operacao==2){
                    Console.WriteLine("Nome do Cliente: " + cliente); 
                    Console.ReadKey();
                }
                else
                {
                    Console.Write("Inválido");
                }
            }else if(opcao==2){
                if(operacao==1){
                    Console.Write("Informe o nome:"); 
                    cliente = Console.ReadLine();

                }else if(operacao==2){
                    Console.WriteLine("Nome do Produto: " + produto); 
                    Console.ReadKey();
                }
                else
                {
                    Console.Write("Inválido");
                }
            }
        }
    }
}
