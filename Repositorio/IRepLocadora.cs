using System.Collections.Generic;
using Locadora_de_carro_console.Modelo;

namespace Locadora_de_carro_console.Repositorio
{
    public interface IRepLocadora
    {
         List<Locadora> Lista();
         Locadora RetornaPorId(int id);
         void Insere(Locadora locadora);
         void Exclui(int id);
         void Atualizar(int id, Locadora locadora);
         int ProximoId();
         
    }
}