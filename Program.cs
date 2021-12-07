using System.Security.AccessControl;
using System;

using Locadora_de_carro_console.Modelo;
using Locadora_de_carro_console.Repositorio;

namespace Locadora_de_carro_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-Cliente / 2- locadora");
            int escolha = int.Parse(Console.ReadLine());

            if(escolha == 1){
                double total = 0.0;
                int dia=0;
                string nome = "";

                while(escolha !=0 || escolha < 0){
                    Console.WriteLine();

                    foreach (int i in Enum.GetValues(typeof(Marca))){
			            Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Marca), i));
			        }

                    Console.WriteLine("Escolha o marca que desejas alugar: ");
                    escolha = int.Parse(Console.ReadLine());

                    if(escolha == 1){
                        Console.WriteLine("1- Uno R$47,90 p/dia");
                        Console.WriteLine("2- Cronos R$76,80 p/dia");
                        Console.WriteLine("3- Siena R$55,40");
                        Console.WriteLine("4>- Voltar");

                        Console.WriteLine("Escolha o modelo que desejas alugar: ");
                        escolha = int.Parse(Console.ReadLine());

                        if(escolha < 4){
                            Console.WriteLine("Quantos dias de aluguel? ");
                            dia = int.Parse(Console.ReadLine());
                            
                        }
                        if(escolha == 1){
                            total = 47.90 * dia;
                            escolha = 0;
                            nome = "Cronos";
                        }
                        if(escolha == 2){
                            total = 76.80 * dia;
                            escolha = 0;
                            nome = "Uno";
                        }
                        if(escolha == 3){
                            total = 55.40 * dia;
                            escolha = 0;
                            nome = "Siena";
                        }
                        if(escolha == 4){
                            escolha = 6;
                            continue;
                        }
                    }
                    if(escolha == 2){
                        Console.WriteLine("1- Ford Ka R$41,90 p/dia");
                        Console.WriteLine("2- Ranger R$200,80 p/dia");
                        Console.WriteLine("3- mustang R$485,99");
                        Console.WriteLine("4>- Voltar");

                        Console.WriteLine("Escolha o modelo que desejas alugar: ");
                        escolha = int.Parse(Console.ReadLine());

                        if(escolha < 4){
                            Console.WriteLine("Quantos dias de aluguel? ");
                            dia = int.Parse(Console.ReadLine());
                            
                        }
                        if(escolha == 1){
                            total = 41.90 * dia;
                            escolha = 0;
                            nome = "Ford ka";
                        }
                        if(escolha == 2){
                            total = 200.80 * dia;
                            escolha = 0;
                            nome = "Ranger";
                        }
                        if(escolha == 3){
                            total = 485.99 * dia;
                            escolha = 0;
                            nome = "Mustang";
                        }
                        if(escolha == 4){
                            escolha = 6;
                            continue;
                        }
                    }
                    if(escolha == 3){
                        Console.WriteLine("1- Onix R$48,90 p/dia");
                        Console.WriteLine("2- Prisma R$56,80 p/dia");
                        Console.WriteLine("3- Camaro R$325,99");
                        Console.WriteLine("4>- Voltar");

                        Console.WriteLine("Escolha o modelo que desejas alugar: ");
                        escolha = int.Parse(Console.ReadLine());

                        if(escolha < 4){
                            Console.WriteLine("Quantos dias de aluguel? ");
                            dia = int.Parse(Console.ReadLine());
                            
                        }
                        if(escolha == 1){
                            total = 48.90 * dia;
                            escolha = 0;
                            nome = "Onix";
                        }
                        if(escolha == 2){
                            total = 56.80 * dia;
                            escolha = 0;
                            nome = "Prisma";
                        }
                        if(escolha == 3){
                            total = 325.99 * dia;
                            escolha = 0;
                            nome = "Camaro";
                        }
                        if(escolha == 4){
                            escolha = 6;
                            continue;
                        }
                    }
                    if(escolha == 4){
                        Console.WriteLine("1- Gol R$31,90 p/dia");
                        Console.WriteLine("2- polo R$57,80 p/dia");
                        Console.WriteLine("3- jetta R$279,99");
                        Console.WriteLine("4>- Voltar");

                        Console.WriteLine("Escolha o modelo que desejas alugar: ");
                        escolha = int.Parse(Console.ReadLine());

                        if(escolha < 4){
                            Console.WriteLine("Quantos dias de aluguel? ");
                            dia = int.Parse(Console.ReadLine());
                            
                        }
                        if(escolha == 1){
                            total = 31.90 * dia;
                            escolha = 0;
                            nome = "Gol";
                        }
                        if(escolha == 2){
                            total = 57.80 * dia;
                            escolha = 0;
                            nome = "Polo";
                        }
                        if(escolha == 3){
                            total = 279.99 * dia;
                            escolha = 0;
                            nome = "Jetta";
                        }
                        if(escolha == 4){
                            escolha = 6;
                            continue;
                        }
                    }
                    if(escolha == 5){
                        Console.WriteLine("1- Versa R$59,90 p/dia");
                        Console.WriteLine("2- Kicks R$68,80 p/dia");
                        Console.WriteLine("3- Leaf R$305,99");
                        Console.WriteLine("4>- Voltar");

                        Console.WriteLine("Escolha o modelo que desejas alugar: ");
                        escolha = int.Parse(Console.ReadLine());

                        if(escolha < 4){
                            Console.WriteLine("Quantos dias de aluguel? ");
                            dia = int.Parse(Console.ReadLine());
                            
                        }
                        if(escolha == 1){
                            total = 59.90 * dia;
                            escolha = 0;
                            nome = "Versa";
                        }
                        if(escolha == 2){
                            total = 68.80 * dia;
                            escolha = 0;
                            nome = "Kicks";
                        }
                        if(escolha == 3){
                            total = 305.99 * dia;
                            escolha = 0;
                            nome = "Leaf";
                        }
                        if(escolha == 4){
                            escolha = 6;
                            continue;
                        }
                    }
            }
                ProgramCliente pg = new ProgramCliente();
                pg.programCliente();
                Console.WriteLine($"Veiculo: {nome} \nR${string.Format("{0:0.00}", total)}");  
                
            }
             
        }
    }
}
