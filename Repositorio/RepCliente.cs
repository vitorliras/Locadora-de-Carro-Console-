using System.Collections.Generic;
using Locadora_de_carro_console.Modelo;

namespace Locadora_de_carro_console.Repositorio
{
    public class RepCliente : IRepCliente
    {
              
         private List<Cliente> ListaCliente = new List<Cliente>();

        
        public void Atualizar(int id, Cliente cliente)
        {
            throw new System.NotImplementedException();
        }

        public void Exclui(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Insere(Cliente cliente)
        {
            throw new System.NotImplementedException();
        }

        public List<Cliente> Lista()
        {
            throw new System.NotImplementedException();
        }

        public int ProximoId()
        {
            throw new System.NotImplementedException();
        }

        public Cliente RetornaPorId(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}