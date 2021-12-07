using System;
using Locadora_de_carro_console.Modelo;
using Locadora_de_carro_console.Repositorio;

namespace Locadora_de_carro_console
{
    public class ProgramLocadora
    {
        public void programLocadora(){
            
            int opcaoUsuario = Menu();

			while (opcaoUsuario != 0)
			{
				switch (opcaoUsuario)
				{
                    case 1:
						InserirCarro();
						break;
					case 2:
						AtualizarCarro();
						break;
					case 3:
						ExcluirCarro();
						break;
					case 4:
						VisualizarCarro();
						break;
                    case 5:
						ListarCarro();
						break; 
					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoUsuario = Menu();
			}
            
        }

        private void ListarCarro()
        {
            Console.WriteLine(RepLocadora.getInstancia().Lista());
        }

        private void VisualizarCarro()
        {
            Console.Write("Digite o id do Veículo: ");
            int id = int.Parse(Console.ReadLine());

            var Locadora = RepLocadora.getInstancia().RetornaPorId(id);

            Console.WriteLine(Locadora);
        }

        private void ExcluirCarro()
        {
            Console.Write("Digite o id do Veículo: ");
		    int id = int.Parse(Console.ReadLine());

            RepLocadora.getInstancia().Exclui(id);
        }

        private void AtualizarCarro()
        {

        Console.Write("Digite o id: ");
		int id = int.Parse(Console.ReadLine());

        Locadora l = new Locadora();
        Carro c = new Carro();

        l.setId(id);

        foreach (int i in Enum.GetValues(typeof(Marca))){
			Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Marca), i));
		}

        Console.Write("Digite a marca entre as opções acima: ");
        int marca = int.Parse(Console.ReadLine());
        c.setMarca((Marca)marca);
        

        Console.Write("Digite o modelo do veículo: ");
        string  modelo = Console.ReadLine();
        c.setModelo(modelo);

        Console.Write("Digite a placa do veículo: ");
        string placa = Console.ReadLine();
        c.setPlaca(placa);

        Console.Write("Digite o valor do aluguel do veículo: ");
        double valor = double.Parse(Console.ReadLine());
        l.setValor(valor);

        l.setCarro(c);

        RepLocadora.getInstancia().Atualizar(id, l);
        }

        private void InserirCarro()
        {
        Locadora l = new Locadora();
        Carro c = new Carro();

        foreach (int i in Enum.GetValues(typeof(Marca))){
			Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Marca), i));
		}

        Console.Write("Digite a marca entre as opções acima: ");
        int marca = int.Parse(Console.ReadLine());
        c.setMarca((Marca)marca);
        

        Console.Write("Digite o modelo do veículo: ");
        string  modelo = Console.ReadLine();
        c.setModelo(modelo);

        Console.Write("Digite a placa do veículo: ");
        string placa = Console.ReadLine();
        c.setPlaca(placa);

        Console.Write("Digite o valor do aluguel do veículo: ");
        double valor = double.Parse(Console.ReadLine());
        l.setValor(valor);

        l.setCarro(c);

        int id = RepLocadora.getInstancia().ProximoId();
        Console.WriteLine("ID: "+id);
        RepLocadora.getInstancia().Insere(l);

        }

        private int Menu()
        {
        Console.WriteLine();
        
        Console.WriteLine("Informe a opção desejada:");

        Console.WriteLine("1- Inserir o cadastro do veículo");        
        Console.WriteLine("2- Atualizar o cadastro do veículo");
        Console.WriteLine("3- Excluir o cadastro do veículo");
        Console.WriteLine("4- Visualizar o cadastro do veículo por id");
        Console.WriteLine("5- Visualizar todos os cadastros dos veículos");
        Console.WriteLine("0- Sair");
        Console.WriteLine();

        int opcaoUsuario = int.Parse(Console.ReadLine());
        Console.WriteLine();
        return opcaoUsuario;
        }
    }
}