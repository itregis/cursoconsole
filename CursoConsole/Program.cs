using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao, operacao=0;
            String cliente="", produto="";
            List<String> LisCli= new List<string>();
            ArrayList ListProduto = new ArrayList();

            Console.Clear();
            Console.WriteLine("1- Cliente");
            Console.WriteLine("2- Produto");
            Console.WriteLine("3- Sair");

            opcao = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            do{
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
                    Console.Write("Informe o nome do Cliente:");
                    cliente = Console.ReadLine();
                    LisCli.Add(cliente);
                    Console.Clear();
                }else if(operacao==2){
                    foreach(String cli in LisCli){

                    Console.WriteLine("Nome do Cliente: " + cli); 
                    }
                    if (LisCli.Count <= 0)
                    {
                        Console.Write("Inválido");
                                               
                    }

                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.Write("Inválido");
                    Console.ReadKey();
                }
            }else if(opcao==2){
                if(operacao==1){
                    Console.Write("Informe o nome do Produto:"); 
                    produto = Console.ReadLine();
                    ListProduto.Add(produto);
                    
                }else if(operacao==2){
                    foreach(String prod in ListProduto){

                    Console.WriteLine("Nome do Produto: " + prod); 
                    }

                    if (ListProduto.Count <= 0)
                    {
                        Console.Write("Inválido");

                    }
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.Write("Inválido");
                }
            }

            } while (opcao != 3);
            {
                Console.Write("Opção Inválida");
                Console.ReadKey();
            }
        }
    }
}
