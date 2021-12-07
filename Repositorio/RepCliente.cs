using System.Collections.Generic;
using Locadora_de_carro_console.Modelo;

namespace Locadora_de_carro_console.Repositorio
{
    public class RepCliente : IRepCliente
    {
              
         private List<Cliente> ListaCliente = new List<Cliente>();

        
        public void Atualizar(int id, Cliente cliente)
        {
            ListaCliente[id] = cliente;
        }

        public void Exclui(int id)
        {
            
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