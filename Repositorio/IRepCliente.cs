using System.Collections.Generic;
using Locadora_de_carro_console.Modelo;

namespace Locadora_de_carro_console.Repositorio
{
    public interface IRepCliente
    {
         List<Cliente> Lista();
         Cliente RetornaPorId(int id);
         void Insere(Cliente cliente);
         void Exclui(int id);
         void Atualizar(int id, Cliente cliente);
         int ProximoId();
    }
}