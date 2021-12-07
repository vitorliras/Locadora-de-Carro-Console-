using System;
using Locadora_de_carro_console.Modelo;
using Locadora_de_carro_console.Repositorio;

namespace Locadora_de_carro_console
{
    public class ProgramCliente
    {
        public void programCliente(){
            InserirCliente();
            int opcaoUsuario = Menu();

			while (opcaoUsuario != 0)
			{
				switch (opcaoUsuario)
				{
					case 1:
						AtualizarCliente();
						break;
					case 2:
						ExcluirCliente();
						break;
					case 3:
						VisualizarCliente();
						break;
					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoUsuario = Menu();
			}
            
        }

        private void InserirCliente()
        {
        Cliente c = new Cliente();

        Console.Write("Digite o nome: ");
        string nome = Console.ReadLine();
        c.setNome(nome);

        Console.Write("Digite seu CPF: ");
        string cpf = Console.ReadLine();
        c.setCpf(cpf);

        
        int id = RepCliente.getInstancia().ProximoId();
        Console.WriteLine("ID: "+id);
        RepCliente.getInstancia().Insere(c);
        }

        private void AtualizarCliente()
        {
            Cliente c = new Cliente();
            Console.Write("Digite o id: ");
		    int id = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();
            c.setNome(nome);

            Console.Write("Digite seu CPF: ");
            string cpf = Console.ReadLine();
            c.setCpf(cpf);

            c.setId(id);

            RepCliente.getInstancia().Atualizar(id,c);
        }

        private void ExcluirCliente()
        {
            Console.Write("Digite o id do produto: ");
		    int id = int.Parse(Console.ReadLine());

            RepCliente.getInstancia().Exclui(id);
        }

        private void VisualizarCliente()
        {
            Console.Write("Digite o id do produto: ");
            int id = int.Parse(Console.ReadLine());

            var cliente = RepCliente.getInstancia().RetornaPorId(id);

            Console.WriteLine(cliente);
        }

        private int Menu()
        {
        Console.WriteLine();
        
        Console.WriteLine("Informe a opção desejada:");

        Console.WriteLine("1- Atualizar seu cadastro");
        Console.WriteLine("2- Excluir seu cadastro");
        Console.WriteLine("3- Visualizar seu cadastro");
        Console.WriteLine("0- Sair");
        Console.WriteLine();

        int opcaoUsuario = int.Parse(Console.ReadLine());
        Console.WriteLine();
        return opcaoUsuario;
        }
    }
}