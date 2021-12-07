using Locadora_de_carro_console.Enum;

namespace Locadora_de_carro_console.Modelo
{
    public class Carro
    {
        private string modelo;
        private string placa;
        private Marca marca;
        private string cor;

        public override  string ToString(){
            string retorno = "";
            retorno += "Marca -"+ this.marca + System.Environment.NewLine;
            retorno += "Modelo -" + this.modelo + System.Environment.NewLine;
            retorno += "Placa -"+ this.placa + System.Environment.NewLine;
            retorno += "Cor -"+ this.cor + System.Environment.NewLine;
            return retorno;
        }
        
        public string getModelo(){
            return this.modelo; 
        }
        public void setModelo(string modelo){
            this.modelo = modelo; 
        }
        public string getPlaca(){
            return this.placa; 
        }
        public void setPlaca(string placa){
            this.placa = placa; 
        }
         public Marca getMarca(){
            return this.marca; 
        }
        public void setMarca(Marca marca){
            this.marca = marca; 
        }
         public string getCor(){
            return this.cor; 
        }
        public void setCor(string cor){
            this.cor = cor; 
        }
        
    
    }
}