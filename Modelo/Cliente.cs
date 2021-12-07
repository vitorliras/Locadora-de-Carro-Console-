namespace Locadora_de_carro_console.Modelo
{
    public class Cliente 
    {
        private int id;
        private string nome;
        private string cpf;
        private bool Excluido;

        public override  string ToString(){
            string retorno = "";
            retorno += "ID -"+ this.id + System.Environment.NewLine;
            retorno += "Nome -" + this.nome + System.Environment.NewLine;
            retorno += "CPF -"+ this.cpf + System.Environment.NewLine;
            return retorno;
        }
        public int getId(){
            return this.id; 
        }
        public void setId(int id){
            this.id = id; 
        }
        public string getCpf(){
            return this.cpf; 
        }
        public void setCpf(string cpf){
            this.cpf = cpf; 
        }
        public string getNome(){
            return this.nome; 
        }
        public void setNome(string nome){
            this.nome = nome; 
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