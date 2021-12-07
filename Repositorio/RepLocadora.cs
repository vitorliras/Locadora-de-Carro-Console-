using System.Collections.Generic;
using Locadora_de_carro_console.Modelo;

namespace Locadora_de_carro_console.Repositorio
{
    public class RepLocadora : IRepLocadora
    {
        private List<Locadora> ListaLocadora = new List<Locadora>();
        public void Atualizar(int id, Locadora locadora)
        {
            ListaLocadora[id] = locadora;
        }

        public void Exclui(int id)
        {
            ListaLocadora[id].Exclui();
        }

        public void Insere(Locadora locadora)
        {
            ListaLocadora.Add(locadora);
        }

        public List<Locadora> Lista()
        {
            return ListaLocadora;
        }

        public int ProximoId()
        {
           return ListaLocadora.Count;
        }

        public Locadora RetornaPorId(int id)
        {
            return ListaLocadora[id];
        }
    }
}