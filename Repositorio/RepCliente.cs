using System.Collections.Generic;
using Locadora_de_carro_console.Modelo;

namespace Locadora_de_carro_console.Repositorio
{
    public class RepCliente : IRepCliente
    {
              
        private List<Cliente> ListaCliente = new List<Cliente>();
        private static RepCliente instancia;
        public static RepCliente getInstancia(){
            if(instancia == null){
                instancia = new RepCliente();
            }
            return instancia;
        }
        
        public void Atualizar(int id, Cliente cliente)
        {
            ListaCliente[id] = cliente;
        }

        public void Exclui(int id)
        {
            //Remove o vetor
            //ListaCliente.RemoveAt(id);  

            //Marca como excluido
            ListaCliente[id].Exclui();

        }

        public void Insere(Cliente cliente)
        {
            ListaCliente.Add(cliente);
        }

        public List<Cliente> Lista()
        {
            return ListaCliente;
        }

        public int ProximoId()
        {
            return ListaCliente.Count;
        }

        public Cliente RetornaPorId(int id)
        {
            return ListaCliente[id];
        }
    }
}