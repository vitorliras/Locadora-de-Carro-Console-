using System.Data.Common;
using System.ComponentModel;
using System;

namespace Locadora_de_carro_console.Modelo
{
    public class Locadora 
    {
        private int id;
        private double valor;
        private Carro carro;
        private bool Excluido;

        public override string ToString()
        {
            string retorno = "";
            retorno += "Id -"+ this.id + System.Environment.NewLine;
            retorno += "Valor -" + this.valor + System.Environment.NewLine;
            retorno += "Placa -"+ carro.ToString() + System.Environment.NewLine;
            return retorno;
        }
    
        public int getId(){
            return this.id; 
        }
        public void setId(int id){
            this.id = id; 
        }
        public double getValor(){
            return this.id; 
        }
        public void setValor(double valor){
            this.valor = valor; 
        }

        public Carro getCarro(){
            return this.carro; 
        }
        public void setCarro(Carro carro){
            this.carro = carro; 
        }
        public bool getExcluido()
		{
			return this.Excluido;
		}
        public void Exclui(){
            this.Excluido = true;
        }
        
    }
}