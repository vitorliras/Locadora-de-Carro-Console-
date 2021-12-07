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
        private int diaE, mesE, anoE, diaS, mesS, anoS;
        

       

        public override string ToString()
        {
            string retorno = "";
            retorno += "Id -"+ this.id + System.Environment.NewLine;
            retorno += "Valor -" + this.valor + System.Environment.NewLine;
            retorno += "Placa -"+ carro.ToString() + System.Environment.NewLine;
            retorno += "Data da saida do veiculo- " +$"{this.diaS}/{this.mesS}/{this.anoS}" + System.Environment.NewLine;
            retorno += "Data da Entrega do veiculo- " +$"{this.diaE}/{this.mesE}/{this.anoE}" + System.Environment.NewLine;
            return retorno;
        }
        
        public int getId(){
            return this.id; 
        }
        public void setId(int id){
            this.id = id; 
        }

        public int getDiaS(){
            return this.diaS; 
        }
        public void setDiaS(int diaS){
            this.diaS = diaS; 
        }

         public int getMesS(){
            return this.mesS; 
        }
        public void setMesS(int mesS){
            this.mesS = mesS; 
        }

         public int getAnoS(){
            return this.anoS; 
        }
        public void setAnoS(int anoS){
            this.anoS = anoS; 
        }

        public int getDiaE(){
            return this.diaE; 
        }
        public void setDiaE(int diaE){
            this.diaE = diaE; 
        }

         public int getMesE(){
            return this.mesE; 
        }
        public void setMesE(int mesE){
            this.mesE = mesE; 
        }

         public int getAnoE(){
            return this.anoE; 
        }
        public void setAnoE(int anoE){
            this.anoE = anoE; 
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

        
    }
}